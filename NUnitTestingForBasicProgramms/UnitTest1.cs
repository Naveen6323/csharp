using BasicProgrammsForTesting;
using OnlyForReview;

namespace NUnitTestingForBasicProgramms
{
    public class Tests
    {
        private BasicProgram program;
        private Calculator review;

        [SetUp]
        public void Setup()
        {
            program = new BasicProgram();
            review = new Calculator();
        }



        [Test]
        public void SumOfTwoNums()
        {
            //Arrange
            int a = 3;
            int b = 8;
            int expected = 11;
            //Act
            int actual = review.Add(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubstractionOfTwoNums()
        {
            int a = 3;
            int b = 8;
            int expected = -5;
            //Act
            int actual = review.Sub(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void DivideOfTwoNums()
        {
            int a = 6;
            int b = 3;
            int expected = 2;
            //Act
            int actual = review.divide(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void MultiplyOfTwoNums()
        {
            int a = 3;
            int b = 8;
            int expected = 24;
            //Act
            int actual = review.Mulyiply(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckPalindrome()
        {
            string a = "madam";
            bool expected = true;
            bool actual = review.IsValid(a);
            Assert.AreEqual(expected, actual);
        }
        //[Test]
        //public void OddReturnFalse()
        //{
        //    int a = 5;
        //    bool expected = false;
        //    bool actual = program.OddOrEven(a);
        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void EvenReturnTrue()
        //{
        //    int a = 8;
        //    bool expected = true;
        //    bool actual = program.OddOrEven(a);
        //    Assert.AreEqual(expected, actual);

        //}

        //[Test]
        //public void BubbbleSort()
        //{
        //    List<int> a = new List<int>() { 4, 3, 2, 1 };
        //    List<int> expected = new List<int>() { 1, 2, 3, 4 };
        //    List<int> actual = program.BubbleSortAscendingOrder(a);
        //    Assert.AreEqual(expected, actual);
        //}
    }

}