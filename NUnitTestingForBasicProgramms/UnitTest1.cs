using BasicProgrammsForTesting;

namespace NUnitTestingForBasicProgramms
{
    public class Tests
    {
        private BasicProgram program;

        [SetUp] 
        public void Setup()
        {
            program=new BasicProgram();
        }

        [Test]
        public void SumOfTwoNums()
        {
            //Arrange
            int a = 3;
            int b = 8;
            int expected = 11;
            //Act
            int actual = program.SumOfTwoNums(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OddReturnFalse()
        {
            int a = 5;
            bool expected = false;
            bool actual = program.OddOrEven(a);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void EvenReturnTrue()
        {
            int a = 8;
            bool expected = true;
            bool actual = program.OddOrEven(a);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void BubbbleSort()
        {
            List<int> a = new List<int>() { 4,3,2,1 };
            List<int> expected = new List<int>() { 1,2,3,4};
            List<int> actual = program.BubbleSortAscendingOrder(a);
            Assert.AreEqual(expected, actual);
        }
    }
    
}