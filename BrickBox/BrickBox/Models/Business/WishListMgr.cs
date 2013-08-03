using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BrickBox.Models.Domain;
using BrickBox.Models.Services;

namespace BrickBox.Models.Business
{
    public class WishListMgr : Manager
    {
        public void getSet(WishList set, Default db)
        {
            try
            {
                Console.WriteLine("Entering method BrickBox.Models.Business::getSet");
                IWishListSvc wishlistSvc = (IWishListSvc)GetService(typeof(IWishListSvc).Name);
                wishlistSvc.getSet(set, db);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        }

        public void addSet(WishList set, Default db)
        {
            try
            {
                Console.WriteLine("Entering method BrickBox.Models.Business::addSet");
                IWishListSvc wishlistSvc = (IWishListSvc)GetService(typeof(IWishListSvc).Name);
                wishlistSvc.addSet(set, db);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        }

        public void editSet(WishList set, Default db)
        {
            try
            {
                Console.WriteLine("Entering method BrickBox.Models.Business::editSet");
                IWishListSvc wishlistSvc = (IWishListSvc)GetService(typeof(IWishListSvc).Name);
                wishlistSvc.editSet(set, db);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        }

        public void deleteSet(WishList set, Default db)
        {
            try
            {
                Console.WriteLine("Entering method BrickBox.Models.Business::deleteSet");
                IWishListSvc wishlistSvc = (IWishListSvc)GetService(typeof(IWishListSvc).Name);
                wishlistSvc.deleteSet(set, db);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        }
    }
}