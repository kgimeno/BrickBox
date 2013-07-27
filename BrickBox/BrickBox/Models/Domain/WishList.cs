using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrickBox.Models.Domain
{
    public class WishList
    {
        public Int32 wishlistID { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string model { get; set; }
        [Required]
        public int pieces { get; set; }
        public double msrp { get; set; }
    }
}