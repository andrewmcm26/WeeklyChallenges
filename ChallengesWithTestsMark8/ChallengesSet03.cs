using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            ////Without Linq
            //int count = 0;
            //foreach (bool b in vals)
            //{
            //    if (b == false)
            //        count++;
            //}
            //return count > 0 ;

            //With Linq
            return vals.Contains(false);
        }



        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            // //Without Linq
            //if (numbers == null)
            //return false;
            //int sum = 0;
            //foreach (var n in numbers)
            //{
            //    sum += n;
            //}
            //return sum % 2 != 0;

            //With Linq
            if (numbers == null)
                return false;
            return numbers.Sum() % 2 != 0;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //Without Linq
            bool upper = false;
            bool lower = false;
            bool digit = false;
            while (!(upper && lower && digit))
            {
                foreach (char ch in password)
                {
                    while (!upper) { upper = Char.IsUpper(ch); }
                    while (!lower) { lower = Char.IsLower(ch); }
                    while (!digit) { digit = Char.IsDigit(ch); }
                }
            }
            return upper && lower && digit;

            // With Linq
            //var upper = password.Any(item => Char.IsUpper(item));
            //var lower = password.Any(item => Char.IsLower(item));
            //var digit = password.Any(item => Char.IsDigit(item));
            //return upper && lower && digit;
        }

        public char GetFirstLetterOfString(string val)
        {
            //This actually gets the first LETTER of string
            //bool isLetter = false;
            //int i = 0;
            //    for(i = 0; isLetter == false; i++)
            //    {
            //        isLetter = Char.IsLetter(val[i]);
            //    }
            //return val[i-1];

            //This completes the exercise
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            var num = -1;
            while (num < 99)
            {
                num += 2;
                list.Add(num);
            }
            var arr = list.ToArray();
            return arr;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();

            }

        }

    }
}