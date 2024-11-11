namespace PS_Leetcode
{
    internal class Move_Zeroes
    {
        // Given an integer array nums,
        // move all 0's to the end of it while maintaining the relative order of the non-zero elements.
        public static void Run()
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            MoveZeroes(nums);

            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }

        }

        public static void MoveZeroes(int[] nums)
        {
            int lastNonZeroIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[lastNonZeroIndex] = nums[i];
                    lastNonZeroIndex++;
                }
            }
            for (int i = lastNonZeroIndex; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
