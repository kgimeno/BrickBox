using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrickBox.Models.Domain;


namespace BrickBoxTest.Domain
{
    [TestClass]
    public class LegoSetTest
    {
        [TestMethod]
        public void AssertLegoSetObjectIsNotNull()
        {
            // Arrange
            LegoSet legoSet = new LegoSet();
            legoSet.setName = "Lego Batman Arkham Asylum Breakout";
            legoSet.setNumber = "10937";
            legoSet.pieceCount = 1619;
            legoSet.msrp = 215.85;

            // Act
 
            // Assert
            Assert.IsNotNull(legoSet);

        }
    }
}
