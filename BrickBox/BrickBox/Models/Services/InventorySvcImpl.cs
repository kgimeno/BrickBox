/*****************************************************************************
 * BrickBox.Models.Services.InventorySvcImpl
 * InventorySvcImpl implements inventory services
 *   - getSet will retrieve a Lego set from the inventory database table
 *   - addSet will add a new Lego set to the inventory database table
 *   - editSet will edit an existing set from the inventory database table
 *   - deleteSet will delete an existing set from the inventory database table
 * @author Kelly J Gimeno
 * @version 1
 * @date 08/22/2013
 *****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BrickBox.Models.Domain;

namespace BrickBox.Models.Services
{
    public class InventorySvcImpl : IInventorySvc 
    {
        public IQueryable<Inventory> getSet(Inventory set, Default db)
        {
            try
            {
                Console.WriteLine("Entering method BrickBox.Models.Services::getSet");
                var query = db.Inventories;
                return query;
            }
            catch (InvalidLegoSetException e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        }

        public void addSet(Inventory set, Default db)
        {
            try
            {
                Console.WriteLine("Entering method BrickBox.Models.Services::addSet");
                db.Inventories.Add(set);
                db.SaveChanges();
            }
            catch (InvalidLegoSetException e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        }

        public void editSet(Inventory set, Default db)
        {
            try
            {
                Console.WriteLine("Entering method BrickBox.Models.Services::editSet");
                db.SaveChanges();
            }
            catch (InvalidLegoSetException e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        }

        public void deleteSet(Inventory set, Default db)
        {
            try
            {
                Console.WriteLine("Entering method BrickBox.Models.Services::deleteSet");
                db.Entry(set).State = System.Data.EntityState.Deleted;
                db.SaveChanges();
            }
            catch (InvalidLegoSetException e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        }
    }
}