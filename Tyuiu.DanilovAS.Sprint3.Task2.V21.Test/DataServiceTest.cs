using Tyuiu.DanilovAS.Sprint3.Task2.V21.Lib;

namespace Tyuiu.DanilovAS.Sprint3.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumSeries()
        {
            DataService ds = new DataService();
            double x = 1.5;
            int startValue = 1;
            int stopValue = 10;
            double wait = 0.298;
            double res = ds.GetSumSeries(x, startValue, stopValue);
            Assert.AreEqual(res, wait);

        }
    }
}