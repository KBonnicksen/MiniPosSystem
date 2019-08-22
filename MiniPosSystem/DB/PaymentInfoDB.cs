using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPosSystem
{
    class PaymentInfoDB
    {
        /// <summary>
        /// Gets all payments from the database
        /// </summary>
        /// <returns></returns>
        public static List<PaymentInfo> GetPayments()
        {
            using (var context = new OurRestaurantModel())
            {
                List<PaymentInfo> payments = context.PaymentInfo.ToList();

                return payments;
            }
        }

        /// <summary>
        /// Adds a new payment to the database
        /// </summary>
        /// <param name="newPayment"></param>
        /// <returns></returns>
        public static PaymentInfo AddPayment(PaymentInfo newPayment)
        {
            using (var context = new OurRestaurantModel())
            {
                context.PaymentInfo.Add(newPayment);
                context.SaveChanges();

                return newPayment;
            }
        }
    }
}
