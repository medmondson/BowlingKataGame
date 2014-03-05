using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBowlingGameKata;

namespace UnitTestProject1
{
    [TestClass]
    public class BowlingGameTest
    {
        private Game g;

        [TestInitialize]
        public void SetUp()
        {
            g = new Game();
        }

        [TestMethod]
        public void TestGutterGame()
        {
            for (int i = 0; i<20; i++)
            {
                g.roll(0);
            }

            Assert.AreEqual(0, g.Score());
        }

        [TestMethod]
        public void TestAllOnes()
        {
            for (int i = 0; i < 20; i++)
                g.roll(1);

            Assert.AreEqual(20, g.Score());
        }
    }
}
