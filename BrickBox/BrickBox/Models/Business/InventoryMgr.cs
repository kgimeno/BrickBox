using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BrickBox.Models.Domain;
using BrickBox.Models.Services;

namespace BrickBox.Models.Business
{
    public class InventoryMgr : Manager
    {
        public void getSet(Inventory set, BrickBoxContext db)
        {
            try
            {
                Console.WriteLine("Entering method BrickBox.Models.Business::getSet");
                IInventorySvc inventorySvc = (IInventorySvc)GetService(typeof(IInventorySvc).Name);
                inventorySvc.getSet(set, db);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        }

        public void addSet(Inventory set, BrickBoxContext db)
        {
            try
            {
                Console.WriteLine("Entering method BrickBox.Models.Business::addSet");
                IInventorySvc inventorySvc = (IInventorySvc)GetService(typeof(IInventorySvc).Name);
                inventorySvc.addSet(set, db);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        }

        public void editSet(Inventory set, BrickBoxContext db)
        {
            try
            {
                Console.WriteLine("Entering method BrickBox.Models.Business::editSet");
                IInventorySvc inventorySvc = (IInventorySvc)GetService(typeof(IInventorySvc).Name);
                inventorySvc.editSet(set, db);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        }

        public void deleteSet(Inventory set, BrickBoxContext db)
        {
            try
            {
                Console.WriteLine("Entering method BrickBox.Models.Business::deleteSet");
                IInventorySvc inventorySvc = (IInventorySvc)GetService(typeof(IInventorySvc).Name);
                inventorySvc.deleteSet(set, db);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        }
    }
}