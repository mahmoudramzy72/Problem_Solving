namespace PS_Leetcode
{
    internal class Final_Value_Of_Variable_After_Performing_Operations
    {
        public static void Run()
        {
            string[] operations = ["--X", "X++", "X++"];
            int result = FinalValueAfterOperations(operations);
            Console.WriteLine(result);
        }

        public static int FinalValueAfterOperations(string[] operations)
        {
            int X = 0;
            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i] == "++X" || operations[i] == "X++")
                {
                    X++;
                }
                else
                {
                    X--;
                }
            }
            return X;
        }
    }
}
