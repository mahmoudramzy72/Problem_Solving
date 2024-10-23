namespace PS_Leetcode
{
    internal class Number_Of_1_Bits
    {
        // Given a positive integer n, write a function that returns the number of set bits in its binary representation(also known as the Hamming weight).
        public static void Run()
        {
            int n = 2147483645;
            int result = HammingWeight(n);

            string binary = Convert.ToString(n, 2);
            
            Console.WriteLine($"The Binary Of \"{n}\" Is {binary}\n");
            Console.WriteLine($"The Number Of 1 Bits In \"{binary}\" Is {result}");
        }

        public static int HammingWeight(int n)
        {
            string binary = Convert.ToString(n, 2);
            int count = 0;
            foreach (var bit in binary)
            {
                if (bit == '1')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
