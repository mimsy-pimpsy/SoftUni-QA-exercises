using NUnit.Framework;
using System.Collections.Generic;
using TestApp;

namespace TestProject.Tests
{
    public class AdjacentEqualTests
    {
        

        [Test]
        public void Test_Sum_InputIsNull_ShouldThrowArgumentException()
        {
            //Arrange
            List<int>? nullList = null;
            //Act and Assert 
            Assert.That(() => AdjacentEqual.Sum(nullList), Throws.ArgumentException);
        }
        [Test]
        public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
        {
            //Arrange
            List<int> emptyList = new List<int>();
            //Act
            string result = AdjacentEqual.Sum(emptyList);
            //Assert
            Assert.That(result , Is.EqualTo (string.Empty));
        }
        [Test]
        public void Test_SUm_NoAdjacentNumbers_ShouldReturnOriginalList()
        {
            //Arrange 
            List<int> list = new List<int>() {1, 2, 3, 4, 3, 5};

            string result = AdjacentEqual.Sum (list);

            Assert.That(result, Is.EqualTo("1 2 3 4 5 1"));
        }
        [Test]
        public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
        {
            //Arrange 
            List<int> list = new List<int>() { 1, 2, 2, 4, 3, 5, 6 };

            string result = AdjacentEqual.Sum(list);

            Assert.That(result, Is.EqualTo("1 8 3 5 "));
        }

        [Test]
        public void Test_Sum_AllNumbersAreAdjacentequal_ShouldReturnSummedNumber()
        {
            //Arrange 
            List<int> list = new List<int>() { 1, 1,2,4 };

            string result = AdjacentEqual.Sum(list);

            Assert.That(result, Is.EqualTo("8"));
        }

        [Test]
        public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedNumber()
        {
            //Arrange 
            List<int> list = new List<int>() { 1, 1, 3 , 4 };

            string result = AdjacentEqual.Sum(list);

            Assert.That(result, Is.EqualTo("2 3 4"));
        }

        [Test]
        public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedNumber()
        {
            //Arrange 
            List<int> list = new List<int>() { 1, 2, 3,4, 4 };

            string result = AdjacentEqual.Sum(list);

            Assert.That(result, Is.EqualTo("1 2 3 8"));
        }
    }
}