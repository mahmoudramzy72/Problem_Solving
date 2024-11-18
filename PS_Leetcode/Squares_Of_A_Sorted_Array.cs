namespace PS_Leetcode
{
    internal class Squares_Of_A_Sorted_Array
    {
        // Given an integer array nums sorted in non-decreasing order,
        // return an array of the squares of each number sorted in non-decreasing order.

        public static void Run()
        {
            int[] nums = { -7, -3, 2, 3, 11 };
            int[] result = SortedSquares(nums);
            Console.WriteLine(string.Join(", ", result));
        }

        public static int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] *= nums[i];
            }

            Array.Sort(nums);
            return nums;
        }
    }
}
