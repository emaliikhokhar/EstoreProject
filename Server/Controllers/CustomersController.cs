using Estore.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly EstoreDBContext DB = new EstoreDBContext();
        

        [HttpGet]
        [Route("ABC")]
        public bool get()
        {
            return true;
        }





        [HttpPost]
        [Route("PostCustomer")]
        public async void PostCustomer(Customer customer)
        {
            DB.Customers.Add(customer);
            await DB.SaveChangesAsync();
        }



        [HttpGet]
        [Route("isSeller")]
        public bool isSeller(Seller sellers)
        {
            var data = from s in DB.Sellers
                       where s.Email == sellers.Email && sellers.Password == s.Password
                       select s;
            if (data.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpDelete]
        [Route("DeleteSeller")]
        public void DeleteSeller(Seller sellers)
        {
            var x = (from y in DB.Sellers
                     where y.Email == sellers.Email
                     select y).FirstOrDefault();
            DB.Remove(x);
            DB.SaveChangesAsync();
        }

        [HttpPut]
        [Route("UpdateSeller")]
        public void PutSeller(string email, Seller sellers)
        {
            var query = from sell in DB.Sellers
                        where sell.Email == sell.Email
                        select sell;

            // Execute the query, and change the column values
            // you want to change.
            foreach (Seller sell in query)
            {
                sell.Name = sellers.Name;
                sell.Password = sellers.Password;
                sell.Address = sellers.Address;
                // Insert any additional changes to column values.
            }

            // Submit the changes to the database.
            try
            {
                DB.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Provide for exceptions.
            }
        }


    }
}
