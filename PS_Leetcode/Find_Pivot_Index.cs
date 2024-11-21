namespace PS_Leetcode
{
    internal class Find_Pivot_Index
    {
        // Given an array of integers nums, calculate the pivot index of this array.
        // The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal to the sum of all the numbers strictly to the index's right.
        public static void Run()
        {
            int[] nums = { 1, 7, 3, 6, 5, 6 };
            int result = PivotIndex(nums);
            Console.WriteLine("Pivot Index: " + result);
        }
        public static int PivotIndex(int[] nums)
        {
            int totalSum = 0;
            int leftSum = 0;

            foreach (int num in nums)
            {
                totalSum += num;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum == totalSum - leftSum - nums[i])
                {
                    return i;
                }
                leftSum += nums[i];
            }
            return -1;
        }
    }
}
