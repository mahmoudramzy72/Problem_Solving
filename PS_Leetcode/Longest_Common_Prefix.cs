using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
namespace PS_Leetcode
{
    internal class Longest_Common_Prefix
    {
        // Write a function to find the longest common prefix string amongst an array of strings.
        // If there is no common prefix, return an empty string "".

        public static void Run()
        {
            string[] strs = { "flower", "flow", "flight" };
            string prefix = LongestCommonPrefix(strs);
            Console.WriteLine("Longest Common Prefix: " + prefix);
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }
            string prefix = strs[0];
            
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == "")
                    {
                        return "";
                    }
                }
            }
            return prefix;
        }
    }
}
