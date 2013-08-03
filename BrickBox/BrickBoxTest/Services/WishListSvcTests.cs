/*
 * BrickBoxTest.Services
 * WishListSvcTests to test implementation methods
 * @author Kelly J Gimeno
 * @version 1
 * @date 07/25/2013
 */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrickBox.Models.Domain;
using BrickBox.Models.Services;
using System.Linq;

namespace BrickBoxTest.Services
{
    [TestClass]
    public class WishListSvcTests
    {
        /*
         * Method TestWishListSvcGet() using the service layer to retrieve a Lego set
         * from the database
         */
        [TestMethod]
        public void TestWishListSvcGet()
        {
            // Arrange - variable for database
            Default db = new Default();
            Factory factory = new Factory();
            WishList set = new WishList();
            IWishListSvc WishListSvc;

            set.name = "Creative Building Kit";
            set.model = "5749";
            set.pieces = 650;
            set.msrp = 67.00;

            db.Wishlists.Add(set);
            db.SaveChanges();

            // Act - use GetService method through the factory to add set to WishList
            WishListSvc = (IWishListSvc)factory.GetService("IWishListSvc");
            WishListSvc.getSet(set, db);

            // Act - get the set in the first position
            WishList retrievedSet = (from d in db.Wishlists where d.name == set.name select d).First();

            // Assert - verify that a set is stored in the first position
            Assert.AreEqual(retrievedSet.name, set.name);
            Assert.AreEqual(retrievedSet.model, set.model);
            Assert.AreEqual(retrievedSet.pieces, set.pieces);
            Assert.AreEqual(retrievedSet.msrp, set.msrp);
        }

        /*
         * Method TestWishListSvcAdd() to test whether an object WishList will add this 
         * set to the repository using the service layer
         */
        [TestMethod]
        public void TestWishListSvcAdd()
        {
            // Arrange - variables for testing the services
            Default db = new Default();
            Factory factory = new Factory();
            WishList set = new WishList();
            IWishListSvc WishListSvc;

            set.name = "Architecture Fallingwater";
            set.model = "21005";
            set.pieces = 811;
            set.msrp = 99.99;

            // Act - use GetService method through the factory to add set to WishList
            WishListSvc = (IWishListSvc)factory.GetService("IWishListSvc");
            WishListSvc.addSet(set, db);

            // Assert - verify that this set has been saved to the database
            WishList addedSet = (from d in db.Wishlists where d.wishlistID == set.wishlistID select d).Single();

            Assert.AreEqual(addedSet.name, set.name);
            Assert.AreEqual(addedSet.model, set.model);
            Assert.AreEqual(addedSet.pieces, set.pieces);
            Assert.AreEqual(addedSet.msrp, set.msrp);
        }

        /*
         * Method TestWishListSvcEdit() to test whether an object WishList can be edited 
         * from the repository using the service layer
         */
        [TestMethod]
        public void TestWishListSvcEdit()
        {
            // Arrange - variables for testing the services
            Default db = new Default();
            WishList set = new WishList();

            Factory factory = new Factory();
            IWishListSvc WishListSvc;

            set.name = "The Wizard Battle";
            set.model = "79005";
            set.pieces = 113;
            set.msrp = 12.99;

            db.Wishlists.Add(set);
            db.SaveChanges();

            WishList getSet = (from d in db.Wishlists where d.name == set.name select d).First();

            // Act - use GetService method through the factory to edit set from WishList
            getSet.msrp = 7.77;
            WishListSvc = (IWishListSvc)factory.GetService("IWishListSvc");
            WishListSvc.editSet(set, db);

            // Assert - verify that this set has been saved to the database
            WishList editedSet = (from d in db.Wishlists where d.wishlistID == getSet.wishlistID select d).Single();

            Assert.AreEqual(editedSet.name, getSet.name);
            Assert.AreEqual(editedSet.model, getSet.model);
            Assert.AreEqual(editedSet.pieces, getSet.pieces);
            Assert.AreEqual(editedSet.msrp, getSet.msrp);
        }

        /*
         * Method TestWishListSvcDelete() to test whether an object from the database
         * can be deleted from the repository using the service layer
         */
        [TestMethod]
        public void TestWishListSvcDelete()
        {
            // Arrange - variables for testing the services
            Default db = new Default();
            Factory factory = new Factory();
            WishList set = new WishList();
            IWishListSvc WishListSvc;

            set.name = "The Battle of Helm's Deep";
            set.model = "9474";
            set.pieces = 1368;
            set.msrp = 129.99;

            db.Wishlists.Add(set);
            db.SaveChanges();

            // Act - use GetService method through the factory to add set to WishList
            WishList savedSet = (from d in db.Wishlists where d.wishlistID == set.wishlistID select d).Single();
            WishListSvc = (IWishListSvc)factory.GetService("IWishListSvc");
            WishListSvc.deleteSet(savedSet, db);

            // Assert - verify that this set has been deleted from the database
            WishList deletedSet = (from d in db.Wishlists where d.wishlistID == savedSet.wishlistID select d).FirstOrDefault();

            Assert.IsNull(deletedSet);
        }
    }
}
