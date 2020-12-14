using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameProject;

namespace UnitTest1Project
{
    [TestClass]
    public class RRTest
    {
        //characterizing an article with in the class Roullete

        Game_logic Obj_test = new Game_logic();
        //first testing
        [TestMethod]
        public void positive()
        {
            //Real - we need to give some information to get a yield
            var actual = Obj_test.Bulleteloop(5);
            //Declare - we need to check the yield we get is right or not
            Assert.AreEqual(expected: 6, actual);
        }
        //Second testing
        [TestMethod]
        public void Negative()
        {
            //Act - we need to give some information to get a yield
            var actual = Obj_test.Bulleteloop(4);
            //State - we need to check the yield we get is right or not
            Assert.AreNotEqual(notExpected: 3, actual);
        }
    }
}
