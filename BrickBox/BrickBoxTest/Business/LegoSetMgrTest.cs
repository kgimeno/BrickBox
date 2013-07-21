using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrickBox.Models.Domain;
using BrickBox.Models.Business;

namespace BrickBoxTest.Business
{
    [TestClass]
    public class LegoSetMgrTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange - variables for testing the manager
            LegoSet legoSet = new LegoSet();
            LegoSetMgr legoSetMgr = new LegoSetMgr();

            // Act and Assert - verify the LegoSetMgr is capable of calling on service methods
            legoSetMgr.getSet(legoSet);
            legoSetMgr.addSet(legoSet);
            legoSetMgr.removeSet(legoSet);
        }
    }
}
