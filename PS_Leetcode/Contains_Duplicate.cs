namespace PS_Leetcode
{
    internal class Contains_Duplicate
    {
        //Given an integer array nums, return true if any value appears at least twice in the array,
        //and return false if every element is distinct.
        public static void Run()
        {
            int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            bool result = ContainsDuplicate(nums);
            Console.WriteLine($"{result}");
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
