namespace PS_Leetcode
{
    internal class Concatenation_Of_Array
    {
        // Given an integer array nums of length n, you want to create an array ans of length 2n
        // where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i < n (0-indexed).
        public static void Run()
        {
            int[] nums = { 1, 3, 2, 1 };
            int[] result = GetConcatenation(nums);
            Console.WriteLine($"[{string.Join(", ", result)}]");

        }

        public static int[] GetConcatenation(int[] nums)
        {
            int n = nums.Length;
            int[] newArray = new int[nums.Length * 2];

            for (int i = 0; i < nums.Length; i++) 
            {
                newArray[i] = nums[i];
                newArray[i+n] = nums[i];
            }
            return newArray;
        }
    }
}

