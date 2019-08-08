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
            //Sets the initial restaurant data 
            Database.SetInitializer<OurRestaurantModel>(new RestaurantDBInitializer());
        }

        // code first tutorial : https://www.entityframeworktutorial.net/code-first/simple-code-first-example.aspx
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public /*virtual*/ DbSet<Products> Products { get; set; }
        public virtual DbSet<Servers> Servers { get; set; }
        public virtual DbSet<PaymentInfo> PaymentInfo { get; set; }
        public /*virtual*/ DbSet<Transactions> Transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}