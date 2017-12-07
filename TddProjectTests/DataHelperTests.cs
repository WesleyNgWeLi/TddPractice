using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddPractice;

namespace TddProjectTests
{
    [TestClass]
    public class DataHelperTests
    {
        DataModel DM;
        DataHelper DH;

        [TestInitialize]
        public void SetUp()
        {
            DM = new DataModel();
            DH = new DataHelper();
        }

        [TestMethod]
        public void listOfIntIsPopulated()
        {
            Assert.IsNotNull(DM.listOfInt);
        }

        [TestMethod]
        public void GetEvenNumberReturnsOnlyEvenNumbers()
        {
            var result = DH.GetEvenNumber(new List<int>() { 1, 2, 4 });
            var expectedList = new List<int>() { 2, 4 };
            CollectionAssert.AreEqual(result, expectedList);
        }

        [TestMethod]
        public void GetEvenNumberReturnsOnlyEvenNumbersNegative()
        {
            var result = DH.GetEvenNumber(new List<int>() { 1, 2, 3, 4 });
            var expectedList = new List<int>() { 1, 2, 4 };
            CollectionAssert.AreNotEqual(result, expectedList);
        }

        [TestMethod]
        public void listOfStringIsPopulated()
        {
            Assert.IsNotNull(DM.listOfString);
        }

        [TestMethod]
        public void GetWordReturnsString()
        {
            var result = DH.GetWord(new List<string>() { "a", "b", "c" }, "a");
            Assert.IsTrue("a" == result);
        }

        [TestMethod]
        public void GetWordReturnsInputStringIfExists()
        {
            var result = DH.GetWord(new List<string>() { "a", "b", "c" }, "a");
            Assert.IsTrue("a" == result);
        }

        [TestMethod]
        public void GetWordReturnsInputStringIfExistsNegative()
        {
            var result = DH.GetWord(new List<string>() { "a", "b", "c" }, "d");
            Assert.IsNotNull("b" != result);
        }

        [TestMethod]
        public void SortListReturnsListOfStrings()
        {
            var result = DH.SortList(new List<string>() { "a", "b", "c" });
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void SortListReturnsSortedListOfStrings()
        {
            var result = DH.SortList(new List<string>() { "c", "a", "a" });
            var expectedResult =new List<string>() { "a", "a", "c" };

            Assert.IsTrue(expectedResult.SequenceEqual(result));
        }




    }
}
