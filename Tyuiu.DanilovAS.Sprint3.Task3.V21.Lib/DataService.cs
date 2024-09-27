using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DanilovAS.Sprint3.Task3.V21.Lib
{
    public class DataService : ISprint3Task3V21
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            foreach(char i in value)
            {
                if (Char.IsDigit(i))
                {
                    value = value.Replace(i, item);
                }
            }
            return value;
        }
    }
}
