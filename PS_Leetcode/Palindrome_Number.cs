namespace PS_Leetcode
{
    // Given an integer x, return true if x is a palindrome, and false otherwise.
    internal class Palindrome_Number
    {
        public static void Run()
        {
            int x = -121;
            bool result = IsPalindrome(x);
            Console.WriteLine(result ? $"{x} Is A Palindrome." : $"{x} Is Not A Palindrome.");
        }

        public static bool IsPalindrome(int x)
        {
            string str = x.ToString();
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            return str == reversedString;

            // return x.ToString() == new string(x.ToString().Reverse().ToArray());
        }
    }
}
