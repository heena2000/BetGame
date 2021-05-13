using BetGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstTest()
        {
            Player player = GameFactory.GetPlayer(11);
            Assert.AreEqual(player == null, true);
        }
    }
}
