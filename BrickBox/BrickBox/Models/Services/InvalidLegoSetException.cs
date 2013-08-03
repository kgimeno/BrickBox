using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrickBox.Models.Services
{
    public class InvalidLegoSetException : Exception
    {
        public InvalidLegoSetException(string s)
            : base(s)
        {
            throw new InvalidLegoSetException("Lego set is not valid");
        }

    }
}