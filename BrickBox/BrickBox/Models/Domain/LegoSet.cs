using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrickBox.Models.Domain
{
    public class LegoSet
    {
        public string setName { get; set; }
        public string setNumber { get; set; }
        public int pieceCount { get; set; }
        public double msrp { get; set; }
    }
}