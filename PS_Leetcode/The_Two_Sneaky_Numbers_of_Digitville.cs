namespace PS_Leetcode
{
    internal class The_Two_Sneaky_Numbers_of_Digitville
    {
        //In the town of Digitville, there was a list of numbers called nums containing integers from 0 to n - 1.
        //Each number was supposed to appear exactly once in the list, however, two mischievous numbers sneaked in an additional time,
        //making the list longer than usual.
        public static void Run()
        {
            int[] nums = { 7, 1, 5, 4, 3, 4, 6, 0, 9, 5, 8, 2 };
            int[] result = GetSneakyNumbers(nums);
            Console.WriteLine($"Sneaky Numbers: [ {string.Join(" , ", result)} ]");
        }
        public static int[] GetSneakyNumbers(int[] nums)
        {
            Array.Sort(nums);
            int[] sneakyNumbers = new int[2];
            int index = 0;
            for (int i = 0; i < nums.Length - 1; i++) 
            {
                if(nums[i] == nums[i+1])
                {
                    sneakyNumbers[index++] = nums[i];
                    i++;
                }
            }
            return sneakyNumbers;
        }
    }
}
