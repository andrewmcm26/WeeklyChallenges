using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    sum += numbers[i];
                else
                    sum -= numbers[i];
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int>();
            var a = str1.Length;
            var b = str2.Length;
            var c = str3.Length;
            var d = str4.Length;
            list.Add(a);
            list.Add(b);
            list.Add(c);
            list.Add(d);
            list.Sort();
            return list[0];
        }
        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int> { number1, number2, number3, number4 };
            list.Sort();
            return list[0];
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var list = new List<int> { sideLength1, sideLength2, sideLength3 };
            list.Sort();
            return list[0] + list[1] > list[2];
        }

        public bool IsStringANumber(string input)
        {
            return Double.TryParse(input, out double output);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int count = 0;
            foreach (var thing in objs)
            {
                if (thing == null)
                    count++;
            }
            return count > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;
            double count = 0;
            double sum = 0;
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                    count++;
                }
            }
            if (count == 0)
                return 0;
            return sum / count;
        }

        public int Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException();
            int prod = 1;
            int num = 1;
            while (num <= number)
            {
                prod *= num;
                num++;
            }
            return prod;
        }
    }
}
