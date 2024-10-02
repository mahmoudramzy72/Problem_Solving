namespace PS_Leetcode
{
    internal class Remove_Duplicates_From_Sorted_Array
    {
        public static void Run()
        {
            int[] nums = { 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int order = RemoveDuplicates(nums);
            Console.WriteLine($"The Order Is : {order}");
        }

        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int uniqueCount = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i-1])
                {
                    nums[uniqueCount] = nums[i];
                    uniqueCount++;
                }
            }
            return uniqueCount;
        }
    }
}
