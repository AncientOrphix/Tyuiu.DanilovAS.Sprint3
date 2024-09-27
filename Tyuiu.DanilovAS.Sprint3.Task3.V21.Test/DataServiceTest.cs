using Tyuiu.DanilovAS.Sprint3.Task3.V21.Lib;

namespace Tyuiu.DanilovAS.Sprint3.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestReplaceNumOnChar()
        {
            DataService ds = new DataService();
            string wait = "fegeht gej eekge";
            string valueString = "f3g5ht g4j 34kg4";
            char e = 'e';
            var res = ds.ReplaceNumOnChar(valueString, e);
            Assert.AreEqual(res, wait);
        }
    }
}