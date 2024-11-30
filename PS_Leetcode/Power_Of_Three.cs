namespace PS_Leetcode
{
    internal class Power_Of_Three
    {
        // Given an integer n, return true if it is a power of three. Otherwise, return false.
        // An integer n is a power of three, if there exists an integer x such that n == 3x.
        public static void Run()
        {
            int n = 27;
            bool result = IsPowerOfThree(n);
            Console.WriteLine(result);
        }
        public static bool IsPowerOfThree(int n)
        {
            if(n <= 0)
            {
                return false;
            }
            while (n % 3 == 0) 
            {
                n /= 3;
            }
            return n == 1;
        }
    }
}
