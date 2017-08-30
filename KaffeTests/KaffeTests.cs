using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe.Tests
{
    [TestClass()]
    public class KaffeTests
    {
        [TestMethod()]
        public void PrisTestKaffe()
        {
            //Arrange
            var Kaffe = new SortKaffe();

            //Act
            int pris = Kaffe.pris();

            //Assert
            Assert.AreEqual(20, pris);
        }

        [TestMethod()]
        public void StyrkeTestKaffe()
        {
            //Arrange
            var Kaffe = new SortKaffe();

            //Act
            string styrke = Kaffe.styrke();

            //Assert
            Assert.AreEqual("stærk", styrke);
        }
    }
}