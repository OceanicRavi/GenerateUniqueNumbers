using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateUniqueNumbers
{
    class Program
    {
        public static List<int> result;
        /// <summary>
        /// Entry point to class.
        /// Ask for the count of unique numbers to be generated.
        /// Print the result on console.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter count of numbers to be generated: ");
            int arrayCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--Printing "+arrayCount+" Unique Numbers--");
            CreateNumber createNum = new CreateNumber(arrayCount);
            result = createNum.generateNumbers();
            Helper.PrintByLine(result);
            Console.ReadLine();
        }
    }
}
