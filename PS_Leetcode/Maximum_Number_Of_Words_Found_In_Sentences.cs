namespace C__Leetcode
{
    internal class Maximum_Number_Of_Words_Found_In_Sentences
    {
        // A sentence is a list of words that are separated by a single space with no leading or trailing spaces.
        // You are given an array of strings sentences, where each sentences[i] represents a single sentence.
        // Return the maximum number of words that appear in a single sentence.
        public static void Run()
        {
            string[] sentences = { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };
            int result = MostWordsFound(sentences);
            Console.WriteLine(result);
        }
        public static int MostWordsFound(string[] sentences)
        {
            int maxWords = 0;
            for (int i = 0; i < sentences.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < sentences[i].Length; j++)
                {
                    if (sentences[i][j] == ' ')
                    {
                        counter++;
                    }
                }
                counter += 1;
                if (counter > maxWords)
                {
                    maxWords = counter;
                }
            }
            return maxWords;
        }
    }
}
