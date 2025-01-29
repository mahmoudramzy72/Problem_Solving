using System.Buffers.Text;

namespace PS_Leetcode
{
    internal class Relative_Ranks
    {
        // You are given an integer array score of size n, where score[i] is the score of the ith athlete in a competition.
        // All the scores are guaranteed to be unique.
        // The athletes are placed based on their scores, where the 1st place athlete has the highest score, 
        // the 2nd place athlete has the 2nd highest score,
        // and so on.The placement of each athlete determines their rank:
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
