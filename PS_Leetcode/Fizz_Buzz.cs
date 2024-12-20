﻿namespace PS_Leetcode
{
    internal class Fizz_Buzz
    {
        // Given an integer n, return a string array answer (1-indexed) where:
        // answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
        // answer[i] == "Fizz" if i is divisible by 3.
        // answer[i] == "Buzz" if i is divisible by 5.
        // answer[i] == i(as a string) if none of the above conditions are true.

        public static void Run()
        {
            int n = 15;
            var result = FizzBuzz(n);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static IList<string> FizzBuzz(int n)
        {
            List<string> result = new List<string>();

            for (int i = 1; i <= n; i++) 
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0) {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }

            return result;
        }
    }
}
