using Tyuiu.DanilovAS.Sprint3.Task5.V3.Lib;

namespace Tyuiu.DanilovAS.Sprint3.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 11;
            double wait = 33.247;
            var res = ds.GetSumSumSeries(x,startValue1,startValue2,stopValue1,stopValue2 );
            Assert.AreEqual(res, wait);
        }
    }
}