namespace PS_Leetcode
{
    internal class Plus_One
    {
        // You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer.
        // The digits are ordered from most significant to least significant in left-to-right order.
        // The large integer does not contain any leading 0's.
        public static void Run()
        {
            int[] digits = { 9 };
            int[] result = PlusOne(digits);
            Console.WriteLine(string.Join(" , ", result));
        }

        public static int[] PlusOne(int[] digits)
        {
            string numberString = string.Join("", digits);
            int number = int.Parse(numberString);
            number++;

            int[] result = number.ToString().Select(c => c - '0').ToArray();

            return result;
        }
    }
}
