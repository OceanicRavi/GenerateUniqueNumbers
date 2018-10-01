using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateUniqueNumbers
{
    interface ICreateNumber
    {
         int GetFirstNumber();
        int GetSecondNumber(int num);
        int MakeNumber(int num1, int num2, int num3, int num4);
    }
}
