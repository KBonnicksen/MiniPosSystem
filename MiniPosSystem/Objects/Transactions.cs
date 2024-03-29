﻿using System;
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
        private decimal price;

        public Transactions()
        {
            this.Products = new List<Products>();
        }

        /// <summary>
        /// The unique Id of the transaction
        /// </summary>
        [Key]
        public int TransactionId { get; set; }

        /// <summary>
        /// The unique Id of the server associated with 
        /// a given transaction
        /// </summary>
        //public int ServerId { get; set; }
        public Servers Server { get; set; }

        /// <summary>
        /// The price of the transaction
        /// </summary>
        public decimal Price
        {
            get
            {
                decimal total = 0;
                foreach (Products p in this.Products)
                {
                    total += p.Price;
                }
                return total;
            }
            set => price = value; }

        /// <summary>
        /// The list of products associated with the
        /// transaction
        /// </summary>
        public virtual ICollection<Products> Products { get; set; }

        /// <summary>
        /// The payment information relating to this transaction
        /// </summary>
        ///public int? CardId { get; set; }
        public PaymentInfo PaymentInfo { get; set; }

        public void AddProd(Products p)
        {
            this.Products.Add(p);
            this.Price += p.Price;
        }
    }
}
