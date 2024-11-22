namespace PS_Leetcode
{
    internal class Running_Sum_Of_1d_Array
    {
        public static void Run()
        {
            int[] nums = { 1, 2, 3, 4 };
            int[] result = RunningSum(nums);
            Console.WriteLine($"[{string.Join(", ", result)}]");
        }

        public static int[] RunningSum(int[] nums)
        {
            int[] result = new int[nums.Length];
            result[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = result[i - 1] + nums[i];
            }
            return result;
        }
    }
}
