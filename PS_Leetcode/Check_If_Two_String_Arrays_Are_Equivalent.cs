namespace PS_Leetcode
{
    internal class Check_If_Two_String_Arrays_Are_Equivalent
    {
        // Given two string arrays word1 and word2,
        // return true if the two arrays represent the same string, and false otherwise.
        public static void Run()
        {
            string[] word1 = { "abc", "d", "defg" };
            string[] word2 = { "abcddefg" };
            bool result = ArrayStringsAreEqual(word1, word2);
            Console.WriteLine($"{ result }");
        }
        public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            string fullWord1 = string.Join("", word1);
            string fullWord2 = string.Join("", word2);
            if (fullWord1 == fullWord2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
