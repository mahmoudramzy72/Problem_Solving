namespace PS_Leetcode
{
    internal class Sum_of_Squares_ofSpecial_Elements
    {
        // You are given a 1-indexed integer array nums of length n.
        // An element nums[i] of nums is called special if i divides n, i.e.n % i == 0.
        // Return the sum of the squares of all special elements of nums.
        public static void Run()
        {
            int[] nums = { 2, 7, 1, 19, 18, 3 };
            int result = SumOfSquares(nums);
            Console.WriteLine(result);
        }
        public static int SumOfSquares(int[] nums)
        {
            int sum = 0;
            int n = nums.Length;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += nums[i-1] * nums[i-1];
                }
            }
            return sum;
        }
    }
}
