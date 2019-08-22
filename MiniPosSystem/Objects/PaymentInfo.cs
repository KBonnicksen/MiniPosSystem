using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPosSystem
{
    /// <summary>
    /// Represents payment information regarding 
    /// a single transaction
    /// </summary>
    public class PaymentInfo
    {

        /// <summary>
        /// The unique Id of the order using a card
        /// (serves as order number)
        /// </summary>
        [Key]
        public int CardId { get; set; }

        /// <summary>
        /// The valid card number used in the transaction
        /// </summary>
        public ulong CardNumber { get; set; }

        /// <summary>
        /// The full name of the card holder 
        /// (the name on the credit/debit card)
        /// </summary>
        public string NameOnCard { get; set; }

        /// <summary>
        /// The credit/debit card company of the card in use
        /// ex. Visa, Mastercard, American Express
        /// </summary>
        public string CardType { get; set; }
    }
}
