using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BrickBox.Models.Domain;

namespace BrickBox.Models.Services
{
    public class InventorySvcImpl : IInventorySvc 
    {
        public IQueryable<Inventory> getSet(Inventory set, BrickBoxContext db)
        {
            try
            {
                Console.WriteLine("Entering method BrickBox.Models.Services::getSet");
                var query = db.Inventories;
                return query;
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
                Console.WriteLine("Entering method BrickBox.Models.Services::addSet");
                db.Inventories.Add(set);
                db.SaveChanges();
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
                Console.WriteLine("Entering method BrickBox.Models.Services::editSet");
                db.SaveChanges();
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
                Console.WriteLine("Entering method BrickBox.Models.Services::deleteSet");
                db.Entry(set).State = System.Data.EntityState.Deleted;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        }
    }
}