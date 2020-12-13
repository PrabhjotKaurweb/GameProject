﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GameProject;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Game_Logic obj_GameLogic = new Game_Logic();
        [TestMethod]
        public void Fire()
        {
           obj_GameLogic.Hammer_Position = 1;
           obj_GameLogic.Bullet_Position = 1;

            int ExpectedResult = obj_GameLogic.shoot();
            Assert.AreEqual(1, ExpectedResult);
        }

        
        [TestMethod]
        public void NotFire()
        {
            obj_Logic.Hammer_Position = 1;
            obj_Logic.Bullet_Position = 5;

            int ExpectedResult = obj_GameLogic.shoot();
            Assert.AreEqual(0, ExpectedResult);
        }

    }
}
