namespace PS_Leetcode
{
    // Given an integer array nums and an integer val, remove all occurrences of val in nums in-place.
    // The order of the elements may be changed.
    // Then return the number of elements in nums which are not equal to val.
    internal class Remove_Element
    {
        public static void Run()
        {
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;
            int index = RemoveElement(nums, val);
            Console.WriteLine($"The Index Is {index}");
        }

        public static int RemoveElement(int[] nums, int val)
        {
            if(nums.Length == 0) return 0;
            int K = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[K] = nums[i];
                    K++;
                }
            }
            return K;
        }
    }
}
