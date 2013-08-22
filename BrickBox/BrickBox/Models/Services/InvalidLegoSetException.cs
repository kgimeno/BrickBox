/*****************************************************************************
 * BrickBox.Models.Services.InvalidLegoSetException
 * InvalidLegoSetException customer exception class used if there is an 
 *   invalid lego set 
 * @author Kelly J Gimeno
 * @version 1
 * @date 08/22/2013
 *****************************************************************************/
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