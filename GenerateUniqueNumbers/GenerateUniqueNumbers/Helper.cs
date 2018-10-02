using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateUniqueNumbers
{
    /*
     * Helper class to provide basic functionalities.
     * Use this class to perfom repeated tasks.
     */
    public static class Helper
    {
        /// <summary>
        /// Function to get random number from the range of minValue and maxValue-1.
        /// </summary>
        public static int RandomNumberFromRange(int minValue,int maxValue)
        {
            Random rdm = new Random();
            return rdm.Next(minValue, maxValue);
        }
        /// <summary>
        /// Function to print each item of elements on new line.
        /// </summary>
        public static void PrintByLine<T>(List<T> elements)
        {
            foreach(var item in elements)
            {
                Console.WriteLine(item);
            }
        }
    }
}
