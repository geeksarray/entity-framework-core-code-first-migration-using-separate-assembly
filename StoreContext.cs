using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.DataModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        #region properties
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        #endregion
    }
}
