using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            //WAY #1
            //c = Char.ToLowerInvariant(c); 
            //int count = 0;
            //string letters = "qwertyuiopasdfghjklzxcvbnm";
            //for(int i = 0; i<letters.Length; i++)
            //{
            //    if (letters[i] == c)
            //        count++; 
            //}
            //if(count>0)
            //    return true;
            //else
            //    return false;

            //WAY #2
            return Char.IsLetter(c);

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int count = vals.Length;
            return count % 2 == 0;


        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;

        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {

            if (numbers == null || numbers.Count() == 0)
                return 0;
            else
                return numbers.Min() + numbers.Max();




            //throw new NotImplementedException();

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
                return str2.Length;
            else
                return str1.Length;

        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
                return 0;
            foreach (var x in numbers)
            {
                sum += x;
            }
            return sum;

        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
                return 0;
            int sum = 0;
            foreach (var x in numbers)
            {
                if (x % 2 == 0)
                {
                    sum += x;
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                return false;
            int sum = 0;
            foreach (var x in numbers)
            {
                sum += x;
            }
            return sum % 2 != 0;

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number > 1)
                return number / 2;
            else
                return 0;

        }
    }
}