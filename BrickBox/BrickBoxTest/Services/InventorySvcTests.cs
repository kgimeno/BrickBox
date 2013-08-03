/*
 * BrickBoxTest.Services
 * InventorySvcTests tests implementation methods
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
    public class InventorySvcTests
    {
        /*
         * Method TestInventorySvcGet() using the service layer to retrieve a Lego set
         * from the database
         */
        [TestMethod]
        public void TestInventorySvcGet()
        {
            // Arrange - variable for database
            Default db = new Default();
            Factory factory = new Factory();
            Inventory set = new Inventory();
            IInventorySvc inventorySvc;

            set.name = "The Lone Ranger Comanche Camp";
            set.model = "79107";
            set.pieces = 161;
            set.msrp = 19.99;

            db.Inventories.Add(set);
            db.SaveChanges();

            // Act - use GetService method through the factory to get set from inventory
            inventorySvc = (IInventorySvc)factory.GetService("IInventorySvc");
            inventorySvc.getSet(set, db);

            // Act - get the set in the first position
            Inventory retrievedSet = (from d in db.Inventories where d.name == set.name select d).First();

            // Assert - verify that a set is stored in the first position
            Assert.AreEqual(retrievedSet.name, set.name);
            Assert.AreEqual(retrievedSet.model, set.model);
            Assert.AreEqual(retrievedSet.pieces, set.pieces);
            Assert.AreEqual(retrievedSet.msrp, set.msrp);
        }

        /*
         * Method TestInventorySvcAdd() to test whether an object Inventory will add this 
         * set to the repository using the service layer
         */
        [TestMethod]
        public void TestInventorySvcAdd()
        {
            // Arrange - variables for testing the services
            Default db = new Default();
            Factory factory = new Factory();
            Inventory set = new Inventory();
            IInventorySvc inventorySvc;

            set.name = "Star Wars Millennium Falcon";
            set.model = "7965";
            set.pieces = 1254;
            set.msrp = 139.99;

            // Act - use GetService method through the factory to add set to inventory
            inventorySvc = (IInventorySvc)factory.GetService("IInventorySvc");
            inventorySvc.addSet(set, db);

            // Assert - verify that this set has been saved to the database
            Inventory addedSet = (from d in db.Inventories where d.inventoryID == set.inventoryID select d).Single();

            Assert.AreEqual(addedSet.name, set.name);
            Assert.AreEqual(addedSet.model, set.model);
            Assert.AreEqual(addedSet.pieces, set.pieces);
            Assert.AreEqual(addedSet.msrp, set.msrp);
        }

        /*
         * Method TestInventorySvcEdit() to test whether an object Inventory can be edited 
         * from the repository using the service layer
         */
        [TestMethod]
        public void TestInventorySvcEdit()
        {
            // Arrange - variables for testing the services
            Default db = new Default();
            Inventory set = new Inventory();

            Factory factory = new Factory();
            IInventorySvc inventorySvc;

            set.name = "SpongeBob Heroic Heroes of the Deep";
            set.model = "3815";
            set.pieces = 95;
            set.msrp = 19.99;

            db.Inventories.Add(set);
            db.SaveChanges();

            Inventory getSet = (from d in db.Inventories where d.name == set.name select d).First();

            // Act - use GetService method through the factory to edit set from inventory
            getSet.msrp = 7.77;
            inventorySvc = (IInventorySvc)factory.GetService("IInventorySvc");
            inventorySvc.editSet(set, db);

            // Assert - verify that this set has been saved to the database
            Inventory editedSet = (from d in db.Inventories where d.inventoryID == getSet.inventoryID select d).Single();

            Assert.AreEqual(editedSet.name, getSet.name);
            Assert.AreEqual(editedSet.model, getSet.model);
            Assert.AreEqual(editedSet.pieces, getSet.pieces);
            Assert.AreEqual(editedSet.msrp, getSet.msrp);
        }

        /*
         * Method TestInventorySvcDelete() to test whether an object from the database
         * can be deleted from the repository using the service layer
         */
        [TestMethod]
        public void TestInventorySvcDelete()
        {
            // Arrange - variables for testing the services
            Default db = new Default();
            Factory factory = new Factory();
            Inventory set = new Inventory();
            IInventorySvc inventorySvc;

            set.name = "Propeller Adventures";
            set.model = "7292";
            set.pieces = 241;
            set.msrp = 19.99;

            db.Inventories.Add(set);
            db.SaveChanges();

            // Act - use GetService method through the factory to add set to inventory
            Inventory savedSet = (from d in db.Inventories where d.inventoryID == set.inventoryID select d).Single();
            inventorySvc = (IInventorySvc)factory.GetService("IInventorySvc");
            inventorySvc.deleteSet(savedSet, db);

            // Assert - verify that this set has been deleted from the database
            Inventory deletedSet = (from d in db.Inventories where d.inventoryID == savedSet.inventoryID select d).FirstOrDefault();

            Assert.IsNull(deletedSet); 
        }
    }
}
