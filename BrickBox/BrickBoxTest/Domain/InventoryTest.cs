/*
 * BrickBoxTest.Domain
 * InventoryTest tests domain objects and whether they can be stored,
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
    public class InventoryTest
    {
        /*
         * Method TestInventoryForRecords() checks whether or not the table for Inventory
         * is empty or not by searching the first position in the table of the Inventory
         */
        [TestMethod]
        public void TestInventoryForRecords()
        {
            // Arrange - variable for database
            BrickBoxContext db = new BrickBoxContext();

            // Act - get the set in the first position
            Inventory savedSet = (from d in db.Inventories where d.inventoryID == 1 select d).Single();

            // Assert - verify that a set is stored in the first position
            Assert.AreEqual(savedSet.inventoryID, 1);
        }

        /*
         * Method TestAddSetToInventory() to test whether an object Inventory will add this 
         * set to the repository.
         */
        [TestMethod]
        public void TestAddSetToInventory()
        {
            // Arrange - add a set details to the database
            Inventory set = new Inventory();
            BrickBoxContext db = new BrickBoxContext();

            set.name = "City Fire Station";
            set.model = "7208";
            set.pieces = 662;
            set.msrp = 153.99;

            // Act - save changes to the database
            db.Inventories.Add(set);
            db.SaveChanges();

            // Assert - verify that this set has been saved to the database
            Inventory savedSet = (from d in db.Inventories where d.inventoryID == set.inventoryID select d).Single();

            Assert.AreEqual(savedSet.name, set.name);
            Assert.AreEqual(savedSet.model, set.model);
            Assert.AreEqual(savedSet.pieces, set.pieces);
            Assert.AreEqual(savedSet.msrp, set.msrp);
        }

        /*
         * Method TestEditInventory() to test whether an object Inventory can be edited 
         * from the repository
         */
        [TestMethod]
        public void TestEditInventory()
        {
            // Arrange - add set to the database to ensure that there is a set
            // to be edited from the database
            Inventory set = new Inventory();
            BrickBoxContext db = new BrickBoxContext();

            set.name = "Propeller Adventures";
            set.model = "7292";
            set.pieces = 241;
            set.msrp = 19.99;

            db.Inventories.Add(set);
            db.SaveChanges();

            // Act - save changes to the database
            set.msrp = 7.77;
            db.SaveChanges();

            // Assert - verify that this set has been saved to the database
            Inventory editedSet = (from d in db.Inventories where d.inventoryID == set.inventoryID select d).Single();

            Assert.AreEqual(editedSet.name, set.name);
            Assert.AreEqual(editedSet.model, set.model);
            Assert.AreEqual(editedSet.pieces, set.pieces);
            Assert.AreEqual(editedSet.msrp, set.msrp);
        }

        /*
         * Method TestDeleteSetFromInventory() to test whether an object from the database
         * can be deleted from the repository
         */
        [TestMethod]
        public void TestDeleteSetFromInventory()
        {
            // Arrange - add set to the database to ensure that there is a set
            // to be deleted from the database
            Inventory set = new Inventory();
            BrickBoxContext db = new BrickBoxContext();

            set.name = "Propeller Adventures";
            set.model = "7292";
            set.pieces = 241;
            set.msrp = 19.99;

            db.Inventories.Add(set);
            db.SaveChanges();

            // Act - search and remove set from database and save
            Inventory savedSet = (from d in db.Inventories where d.inventoryID == set.inventoryID select d).Single();
            db.Inventories.Remove(set);
            db.SaveChanges();

            // Assert
            Inventory removeSet = (from d in db.Inventories where d.inventoryID == savedSet.inventoryID select d).FirstOrDefault();
            Assert.IsNull(removeSet);
        }
    }
}
