namespace PS_Leetcode
{
    // There is a programming language with only four operations and one variable X:
    // ++X and X++ increments the value of the variable X by 1.     
    // --X and X-- decrements the value of the variable X by 1. 
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
