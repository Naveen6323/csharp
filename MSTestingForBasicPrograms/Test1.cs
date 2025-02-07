using System.Data;
using System.Security.Cryptography.X509Certificates;
using BasicProgrammsForTesting;

namespace MSTestingForBasicPrograms
{
    [TestClass]
    public sealed class Test1
    {
        BasicProgram program = new BasicProgram();
        [DataRow(6,3,3)]
        [DataRow(10,4,6)]
        [DataRow(10,5,5)]
        [TestMethod]
        public void SumOfNums(int returnData,int a,int b)
        {
            var actual = program.SumOfTwoNums(a, b);
            Assert.AreEqual(returnData, actual);

        }
    }
}
