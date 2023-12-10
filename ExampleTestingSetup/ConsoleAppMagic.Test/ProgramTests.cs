using NUnit.Framework;
namespace ConsoleAppMagic.Test
{
    public class ProgramTests
    {
       
        [Test]
        public void Test_WhenSumIsGivenTwoParams_ShoulReturnCurrentSum()
        {
            var sum = Program.Sum(10, 20);
            Assert.AreEqual(30, sum);
        }
    }
}