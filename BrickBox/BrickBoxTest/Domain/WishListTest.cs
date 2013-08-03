/*
 * BrickBoxTest.Domain
 * WishListTest tests domain objects and whether they can be stored,
 * edited, deleted, and saved to the database
 * @author Kelly J Gimeno
 * @version 1
 * @date 07/25/2013
 */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrickBox.Models.Domain;
using System.Linq;

namespace BrickBoxTest.Domain
{
    [TestClass]
    public class WishListTest
    {
        /*
         * Method TestWishListForRecords() checks whether or not the table for WishList
         * is empty or not by searching the first position in the table of the WishList
         */
        [TestMethod]
        public void TestWishListForRecords()
        {
            // Arrange - variable for database
            Default db = new Default();

            // Act - get the set in the first position
            WishList savedSet = (from d in db.Wishlists where d.wishlistID == 1 select d).Single();

            // Assert - verify that a set is stored in the first position
            Assert.AreEqual(savedSet.wishlistID, 1);
        }

        /*
         * Method TestAddSetToWishList() to test whether an object WishList will add this 
         * set to the repository.
         */
        [TestMethod]
        public void TestAddSetToWishList()
        {
            // Arrange - add a set details to the database
            WishList set = new WishList();
            Default db = new Default();

            set.name = "Seaside House";
            set.model = "7346";
            set.pieces = 415;
            set.msrp = 49.99;

            db.Wishlists.Add(set);

            // Act - save changes to the database
            db.SaveChanges();

            // Assert - verify that this set has been saved to the database
            WishList savedSet = (from d in db.Wishlists where d.wishlistID == set.wishlistID select d).Single();

            Assert.AreEqual(savedSet.name, set.name);
            Assert.AreEqual(savedSet.model, set.model);
            Assert.AreEqual(savedSet.pieces, set.pieces);
            Assert.AreEqual(savedSet.msrp, set.msrp);
        }

        /*
         * Method TestEditWishList() to test whether an object WishList can be edited 
         * from the repository
         */
        [TestMethod]
        public void TestEditWishList()
        {
            /// Arrange - add set to the database to ensure that there is a set
            // to be edited from the database
            WishList set = new WishList();
            Default db = new Default();

            set.name = "Apple Tree House";
            set.model = "5891";
            set.pieces = 539;
            set.msrp = 19.99;

            db.Wishlists.Add(set);
            db.SaveChanges();

            // Act - save changes to the database
            set.msrp = 7.77;
            db.SaveChanges();

            // Assert - verify that this set has been saved to the database
            WishList editedSet = (from d in db.Wishlists where d.wishlistID == set.wishlistID select d).Single();

            Assert.AreEqual(editedSet.name, set.name);
            Assert.AreEqual(editedSet.model, set.model);
            Assert.AreEqual(editedSet.pieces, set.pieces);
            Assert.AreEqual(editedSet.msrp, set.msrp);
        }

        /*
         * Method TestDeleteSetFromWishList() to test whether an object from the database
         * can be deleted from the repository
         */
        [TestMethod]
        public void TestDeleteSetFromWishList()
        {
            // Arrange - add set to the database to ensure that there is a set
            // to be deleted from the database
            WishList set = new WishList();
            Default db = new Default();

            set.name = "Propeller Adventures";
            set.model = "7292";
            set.pieces = 241;
            set.msrp = 19.99;

            db.Wishlists.Add(set);
            db.SaveChanges();

            // Act - search and remove set from database and save
            WishList savedSet = (from d in db.Wishlists where d.wishlistID == set.wishlistID select d).Single();
            db.Wishlists.Remove(set);
            db.SaveChanges();

            // Assert
            WishList removeSet = (from d in db.Wishlists where d.wishlistID == savedSet.wishlistID select d).FirstOrDefault();
            Assert.IsNull(removeSet);
        }
    }
}
