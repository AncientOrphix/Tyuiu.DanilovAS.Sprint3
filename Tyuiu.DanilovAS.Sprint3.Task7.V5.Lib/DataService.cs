using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DanilovAS.Sprint3.Task7.V5.Lib
{
    public class DataService : ISprint3Task7V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];

            double y;
            int count = 0;
            //y =(2*Math.Sin(i))/(3*i+1.2) +Math.Cos(i) - 7*i*2;
            //y = (2*(Math.Sin(i)))/(3*i+1.2) + Math.Cos(i) - 7* i *2;
            for (int i = startValue; i <= stopValue; i++)
            {
                y = (2 * Math.Sin(i)) / (3 * i + 1.2) + Math.Cos(i) - 7 * i * 2;
                valueArray[count] = y;
            }
            return valueArray;
        }
    }
}
