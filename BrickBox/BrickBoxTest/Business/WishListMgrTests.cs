using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrickBox.Models.Domain;
using BrickBox.Models.Business;
using System.Linq;

namespace BrickBoxTest.Business
{
    [TestClass]
    public class WishListMgrTests
    {
        /*
         * Method TestWishListMgrGet() using the Business layer to retrieve a Lego set
         * from the database
         */
        [TestMethod]
        public void TestWishListMgrGet()
        {
            // Arrange - variable for database
            Default db = new Default();
            WishList set = new WishList();
            WishListMgr wishlistMgr = new WishListMgr();

            set.name = "Castle Medieval Market Village";
            set.model = "10193";
            set.pieces = 1601;
            set.msrp = 149.71;

            db.Wishlists.Add(set);
            db.SaveChanges();

            // Act - use GetService method through the Manager class get set from wishlist
            wishlistMgr.getSet(set, db);

            // Act - get the set in the first position
            WishList retrievedSet = (from d in db.Wishlists where d.name == set.name select d).First();

            // Assert - verify that a set is stored in the first position
            Assert.AreEqual(retrievedSet.name, set.name);
            Assert.AreEqual(retrievedSet.model, set.model);
            Assert.AreEqual(retrievedSet.pieces, set.pieces);
            Assert.AreEqual(retrievedSet.msrp, set.msrp);
        }

        /*
         * Method TestWishListMgrAdd() to test whether an object WishList will add this 
         * set to the repository using the business layer
         */
        [TestMethod]
        public void TestWishListMgrAdd()
        {
            // Arrange - variables for testing the manager
            Default db = new Default();
            WishList set = new WishList();
            WishListMgr wishlistMgr = new WishListMgr();

            set.name = "Pirates of the Caribbean Black Pearl";
            set.model = "4184";
            set.pieces = 804;
            set.msrp = 99.99;

            // Act and Assert - verify the WishListMgr is capable of calling on service methods
            wishlistMgr.addSet(set, db);

            // Assert - verify that this set has been saved to the database
            WishList addedSet = (from d in db.Wishlists where d.wishlistID == set.wishlistID select d).Single();

            Assert.AreEqual(addedSet.name, set.name);
            Assert.AreEqual(addedSet.model, set.model);
            Assert.AreEqual(addedSet.pieces, set.pieces);
            Assert.AreEqual(addedSet.msrp, set.msrp);
        }

        /*
         * Method TestWishListMgrEdit() to test whether an object WishList can be edited 
         * from the repository using the Business layer
         */
        [TestMethod]
        public void TestWishListMgrEdit()
        {
            // Arrange - variables for testing the manager
            Default db = new Default();
            WishList set = new WishList();
            WishListMgr wishlistMgr = new WishListMgr();

            set.name = "Star Wars Death Star ";
            set.model = "10188";
            set.pieces = 3801;
            set.msrp = 399.99;

            db.Wishlists.Add(set);
            db.SaveChanges();

            WishList getSet = (from d in db.Wishlists where d.name == set.name select d).First();

            // Act and Assert - verify the WishListMgr is capable of calling on service methods
            getSet.msrp = 7.77;
            wishlistMgr.editSet(set, db);

            // Assert - verify that this set has been saved to the database
            WishList editedSet = (from d in db.Wishlists where d.wishlistID == getSet.wishlistID select d).Single();

            Assert.AreEqual(editedSet.name, getSet.name);
            Assert.AreEqual(editedSet.model, getSet.model);
            Assert.AreEqual(editedSet.pieces, getSet.pieces);
            Assert.AreEqual(editedSet.msrp, getSet.msrp);
        }

        /*
         * Method TestWishListMgrDelete() to test whether an object from the database
         * can be deleted from the repository using the Business layer
         */
        [TestMethod]
        public void TestWishListMgrDelete()
        {
            // Arrange - variables for testing the manager
            Default db = new Default();
            WishList set = new WishList();
            WishListMgr wishlistMgr = new WishListMgr();

            set.name = "Creator Pet Shop";
            set.model = "10218";
            set.pieces = 2032;
            set.msrp = 149.99;

            db.Wishlists.Add(set);
            db.SaveChanges();

            // Act and Assert - verify the WishListMgr is capable of calling on service methods
            WishList savedSet = (from d in db.Wishlists where d.wishlistID == set.wishlistID select d).Single();
            wishlistMgr.deleteSet(set, db);

            // Assert - verify that this set has been saved to the database
            WishList deletedSet = (from d in db.Wishlists where d.wishlistID == savedSet.wishlistID select d).FirstOrDefault();

            Assert.IsNull(deletedSet);
        }
    }
}
