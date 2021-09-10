using Estore.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly EstoreDBContext DB = new EstoreDBContext();


        // GET: api/Products/5

        //[HttpGet]
        //[Route("GetRecordsById/{id}")]
        //public async Task<ActionResult<Product>> GetProduct(int id)
        //{
        //    var product = await DB.Products.FindAsync(id);
        //    return product;
        //}

        [HttpGet]
        [Route("ShowProducts")]
        public List<Product> GetProducts()
        {
            List<Product> products = DB.Products.ToList<Product>();
            return products;
        }


        [HttpPost]
        [Route("AddProduct")]
        public async void AddProduct(Product p1)
        {
            DB.Products.Add(p1);
            await DB.SaveChangesAsync();
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await DB.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            DB.Products.Remove(product);
            await DB.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut]
        [Route("UpdateProduct")]
        public void UpdateProduct(Product p1)
        {
            var query = from prod in DB.Products
                        where prod.Name == p1.Name
                        select prod;

            // Execute the query, and change the column values
            // you want to change.
            foreach (Product pro in query)
            {
                pro.Name = p1.Name;
                pro.Price = p1.Price;
                pro.Discount = p1.Discount;
                pro.ImageAddress = p1.ImageAddress;
                pro.Category = p1.Category;
                pro.OwnerId = p1.OwnerId;
                pro.Ratings = p1.Ratings;
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
        [HttpGet("{id}")]
        [Route("getProductsByOwnerID")]
        public List<Product> getByID(int ID)
        {
            string id = ID.ToString();
            List<Product> products = DB.Products.Where(x => x.OwnerId == id).ToList<Product>();
            return products;
        }



        //[HttpGet("{id}")]
        [HttpGet]
        [Route("getProductsByID/{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            Console.WriteLine($" In get product {id}");
            Product pd = new Product();
            pd = await DB.Products.FindAsync(id);
            //var seller = DB.Sellers.Where(p => p.Id == System.Convert.ToInt32(product.OwnerId)).FirstOrDefault();

            //if (product == null)
            //{
            //    return NotFound();
            //}





            //pd.Id = product.Id;
            //pd.Name = product.Name;
            //pd.Price = product.Price;
            //pd.Discount = product.Discount;
            //pd.Category = product.Category;
            //pd.ImageAddress = product.ImageAddress;
            //pd.Ratings = product.Ratings;
            //pd.OwnerId = System.Convert.ToString(seller.Id);



            return pd;
        }


    }



}
