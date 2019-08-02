using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPosSystem
{
    class TransactionsDB
    {
        /// <summary>
        /// Pulls all transactions from the database and returns them in a list.
        /// </summary>
        /// <returns></returns>
        public static List<Transactions> GetTransactions()
        {
            using (var context = new OurRestaurantModel())
            {
                List<Transactions> transactions = context.Transactions.ToList();

                return transactions;
            }
        }

        /// <summary>
        /// Adds an individual transaction to the database
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static Transactions AddTransaction(Transactions order)
        {
            using (var context = new OurRestaurantModel())
            {
                context.Transactions.Add(order);
                context.SaveChanges();

                return order;
            }
        }
    }
}
