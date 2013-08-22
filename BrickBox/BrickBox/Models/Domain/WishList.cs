/*****************************************************************************
 * BrickBox.Models.Domain.WishList
 * WishList properties used to create the database using Entity Framework
 *   code first approach.  By using Entity Framework, it will auto-generate 
 *   basic CRUD (Create, Read, Update, Delete) functions.  WishList will be 
 *   used for any wishlist object handling
 * @author Kelly J Gimeno
 * @version 1
 * @date 08/22/2013
 *****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrickBox.Models.Domain
{
    public class WishList
    {
        // id used for storing this object in a specific location in the database
        public Int32 wishlistID { get; set; }

        // Required tag used to inform the user that this text field is required
        [Required]
        // Name of the Lego set
        public string name { get; set; }

        [Required]
        // Model number of the Lego set
        public string model { get; set; }
        
        [Required]
        // Number of pieces listed for this Lego set
        public int pieces { get; set; }

        // The listed Manufacturer's Suggested Retail Price
        public double msrp { get; set; }
    }
}