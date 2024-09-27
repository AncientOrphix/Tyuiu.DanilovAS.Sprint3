using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DanilovAS.Sprint3.Task5.V3.Lib
{
    public class DataService : ISprint3Task5V3
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double result = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for(int j = startValue2; j <= stopValue2; j++)
                {
                    result += (Math.Sin(j) + x )/ (x);
                }
            }
            return Math.Round(result,3);
        }
    }
}
