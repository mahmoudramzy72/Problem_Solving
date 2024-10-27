namespace PS_Leetcode
{
    internal class Single_Number
    {
        // Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

        public static void Run()
        {
            int[] nums = { 4, 1, 2, 1, 2 };
            int result = SingleNumber(nums);
            Console.WriteLine(result);
        }

        public static int SingleNumber(int[] nums)
        {
            int result = 0;
            foreach (var num in nums)
            {
               result ^= num;
            }
            return result;
        }
    }
}
