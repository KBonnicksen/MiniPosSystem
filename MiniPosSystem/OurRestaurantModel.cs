namespace MiniPosSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public partial class OurRestaurantModel : DbContext
    {
        // Your context has been configured to use a 'OurRestaurantModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MiniPosSystem.OurRestaurantModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'OurRestaurantModel' 
        // connection string in the application configuration file.
        public OurRestaurantModel()
            : base("name=OurRestaurantModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Servers> Servers { get; set; }
        public virtual DbSet<PaymentInfo> PaymentInfo { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
    }


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

    /// <summary>
    /// Represents an individual server
    /// </summary>
    public class Servers
    {
        /// <summary>
        /// The unique Id of the server
        /// </summary>
        [Key]
        public int ServerId { get; set; }

        /// <summary>
        /// The legal first name of the server
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The legal last name of the server
        /// </summary>
        public string LastName { get; set; }
    }

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
        public int CardNumber { get; set; }

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