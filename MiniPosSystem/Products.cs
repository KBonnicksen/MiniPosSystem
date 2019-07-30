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
    }
}
