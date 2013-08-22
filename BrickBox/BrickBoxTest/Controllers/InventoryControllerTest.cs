/*
 * BrickBoxTest.Controllers
 * InventoryControllerTest tests the controller's Create methods
 * @author Kelly J Gimeno
 * @version 1
 * @date 08/22/2013
 */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrickBox.Controllers;
using System.Web.Mvc;
using BrickBox.Models.Domain;

namespace BrickBoxTest.Controllers
{
    [TestClass]
    public class InventoryControllerTest
    {
        /*
         * Method TestViewCreate() checks whether or not the View is returned 
         * by checking for null values.  If result returns null, then the View
         * was not returned.
         */
        [TestMethod]
        public void TestViewCreate()
        {
            // Arrange - define variable
            InventoryController inventoryController = new InventoryController();

            // Act - invoke method
            ViewResult result = inventoryController.Create() as ViewResult;

            // Assert - verify if value is null or not
            Assert.IsNotNull(result);
        }

        /*
         * Method TestActionCreate() checks whether or not a Lego set can be saved
         * to the database.  Since the controller's create method returns a path 
         * location only if the set has been saved, result will return a value
         */
        [TestMethod]
        public void TestActionCreate()
        {
            // Arrange - define variables and set values
            InventoryController inventoryController = new InventoryController();
            Inventory set = new Inventory();

            set.name = "RandomInventory";
            set.model = "12321";
            set.pieces = 234;
            set.msrp = 123.99;

            // Act - create set using the controller's Create method
            ActionResult result = inventoryController.Create(set) as ActionResult;

            // Assert - verify that the result is not null
            Assert.IsNotNull(result);
        }
    }
}
