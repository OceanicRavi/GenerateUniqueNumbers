using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateUniqueNumbers
{
    public class CreateNumber : ICreateNumber
    {
        List<int> randomNumber = new List<int>();
        int[] fourDigitNumber = new int[4];
        int ArrayLength;
        public CreateNumber(int _length)
        {
            ArrayLength = _length;
        }
        public List<int> generateNumbers()
        {
            int createdNumber;
            while (randomNumber.Count < ArrayLength)
            {
                do
                {
                    fourDigitNumber[0] = GetFirstNumber();
                    fourDigitNumber[1] = GetSecondNumber(fourDigitNumber[0]);
                    fourDigitNumber[2] = GetSecondNumber(fourDigitNumber[1]);
                    fourDigitNumber[3] = GetSecondNumber(fourDigitNumber[2]);
                    createdNumber = MakeNumber(fourDigitNumber[0], fourDigitNumber[1], fourDigitNumber[2], fourDigitNumber[3]);
                } while (randomNumber.Contains(createdNumber));
                randomNumber.Add(createdNumber);
           
            }
           
            return randomNumber;
        }

        public int GetFirstNumber()
        {
            return Helper.RandomNumberFromRange(1,10);
        }

        public int GetSecondNumber(int num)
        {
            int foo;
            do
            {
                foo = Helper.RandomNumberFromRange(0, 10);
            } while (foo == num || foo == num + 1);
            return foo;
        }

        public int MakeNumber(int num1, int num2, int num3, int num4)
        {
            return num1 * 1000 + num2 * 100 + num3 * 10 + num4;
        }
    }
}
