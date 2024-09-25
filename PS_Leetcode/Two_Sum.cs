namespace PS_Leetcode
{
    internal class Two_Sum
    {
        public static void Run()
        {
            int target = 18;
            int[] nums = { 2, 7, 11, 15 };
            int[] answer = TwoSum(nums, target);

            if (answer[0] != -1 && answer[1] != -1)
            {
                Console.WriteLine($"Indices: [{answer[0]}, {answer[1]}]");
            }
            else
            {
                Console.WriteLine("No Matching Indices Found.");
            }
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] answer = { -1, -1 };
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        answer[0] = i;
                        answer[1] = j;
                        return answer;
                    }
                }
            }
            return answer;
        }
    }
}
