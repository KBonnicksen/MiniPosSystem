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
            IList<Products> defaultProducts = new List<Products>();

            defaultProducts.Add(new Entrees() { Id = 1, Name = "PB&J", Price = Convert.ToDecimal(6.6) });
            defaultProducts.Add(new Entrees() { Id = 2, Name = "Cuban", Price = Convert.ToDecimal(8.0) });
            defaultProducts.Add(new Entrees() { Id = 3, Name = "Reuben", Price = Convert.ToDecimal(8.5) });

            defaultProducts.Add(new Desserts() { Id = 4, Name = "Chocolate Cake", Price = Convert.ToDecimal(4.5) });
            defaultProducts.Add(new Desserts() { Id = 5, Name = "Strawberry Jell-O", Price = Convert.ToDecimal(3) });
            defaultProducts.Add(new Desserts() { Id = 6, Name = "Tiramisu", Price = Convert.ToDecimal(6) });

            defaultProducts.Add(new Beverages() { Id = 7, Name = "Lemonade", Price = Convert.ToDecimal(2) });
            defaultProducts.Add(new Beverages() { Id = 8, Name = "Milk", Price = Convert.ToDecimal(1.25) });
            defaultProducts.Add(new Beverages() { Id = 9, Name = "Long Island", Price = Convert.ToDecimal(7.5) });

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
