﻿using System;
using GenerateUniqueNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestGenerateUniqueNumbers
{
    [TestClass]
    public class TestCreateNumber
    {
         /// <summary>
         /// Test that for given 'n' GetSecondNumber should not return 'n' or 'n+1'.
         /// </summary>
        [TestMethod]
        public void Test_GetSecondNumber()
        {
            CreateNumber cm = new CreateNumber(0);
            int test_result = cm.GetSecondNumber(1);
            Assert.AreNotEqual(2, test_result);
            Assert.AreNotEqual(1, test_result);
        }
          /// <summary>
          /// Test that for given four number make a complete number based on their 'place of number'.
          /// </summary>
        [TestMethod]
        public void Test_MakeNumber()
        {
            CreateNumber cm = new CreateNumber(0);
            int test_result = cm.MakeNumber(1,2,3,4);
            Assert.AreEqual(1234, test_result);
        }
    }
}
