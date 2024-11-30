namespace PS_Leetcode
{
    internal class How_Many_Numbers_Are_Smaller_Than_The_Current_Number
    {
        // Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it.
        // That is, for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].
        public static void Run()
        {
            int[] nums = { 8, 1, 2, 2, 3 };
            int[] result = SmallerNumbersThanCurrent(nums);
            Console.WriteLine("[" + string.Join(", ", result) + "]");
        }

        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] arr = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        counter++;
                    }
                }
                arr[i] = counter;
            }
            return arr;
        }
    }
}
