using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SDA.Model;

namespace SDA
{
    public class StoreDbModel : DbContext
    {
        // Your context has been configured to use a 'StoreDbModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SDA.Context.StoreDbModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'StoreDbModel' 
        // connection string in the application configuration file.
        public StoreDbModel() : base("name=StoreDb")
        {
            Database.SetInitializer(new StoreDbInitalizer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasKey(p => p.Id);
            base.OnModelCreating(modelBuilder);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Subscribe> Subscribers { get; set; }
    }

    public class StoreDbInitalizer : DropCreateDatabaseAlways<StoreDbModel>
    {
        /// <summary>
        /// Set up some test data
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(StoreDbModel context)
        {
            context.Accounts.AddRange(new List<Account>
            {
                new Account
                {
                    Id = Guid.NewGuid().ToString(),
                    Type = "GUEST",
                    FirstName = "Test",
                    LastName = "User",
                    Email="test23@yahoo.com",
                    UserName = null,
                    Phone = "9123454543",
                    DateCreated = DateTime.Now,

                    Addresses = new List<Address>
                    {
                        new Address
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name="Test User 1",
                            AddressType = "PRIMARY",
                            Attention = "ALL",
                            City = "GlennDale",
                            Country = "USA",
                            StateOrProvidence = "FL",
                            StreetLine1 = "343 test street",
                            StreetLine2 = null,
                            Zip = "12345"

                        }
                    }

                }
            });
            base.Seed(context);
        }
    }
}