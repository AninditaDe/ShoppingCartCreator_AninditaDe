using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartCreator;
using ShoppingCartCreator.Classes;
using System;
using System.Collections.Generic;

namespace UnitTestShoppingCart
{
    [TestClass]
    public class ShoppingCartTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int qtyButter = 1;
            int qtyMilk = 1;
            int qtyBread = 1;
            double expected = 2.95;

            var lstSelectedItems = new List<Tuple<string, int>>() {
              new Tuple<string, int>("Butter", qtyButter),
              new Tuple<string, int>("Milk", qtyMilk),
              new Tuple<string, int>("Bread", qtyBread),
            };

            Resolver res = new Resolver();
            double result = res.displayResult(lstSelectedItems);
            Assert.AreEqual(expected, result, "Success!");
        }
        [TestMethod]
        public void TestMethod2()
        {
            int qtyButter = 2;
            int qtyMilk = 0;
            int qtyBread = 2;
            double expected = 3.10;

            var lstSelectedItems = new List<Tuple<string, int>>() {
              new Tuple<string, int>("Butter", qtyButter),
              new Tuple<string, int>("Milk", qtyMilk),
              new Tuple<string, int>("Bread", qtyBread),
            };

            Resolver res = new Resolver();
            double result = res.displayResult(lstSelectedItems);
            Assert.AreEqual(expected, result, "Success!");
        }
        [TestMethod]
        public void TestMethod3()
        {
            int qtyButter = 0;
            int qtyMilk = 4;
            int qtyBread = 0;
            double expected = 3.45;

            var lstSelectedItems = new List<Tuple<string, int>>() {
              new Tuple<string, int>("Butter", qtyButter),
              new Tuple<string, int>("Milk", qtyMilk),
              new Tuple<string, int>("Bread", qtyBread),
            };

            Resolver res = new Resolver();
            double result = res.displayResult(lstSelectedItems);
            Assert.AreEqual(expected, result, "Success!");
        }
        [TestMethod]
        public void TestMethod4()
        {
            int qtyButter = 2;
            int qtyMilk = 8;
            int qtyBread = 1;
            double expected = 9.00;

            var lstSelectedItems = new List<Tuple<string, int>>() {
              new Tuple<string, int>("Butter", qtyButter),
              new Tuple<string, int>("Milk", qtyMilk),
              new Tuple<string, int>("Bread", qtyBread),
            };

            Resolver res = new Resolver();
            double result = res.displayResult(lstSelectedItems);
            Assert.AreEqual(expected, result, "Success!");
        }
    }
}
