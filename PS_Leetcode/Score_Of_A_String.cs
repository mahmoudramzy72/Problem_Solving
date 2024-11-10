namespace PS_Leetcode
{
    internal class Score_Of_A_String
    {
        // You are given a string s.
        // The score of a string is defined as the sum of the absolute difference between the ASCII values of adjacent characters.
        // Return the score of s.
        public static void Run()
        {
            string s = "hello";
            int result = ScoreOfString(s);
            Console.WriteLine($"The Score Of \"{s}\" Is {result}");
        }
        public static int ScoreOfString(string s)
        {
            int score = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                score += Math.Abs((int)s[i]- (int)s[i+1]) ;
            }
            return score;
        }
    }
}
