using System;

namespace PS_Leetcode
{
    internal class Create_Target_Array_In_The_Given_Order
    {
        // Given two arrays of integers nums and index. Your task is to create target array under the following rules:
        // Initially target array is empty.
        // From left to right read nums[i] and index[i], insert at index index[i] the value nums[i] in target array.
        // Repeat the previous step until there are no elements to read in nums and index.
        public static void Run()
        {
            int[] nums = { 0, 1, 2, 3, 4 };
            int[] index = { 0, 1, 2, 2, 1 };
            int[] result = CreateTargetArray(nums,index);
            Console.WriteLine($"[{string.Join(",", result)}]");
        }
        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            int[] target = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                target[i] = -1;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (target[index[i]] == -1)
                {
                    target[index[i]] = nums[i];
                }
                else
                {
                    for (int j = target.Length - 1; j > index[i]; j--)
                    {
                        target[j] = target[j - 1];
                    }
                    target[index[i]] = nums[i];
                }
            }
            return target;
        }
    }
}
