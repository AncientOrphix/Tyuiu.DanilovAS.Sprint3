using Tyuiu.DanilovAS.Sprint3.Task0.V14.Lib;

namespace Tyuiu.DanilovAS.Sprint3.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMultiplySeries()
        {
            DataService ds = new DataService();
            int n = 2;
            int startvalue = 1;
            int stopvalue = 5;

            double res = ds.GetMultiplySeries(n, startvalue, stopvalue);
            double wait = 30;
            Assert.AreEqual(wait, res);
        }
    }
}