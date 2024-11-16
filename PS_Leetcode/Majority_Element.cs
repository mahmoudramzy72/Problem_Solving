using System.Xml.Linq;

namespace PS_Leetcode
{
    internal class Majority_Element
    {
        // Given an array nums of size n, return the majority element.
        // The majority element is the element that appears more than ⌊n / 2⌋ times.
        // You may assume that the majority element always exists in the array.

        public static void Run()
        {
            int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
            int result = MajorityElement(nums);
            Console.WriteLine($"{result}");
        }

        public static int MajorityElement(int[] nums)
        {
            int candidate = nums[0];
            int count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }
                if (count == 0)
                {
                    candidate = nums[i];
                    count = 1;
                }
            }

            return candidate;
        }
    }
}
