using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPosSystem
{
    /// <summary>
    /// Represents a single transaction 
    /// </summary>
    public class Transactions
    {
        /// <summary>
        /// The unique Id of the transaction
        /// </summary>
        [Key]
        public int TransactionId { get; set; }

        /// <summary>
        /// The unique Id of the server associated with 
        /// a given transaction
        /// </summary>
        public int ServerId { get; set; }

        /// <summary>
        /// The price of the transaction
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The list of products associated with the
        /// transaction
        /// </summary>
        public virtual List<Products> Products { get; set; }

        /// <summary>
        /// The unique Id of the order using a card
        /// (serves as order number)
        /// </summary>
        public int CardId { get; set; }
    }
}
