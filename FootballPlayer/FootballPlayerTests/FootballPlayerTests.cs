using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace FootballPlayer.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        private FootballPlayer _footballPlayer;
            
        [TestInitialize]
        public void SetUp()
        {
            _footballPlayer = new FootballPlayer(1, "Ronald", 100, 34);
        }
        [TestMethod]
        public void TestConstructor()
        {
            FootballPlayer FootballPlayer = new FootballPlayer(1, "Ronal-done", 24000, 90);
            Assert.AreEqual(1, FootballPlayer.Id);
            Assert.AreEqual("Ronal-done", FootballPlayer.Name);
            Assert.AreEqual(24000, FootballPlayer.Price);
            Assert.AreEqual(90, FootballPlayer.ShirtNumber);
        }
        [TestMethod]
        public void TestFootballPlayerName()
        {
            _footballPlayer.Name = "Ronald-done";
            Assert.AreEqual("Ronald-done", _footballPlayer.Name);
            Assert.ThrowsException<ArgumentNullException>(() => _footballPlayer.Name = null);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _footballPlayer.Name = "B");
        }
        [TestMethod]
        public void TestFootballPlayerPrice()
        {
            _footballPlayer.Price = 200;
            Assert.AreEqual(200, _footballPlayer.Price);
            //Assert.ThrowsException<ArgumentNullException>(() => _footballPlayer.Price = null);
        }
        [TestMethod]
        public void TestFootballPlayerShirtNumber()
        {
            _footballPlayer.ShirtNumber = 3;
            Assert.AreEqual(3, _footballPlayer.ShirtNumber);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _footballPlayer.ShirtNumber = 0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _footballPlayer.ShirtNumber = 20);
        }
    }
}