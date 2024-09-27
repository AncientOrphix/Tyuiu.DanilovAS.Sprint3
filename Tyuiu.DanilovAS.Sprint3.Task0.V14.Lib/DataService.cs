using System.Runtime.Serialization.Formatters;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DanilovAS.Sprint3.Task0.V14.Lib
{
    public class DataService : ISprint3Task0V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            for(i = startValue; startValue < stopValue; startValue++)
            {
                sumSeries += Math.Pow((1/(Math.Pow(startValue,value))), - 1);
            }

            return Math.Round(sumSeries,3);
        }
    }
}
