namespace PS_Leetcode
{
    internal class Find_MinimumOperations_To_Make_All_Elements_Divisible_By_Three
    {
        // You are given an integer array nums. In one operation,
        // you can add or subtract 1 from any element of nums.
        // Return the minimum number of operations to make all elements of nums divisible by 3.
        public static void Run()
        {
            int[] nums = { 1, 2, 3, 4 };
            int result = MinimumOperations(nums);
            Console.WriteLine(result);
        }
        public static int MinimumOperations(int[] nums)
        {
            int count = 0;
            foreach (int num in nums) 
            {
                int remainder = num % 3;
                if (remainder != 0)
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
