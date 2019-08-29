using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace MiniPosSystem
{
    public class RestaurantDBInitializer : CreateDatabaseIfNotExists<OurRestaurantModel>
    {
        protected override void Seed(OurRestaurantModel context)
        {
            IList<Products> defaultProducts = new List<Products>
            {
                new Entrees() { Id = 1, Name = "PB&J", Price = Convert.ToDecimal(6.6) },
                new Entrees() { Id = 2, Name = "Cuban", Price = Convert.ToDecimal(8.0) },
                new Entrees() { Id = 3, Name = "Reuben", Price = Convert.ToDecimal(8.5) },

                new Desserts() { Id = 4, Name = "Chocolate Cake", Price = Convert.ToDecimal(4.5) },
                new Desserts() { Id = 5, Name = "Strawberry Jell-O", Price = Convert.ToDecimal(3) },
                new Desserts() { Id = 6, Name = "Tiramisu", Price = Convert.ToDecimal(6) },

                new Beverages() { Id = 7, Name = "Lemonade", Price = Convert.ToDecimal(2) },
                new Beverages() { Id = 8, Name = "Milk", Price = Convert.ToDecimal(1.25) },
                new Beverages() { Id = 9, Name = "Long Island", Price = Convert.ToDecimal(7.5) },

                new AddOnItem() { Id = 10, Name = "Fries", Price = Convert.ToDecimal(3.5) },
                new AddOnItem() { Id = 11, Name = "Tater Tots", Price = Convert.ToDecimal(3.5) },
                new AddOnItem() { Id = 12, Name = "Side Salad", Price = Convert.ToDecimal(4) },

                new AddOnItem() { Id = 13, Name = "Vodka Shot", Price = Convert.ToDecimal(7) },
                new AddOnItem() { Id = 14, Name = "Colored Straw", Price = Convert.ToDecimal(1.25) },
                new AddOnItem() { Id = 15, Name = "Whip Cream", Price = Convert.ToDecimal(2) },

                new AddOnItem() { Id = 16, Name = "Ice Cream", Price = Convert.ToDecimal(2.25) },
                new AddOnItem() { Id = 17, Name = "Hot fudge", Price = Convert.ToDecimal(.75) },
            };

            context.Products.AddRange(defaultProducts);

            IList<Servers> defaultServers = new List<Servers>();

            defaultServers.Add(new Servers() { ServerId = 1, FirstName = "Daniel", LastName = "James" });
            defaultServers.Add(new Servers() { ServerId = 2, FirstName = "Mitchell", LastName = "Darin" });
            defaultServers.Add(new Servers() { ServerId = 3, FirstName = "Ryan", LastName = "Mitchell" });

            context.Products.AddRange(defaultProducts);
            context.Servers.AddRange(defaultServers);

            base.Seed(context);
        }
    }
}
