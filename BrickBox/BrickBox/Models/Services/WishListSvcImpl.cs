using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BrickBox.Models.Domain;

namespace BrickBox.Models.Services
{
    public class WishListSvcImpl : IWishListSvc
    {
        public IQueryable<WishList> getSet(WishList set, Default db)
        {
            try
            {
                Console.WriteLine("Entering method BrickBox.Models.Services::getSet");
                var query = db.Wishlists;
                return query;
            }
            catch (InvalidLegoSetException e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        }

        public void addSet(WishList set, Default db)
        {
            try
            {
                Console.WriteLine("Entering method BrickBox.Models.Services::addSet");
                db.Wishlists.Add(set);
                db.SaveChanges();
            }
            catch (InvalidLegoSetException e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        }

        public void editSet(WishList set, Default db)
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

        public void deleteSet(WishList set, Default db)
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