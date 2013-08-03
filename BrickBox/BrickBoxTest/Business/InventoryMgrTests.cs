/*
 * BrickBoxTest.Business
 * InventoryMgrTests to test the business layer methods
 * @author Kelly J Gimeno
 * @version 1
 * @date 07/26/2013
 */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrickBox.Models.Domain;
using BrickBox.Models.Business;
using System.Linq;

namespace BrickBoxTest.Business
{
    [TestClass]
    public class InventoryMgrTests
    {
        /*
         * Method TestInventoryMgrGet() using the Business layer to retrieve a Lego set
         * from the database
         */
        [TestMethod]
        public void TestInventoryMgrGet()
        {
            // Arrange - variable for database
            Default db = new Default();
            Inventory set = new Inventory();
            InventoryMgr inventoryMgr = new InventoryMgr();

            set.name = "The Hobbit Attack of the Wargs";
            set.model = "79002";
            set.pieces = 400;
            set.msrp = 49.99;

            db.Inventories.Add(set);
            db.SaveChanges();

            // Act - use GetService method through the Manager class get set from inventory
            inventoryMgr.getSet(set, db);

            // Act - get the set in the first position
            Inventory retrievedSet = (from d in db.Inventories where d.name == set.name select d).First();

            // Assert - verify that a set is stored in the first position
            Assert.AreEqual(retrievedSet.name, set.name);
            Assert.AreEqual(retrievedSet.model, set.model);
            Assert.AreEqual(retrievedSet.pieces, set.pieces);
            Assert.AreEqual(retrievedSet.msrp, set.msrp);
        }

        /*
         * Method TestInventoryMgrAdd() to test whether an object Inventory will add this 
         * set to the repository using the business layer
         */
        [TestMethod]
        public void TestInventoryMgrAdd()
        {
            // Arrange - variables for testing the manager
            Default db = new Default();
            Inventory set = new Inventory();
            InventoryMgr inventoryMgr = new InventoryMgr();

            set.name = "Super Heroes The Batcave";
            set.model = "6860";
            set.pieces = 689;
            set.msrp = 69.99;

            // Act and Assert - verify the InventoryMgr is capable of calling on service methods
            inventoryMgr.addSet(set, db);

            // Assert - verify that this set has been saved to the database
            Inventory addedSet = (from d in db.Inventories where d.inventoryID == set.inventoryID select d).Single();

            Assert.AreEqual(addedSet.name, set.name);
            Assert.AreEqual(addedSet.model, set.model);
            Assert.AreEqual(addedSet.pieces, set.pieces);
            Assert.AreEqual(addedSet.msrp, set.msrp);
        }

        /*
         * Method TestInventoryMgrEdit() to test whether an object Inventory can be edited 
         * from the repository using the Business layer
         */
        [TestMethod]
        public void TestInventoryMgrEdit()
        {
            // Arrange - variables for testing the manager
            Default db = new Default();
            Inventory set = new Inventory();
            InventoryMgr inventoryMgr = new InventoryMgr();

            set.name = "City Flatbed Truck";
            set.model = "60017";
            set.pieces = 212;
            set.msrp = 19.99;

            db.Inventories.Add(set);
            db.SaveChanges();

            Inventory getSet = (from d in db.Inventories where d.name == set.name select d).First();

            // Act and Assert - verify the InventoryMgr is capable of calling on service methods
            getSet.msrp = 7.77;
            inventoryMgr.editSet(set, db);

            // Assert - verify that this set has been saved to the database
            Inventory editedSet = (from d in db.Inventories where d.inventoryID == getSet.inventoryID select d).Single();

            Assert.AreEqual(editedSet.name, getSet.name);
            Assert.AreEqual(editedSet.model, getSet.model);
            Assert.AreEqual(editedSet.pieces, getSet.pieces);
            Assert.AreEqual(editedSet.msrp, getSet.msrp);
        }

        /*
         * Method TestInventoryMgrDelete() to test whether an object from the database
         * can be deleted from the repository using the Business layer
         */
        [TestMethod]
        public void TestInventoryMgrDelete()
        {
            // Arrange - variables for testing the manager
            Default db = new Default();
            Inventory set = new Inventory();
            InventoryMgr inventoryMgr = new InventoryMgr();

            set.name = "Star Wars Rancor Pit";
            set.model = "75005";
            set.pieces = 380;
            set.msrp = 59.99;

            db.Inventories.Add(set);
            db.SaveChanges();

            // Act and Assert - verify the InventoryMgr is capable of calling on service methods
            Inventory savedSet = (from d in db.Inventories where d.inventoryID == set.inventoryID select d).Single();
            inventoryMgr.deleteSet(set, db);

            // Assert - verify that this set has been saved to the database
            Inventory deletedSet = (from d in db.Inventories where d.inventoryID == savedSet.inventoryID select d).FirstOrDefault();

            Assert.IsNull(deletedSet); 
        }
    }
}
