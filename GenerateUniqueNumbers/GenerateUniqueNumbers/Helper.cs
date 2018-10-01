using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateUniqueNumbers
{
    public static class Helper
    {
        public static int RandomNumberFromRange(int minValue,int maxValue)
        {
            Random rdm = new Random();
            return rdm.Next(minValue, maxValue);
        }

        public static void PrintByLine<T>(List<T> elements)
        {
            foreach(var item in elements)
            {
                Console.WriteLine(item);
            }
        }
    }
}
