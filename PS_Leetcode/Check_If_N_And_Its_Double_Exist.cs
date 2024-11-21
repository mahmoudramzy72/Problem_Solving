namespace PS_Leetcode
{
    internal class Check_If_N_And_Its_Double_Exist
    {
        public static void Run()
        {
            int[] arr = { 10, 2, 5, 3 };
            bool result = CheckIfExist(arr);
            Console.WriteLine(result);
        }

        public static bool CheckIfExist(int[] arr)
        {
            for (int i = 0 ; i < arr.Length; i++)
            {
                for(int j = 0 ; j < arr.Length; j++)
                {
                    if(i != j && (arr[i] == 2 * arr[j] || arr[j] == 2 * arr[i]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
