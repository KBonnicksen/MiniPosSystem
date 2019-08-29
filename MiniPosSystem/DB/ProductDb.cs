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
            using (var context = new OurRestaurantModel())
            {
                List<Products> products = context.Products.ToList();

                return products;
            }  
        }

        public static List<Products> GetProductAddOns(int min, int max)
        {
            using (var context = new OurRestaurantModel())
            {
                List<Products> products = context.Products.Where(p => p.Id >= min && p.Id <= max).ToList();

                return products;
            }
        }

        public static List<Products> GetBeverages()
        {
            using (var context = new OurRestaurantModel())
            {
                List<Products> beverages = 
                    new List<Products>(context.Products.OfType<Beverages>().ToList());

                return beverages;
            }
        }

        public static List<Products> GetEntrees()
        {
            using (var context = new OurRestaurantModel())
            {
                List<Products> entrees = 
                    new List<Products>(context.Products.OfType<Entrees>().ToList());

                return entrees;
            }
        }

        public static List<Products> GetDesserts()
        {
            using (var context = new OurRestaurantModel())
            {
                List<Products> desserts =
                    new List<Products>(context.Products.OfType<Desserts>().ToList());

                return desserts;
            }
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
