namespace PS_Leetcode
{
    internal class Truncate_Sentence
    {
        // A sentence is a list of words that are separated by a single space with no leading or trailing spaces.
        // Each of the words consists of only uppercase and lowercase English letters (no punctuation).
        public static void Run()
        {
            string s = "chopper is not a tanuki";
            int k = 5;
            string result = TruncateSentence(s, k);
            Console.WriteLine(result);
        }
        public static string TruncateSentence(string s, int k)
        {
            string[] arr = s.Split(" ");
            string[] newArr = new string[k];
            for (int i = 0; i < k; i++)
            {
                newArr[i] = arr[i];
            }
            string result = string.Join(" ", newArr); 
            return result;
        }
    }
}
