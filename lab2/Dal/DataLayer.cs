using lab2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace lab2.Dal
{
    public class DataLayer : DbContext
    {
        //DB of users
        public DbSet<User> Customers { get; set; }
        // DB od products
        public DbSet<Product> Products { get; set; }
        //Db of mechine
        public DbSet<Mechine> Mechines { get; set; }
        // DB  of weights
        public DbSet<Weights> Weights { get; set; }
        // Db of shops
        public DbSet<ShopsM> Shops { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //enitities
            modelBuilder.Entity<User>().ToTable("USERS");
            modelBuilder.Entity<Product>().ToTable("PRODUCTS");
            modelBuilder.Entity<Mechine>().ToTable("MECHINE");
            modelBuilder.Entity<Weights>().ToTable("WEIGHTS");
            modelBuilder.Entity<ShopsM>().ToTable("SHOPS");
        }

    }
} 