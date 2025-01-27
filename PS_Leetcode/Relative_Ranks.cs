namespace PS_Leetcode
{
    internal class Relative_Ranks
    {
        public static void Run()
        {
            int[] score = { 10, 3, 8, 9, 4 };
            string[] ranks = FindRelativeRanks(score);
            Console.WriteLine(string.Join(", ", ranks));
        }

        public static string[] FindRelativeRanks(int[] score)
        {
            int[] score2 = (int[])score.Clone();
            score2 = score2.OrderByDescending(x => x).ToArray();

            Dictionary<int, string> dic = new Dictionary<int, string>();
            for (int i = 0; i < score2.Length; i++)
            {
                if (i == 0) 
                    dic[score2[i]] = "Gold Medal";
                else if 
                    (i == 1) dic[score2[i]] = "Silver Medal";
                else if 
                    (i == 2) dic[score2[i]] = "Bronze Medal";
                else 
                    dic[score2[i]] = (i + 1).ToString();
            }

            string[] ranks = new string[score.Length];
            for (int i = 0; i < score.Length; i++)
            {
                ranks[i] = dic[score[i]]; 
            }

            return ranks; 
        }
    }
}
