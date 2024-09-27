using Tyuiu.DanilovAS.Sprint3.Task1.V29.Lib;

namespace Tyuiu.DanilovAS.Sprint3.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMultiplySeries()
        {
            DataService ds = new DataService();
            double x = 0.25;
            int startValue = 1;
            int stopValue = 11;
            double wait = 13051.34;
            double res = ds.GetMultiplySeries(x, startValue, stopValue);
        }
    }
}