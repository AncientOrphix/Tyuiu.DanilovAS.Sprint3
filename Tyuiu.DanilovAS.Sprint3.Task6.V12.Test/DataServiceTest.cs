using Tyuiu.DanilovAS.Sprint3.Task6.V12.Lib;

namespace Tyuiu.DanilovAS.Sprint3.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumTheDivisors1()
        {
            DataService ds = new DataService();
            int wait = 221;
            int startValue = 9;
            int stopValue = 18;
            var res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(res, wait);
        }
    }
}