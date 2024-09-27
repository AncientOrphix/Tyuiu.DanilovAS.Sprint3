using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DanilovAS.Sprint3.Task6.V12.Lib
{
    public class DataService : ISprint3Task6V12
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalSum = 0;
            for (int number = startValue; number <= stopValue; number++)
            {
                int sumOfDivisors = 0;

                
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        sumOfDivisors += i; 
                    }
                }

                totalSum += sumOfDivisors;
            }
            return totalSum;
        }
    }
}
