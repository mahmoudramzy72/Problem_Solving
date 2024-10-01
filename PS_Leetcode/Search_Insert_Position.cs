namespace PS_Leetcode
{
    internal class Search_Insert_Position
    {
        // Given a sorted array of distinct integers and a target value, return the index if the target is found.
        // If not, return the index where it would be if it were inserted in order.
        public static void Run()
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 7;
            int index = SearchInsert(nums, target);
            Console.WriteLine($"The target {target} should be inserted at index: {index}");
        }

        public static int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                {
                    return i;
                }
            }
            return nums.Length;
        }
    }
}
