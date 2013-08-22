/*****************************************************************************
 * BrickBox.Models.Domain.Default
 * Default class used for inventory and wishlist object handling with the 
 *   database.
 * @author Kelly J Gimeno
 * @version 1
 * @date 08/22/2013
 *****************************************************************************/
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BrickBox.Models.Domain
{
    // Database 'Default' inherits from DbContext
    public class Default : DbContext
    {
        // Set inventory object into the inventory database table called 'Inventories'
        public DbSet<Inventory> Inventories { get; set; }

        // Set wishlist object into the wishlist database table called 'WishLists'
        public DbSet<WishList> Wishlists { get; set; }
    }
}