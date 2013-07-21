using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BrickBox.Models.Domain;
using BrickBox.Models.Services;

namespace BrickBox.Models.Business
{
    public class LegoSetMgr : Manager
    {
        public LegoSet getSet(LegoSet legoSet)
        {
            try
            {
                Console.WriteLine("Entering method BrickBox.Models.Business::getSet");
                ILegoSetSvc legoSetSvc = (ILegoSetSvc)GetService(typeof(ILegoSetSvc).Name);
                LegoSet legoInfo = legoSetSvc.getSet(legoSet);
                return legoInfo;
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
                Console.WriteLine("Entering method BrickBox.Models.Business::addSet");
                ILegoSetSvc legoSetSvc = (ILegoSetSvc)GetService(typeof(ILegoSetSvc).Name);
                legoSetSvc.addSet(legoSet);
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
                Console.WriteLine("Entering method BrickBox.Models.Business::removeSet");
                ILegoSetSvc legoSetSvc = (ILegoSetSvc)GetService(typeof(ILegoSetSvc).Name);
                legoSetSvc.removeSet(legoSet);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        }
    }
}