namespace PS_Leetcode
{
    internal class First_Unique_Character_In_A_String
    {
        public static void Run()
        {
            string s = "loveleetcode";
            int result = FirstUniqChar(s);
            Console.WriteLine(result);
        }

        public static int FirstUniqChar(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s.IndexOf(s[i]) == s.LastIndexOf(s[i]))
                {
                    return i; 
                }
            }
            return -1;
        }
    }
}
