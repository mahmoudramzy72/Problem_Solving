namespace PS_Leetcode
{
    // Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
    internal class Roman_To_Integer
    {
        public static void Run()
        {
            string s = "MCMXCIV";
            int number = RomanToInt(s);
            Console.WriteLine($"The Roman \"{s}\" Is {number}");
        }

        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romanMap = new Dictionary<char, int>()
            {
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 },
            };
            int total = 0; // Final Result
            int prevValue = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                int currentValue = romanMap[s[i]];
                if(currentValue < prevValue)
                {
                    total -= currentValue;
                }
                else
                {
                    total += currentValue;
                }
                prevValue = currentValue;
            }
            return total;
        }
    }
}
