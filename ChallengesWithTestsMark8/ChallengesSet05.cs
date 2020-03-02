using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber++;
            while (startNumber % n != 0)
            {
                startNumber++;
            }
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return false;
            if (numbers.Length == 1)
                return true;
            var ans = true;
            if (numbers[0] > numbers[1])
                return false;
            while (ans)
            {
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] < numbers[i - 1])
                        ans = false;
                }
            }
            return ans;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
                return 0;
            var sum = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words) //still failing third test
        {
            if (words == null)
                return "";
            var trimWords = new List<string>(); 
            foreach (var word in words)
            {
                trimWords.Add(word.Trim());
            }
            var ans = String.Join(" ", trimWords.Where(x => !string.IsNullOrWhiteSpace(x)));
            if (ans.Length > 0)
                return ans + ".";
            else
                return "";

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
                return new double[] { };
            var list = new List<double>();
            for (int i = 3; i < elements.Count(); i += 4)
            {
                list.Add(elements[i]);
            }
            return list.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            var count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        if (nums[i] + nums[j] == targetNumber)
                            count++;
                    }
                }
            }
            return count != 0;
        }
    }
}