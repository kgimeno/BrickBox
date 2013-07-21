using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrickBox.Models.Domain;
using BrickBox.Models.Services;

namespace BrickBoxTest.Services
{
    [TestClass]
    public class LegoSetImplTest
    {
        [TestMethod]
        public void LegoSetServiceTests()
        {
            // Arrange - variables for testing the services
            Factory factory = new Factory();
            LegoSet legoSet = new LegoSet();
            ILegoSetSvc legoSetSvc;

            // Act - use GetService method through the factory
            legoSetSvc = (ILegoSetSvc)factory.GetService("ILegoSetSvc");

            // Assert - verify that the interface methods work through the factory 
            //          return of the implementation 
            legoSetSvc.getSet(legoSet);
            legoSetSvc.addSet(legoSet);
            legoSetSvc.removeSet(legoSet);
        }
    }
}
