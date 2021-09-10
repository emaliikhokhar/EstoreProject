using Estore.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Estore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellersController : ControllerBase
    {
        private readonly EstoreDBContext DB = new EstoreDBContext();
        private ICredentialsByHost smtpCreds;

        [HttpGet("{email}")]
        [Route("ABC")]
        public string get(string email)
        {
            return email;
        }

        //[HttpPost]
        //public async Task<ActionResult<Seller>> PostSeller(Seller seller)
        //{
        //    var list = _context.Sellers.Where(l => l.Email == seller.Email).FirstOrDefault();
        //    if (list == null)
        //    {
        //        _context.Sellers.Add(seller);
        //        await _context.SaveChangesAsync();
        //        return CreatedAtAction("GetSeller", new { id = seller.Sid }, seller);
        //    }
        //    return NoContent();
        //}

        [HttpPost]
        [Route("PostSeller")]
        public async void PostSeller(Seller sellers)
        {
            DB.Sellers.Add(sellers);
            await DB.SaveChangesAsync();
        }

        //[HttpPost]
        //[Route("login")]
        //public async Task<ActionResult<Login>> Login(Login ll)
        //{
        //    var list = _context.Sellers.Where(l => l.Email == ll.email && l.Password == ll.password).FirstOrDefault();
        //    if (list != null)
        //    {
        //        string n = list.Shopname;
        //        HttpContext.Session.SetString("email", ll.email);
        //        HttpContext.Session.SetString("shop", n);
        //        return NoContent();
        //    }

        //    return BadRequest();


        //}

        [HttpPost]
        [Route("isSeller")]
        public async Task<ActionResult<Seller>> isSeller(Seller sellers)
        {
            var data = from s in DB.Sellers
                       where s.Email == sellers.Email && sellers.Password == s.Password
                       select s;
            if (data.Any())
            {
                return NoContent(); 
            }
            else
            {
                return BadRequest(); 
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




        //-----------------------------------
        [HttpGet]
        [Route("Mail")]
        public void sendMails()//object sender,EventArgs e)
        {
            string fromaddress = "osamariasat@gmail.com";
            string toaddress = "muhammadumairgcu@gmail.com";
            string password = "cyphwrbckihxavfd";

            MailMessage mail = new MailMessage();
            mail.Subject = "Testing Mail 2021";
            mail.From = new MailAddress(fromaddress);
            mail.Body = "Hello Sir , This is Example Please Check";
            mail.To.Add(new MailAddress(toaddress));

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = smtpCreds;
            smtp.UseDefaultCredentials = false;

            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            NetworkCredential nec = new NetworkCredential(fromaddress, password);
            smtp.Credentials = nec;
            smtp.Send(mail);

            Console.WriteLine("Successfully sent");
        }

    }
}
