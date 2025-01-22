namespace PS_Leetcode
{
    internal class Contains_Duplicate_II
    {
        // Given an integer array nums and an integer k,
        // return true if there are two distinct indices i and j in the array 
        // such that nums[i] == nums[j] and abs(i - j) <= k.
        public static void Run()
        {
            int[] nums = { 1, 2, 3, 1, 2, 3 };
            int k = 2;
            bool result = ContainsNearbyDuplicate(nums, k);
            Console.WriteLine(result);
        }

        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && Math.Abs(i - j) <= k)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
