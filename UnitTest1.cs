using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using NUnitTesting;

namespace unitTesting
{
    public class Tests
    {
        private MethodsCls obj;
        [SetUp]
        public void SetUp()
        {
            obj = new MethodsCls();

        }



        [Test]
        public void SumOfNaturalNumbers()
        {
            //Arrange
            int n = 6;

            //Act
            int Result1 = obj.SumOfNaturalNumbers(n);

            //Assert
            Assert.AreEqual(21, Result1);
        }
        [Test]
        public void PositiveOrNegative()
        {
            int n = 10;
            bool res=obj.PositiveOrNegative(n);
            Assert.AreEqual(true, res);
        }

        [Test]

        public void Even()
        {
            int n = 3;
            bool res=obj.IsEven(n);
            Assert.AreEqual(false, res);
        }

        [Test]

        public void BubbleSort_BasicTest()
        {
            var sortedCollection = new MethodsCls();
            var testList = new List<int>() { 6,7,4,5,8};
            sortedCollection.BubbleSort_BasicTest(testList);
            var expectedList = new List<int>() { 6, 7, 4, 5, 8 };
            CollectionAssert.AreEqual(expectedList, testList);
        }




    }
}