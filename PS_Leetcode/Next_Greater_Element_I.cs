using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PS_Leetcode
{
    internal class Next_Greater_Element_I
    {
        // The next greater element of some element x in an array is the first greater element that is to the right of x in the same array.
        // You are given two distinct 0-indexed integer arrays nums1 and nums2, where nums1 is a subset of nums2.
        public static void Run()
        {
            int[] nums1 = { 4, 1, 2 };
            int[] nums2 = { 1, 3, 4, 2 };
            int[] result = NextGreaterElement(nums1, nums2);
            Console.WriteLine($"[{string.Join(", ", result)}]");
        }

        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            int[] result = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                int index = -1;
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums2[j] == nums1[i])
                    {
                        index = j;
                        break;
                    }
                }

                result[i] = -1; 
                for (int j = index; j < nums2.Length; j++)
                {
                    if (nums2[j] > nums1[i])
                    {
                        result[i] = nums2[j++];
                        break;
                    }
                }
            }
            return result;
        }
    }
}