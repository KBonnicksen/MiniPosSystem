using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPosSystem
{
    /// <summary>
    /// Represents a single product
    /// </summary>
    public class Products
    {
        /// <summary>
        /// The unique Id of a given product 
        /// (auto-incremented)
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The name of the associated product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The price of the associated product
        /// </summary>
        public decimal Price { get; set; }

        public virtual ICollection<Transactions> Transactions { get; set; }

        public List<Products> AddOnItems { get; set; }

        public override string ToString()
        {
            return $"{Name} - ${Price}";
        }
    }

    public class Beverages : Products
    {
        public new List<Products> AddOnItems()
        {
            return ProductDb.GetProductAddOns(13, 15);
        }
    }

    public class Entrees : Products
    {
        public new List<Products> AddOnItems()
        {
            return ProductDb.GetProductAddOns(10, 12);
        }
    }

    public class Desserts : Products
    {
        public new List<Products> AddOnItems()
        {
            return ProductDb.GetProductAddOns(15, 17);
        }
    }

    public class AddOnItem : Products
    {
    }
}
