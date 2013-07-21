using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BrickBox.Models.Domain;

namespace BrickBox.Models.Services
{
    public class LegoSetSvcImpl : ILegoSetSvc
    {
        public LegoSet getSet(LegoSet legoSet)
        {
            try
            {
                Console.WriteLine("Entering method BrickBox.Models.Services::getSet");
                return legoSet;            
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        }

        public void addSet(LegoSet legoSet)
        {
            try
            {
                Console.WriteLine("Entering method BrickBox.Models.Services::addSet");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        }

        public void removeSet(LegoSet legoSet)
        {
            try
            {
                Console.WriteLine("Entering method BrickBox.Models.Services::removeSet");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        }
    }
}