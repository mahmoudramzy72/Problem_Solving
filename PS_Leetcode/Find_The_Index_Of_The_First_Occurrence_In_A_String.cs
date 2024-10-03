namespace PS_Leetcode
{
    internal class Find_The_Index_Of_The_First_Occurrence_In_A_String
    {
        // Given two strings needle and haystack, return the index of the first occurrence of needle in haystack,
        // or -1 if needle is not part of haystack.
        public static void Run()
        {
            string haystack = "sadbutsad";
            string needle = "sad";
            int index = StrStr(haystack, needle);
            PrintResult(haystack, needle, index);
        }

        public static int StrStr(string haystack, string needle)
        {
            int index = haystack.IndexOf(needle);
            return index != -1 ? index : -1;
        }

        public static void PrintResult(string haystack, string needle, int index)
        {
            if (index != -1)
            {
                Console.WriteLine($"\"{needle}\" occurs at index {index} in \"{haystack}\".");
            }
            else
            {
                Console.WriteLine($"\"{needle}\" did not occur in \"{haystack}\".");
            }
        }
    }
}
