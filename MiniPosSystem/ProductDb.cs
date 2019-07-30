using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPosSystem
{
    /// <summary>
    /// Contains helper methods for manipulating products table
    /// </summary>
    class ProductDb
    {

        /// <summary>
        /// Returns all products from the database
        /// </summary>
        /// <returns></returns>
        public static List<Products> GetProducts()
        {
            var db = new OurRestaurantModel();

            List<Products> products = db.Products.ToList();

            return products;
        }


        /// <summary>
        /// Adds new product object to database
        /// </summary>
        /// <param name="newProduct"></param>
        /// <returns></returns>
        public static Products AddProduct(Products newProduct)
        {
            using (var context = new OurRestaurantModel() )
            {
                context.Products.Add(newProduct);
                context.SaveChanges();

                return newProduct;
            }
        }
    }
}
