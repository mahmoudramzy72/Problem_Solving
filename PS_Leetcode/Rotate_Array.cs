namespace PS_Leetcode
{
    internal class Rotate_Array
    {
        // Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.
        public static void Run()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            Rotate(nums, k);
        }

        public static void Rotate(int[] nums, int k)
        {
            for (int counter = 0; counter < k; counter++)
            {
                int lastElement = nums[nums.Length - 1];
                Array.Copy(nums, 0, nums, 1, nums.Length - 1);
                nums[0] = lastElement;
            }
            Console.WriteLine($"[{string.Join(", " , nums)}]");
        }
    }
}
