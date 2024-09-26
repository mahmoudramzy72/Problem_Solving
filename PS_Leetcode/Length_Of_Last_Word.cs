namespace PS_Leetcode
{
    internal class Length_Of_Last_Word
    {
        public static void Run()
        {
            string s = "   Fly Me   To   The Moon  ";
            int length = LengthOfLastWord(s);
        }

        public static int LengthOfLastWord(string s)
        {
            string trimmedString = s.Trim();
            string[] Words = trimmedString.Split(" ");
            int length = Words[Words.Length - 1].Length;
            if (string.IsNullOrEmpty(trimmedString))  
            {
                Console.WriteLine("There Is No Word");
                return 0;
            }
            Console.WriteLine($"The Last Word Is \"{Words[Words.Length - 1]}\" With Length : {length}");
            return length;
        }
    }
}
