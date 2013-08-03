using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BrickBox.Models.Domain
{
    public class Default : DbContext
    {
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<WishList> Wishlists { get; set; }
    }
}