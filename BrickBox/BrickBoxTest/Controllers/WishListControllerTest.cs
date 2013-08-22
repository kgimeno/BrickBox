/*
 * BrickBoxTest.Controllers
 * WishListControllerTest tests the controller's Create methods
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
    public class WishListControllerTest
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
            WishListController wishListController = new WishListController();

            // Act - invoke method
            ViewResult result = wishListController.Create() as ViewResult;

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
            WishListController wishListController = new WishListController();
            WishList set = new WishList();

            set.name = "RandomWishList";
            set.model = "98789";
            set.pieces = 876;
            set.msrp = 789.99;

            // Act - create set using the controller's Create method
            ActionResult result = wishListController.Create(set) as ActionResult;

            // Assert - verify that the result is not null
            Assert.IsNotNull(result);
        }
    }
}
