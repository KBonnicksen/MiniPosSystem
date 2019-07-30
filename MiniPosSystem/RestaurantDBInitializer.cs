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

            defaultProducts.Add(new Products() { Id = 1, Name = "PB&J", Price = Convert.ToDecimal(6.6) });
            defaultProducts.Add(new Products() { Id = 2, Name = "Cuban", Price = Convert.ToDecimal(8.0) });
            defaultProducts.Add(new Products() { Id = 3, Name = "Reuben", Price = Convert.ToDecimal(8.5) });

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
