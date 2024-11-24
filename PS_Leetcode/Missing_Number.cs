namespace PS_Leetcode
{
    internal class Missing_Number
    {
        // Given an array nums containing n distinct numbers in the range [0, n],
        // return the only number in the range that is missing from the array.
        public static void Run()
        {
            int[] nums = [ 9, 6, 4, 2, 3, 5, 7, 0, 1 ];
            int result = MissingNumber(nums);
            Console.WriteLine($"Missing Number Is : {result}");
        }

        public static int MissingNumber(int[] nums)
        {
            Array.Sort(nums);
            int i;
            for (i = 0; i < nums.Length; i++) 
            {
                if (nums[i] != i)
                    return i;
            }
            return i;
        }
    }
}
