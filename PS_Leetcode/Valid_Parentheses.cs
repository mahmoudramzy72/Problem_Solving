namespace PS_Leetcode
{
    internal class Valid_Parentheses
    {
        // Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        public static void Run()
        {
            string s = "{](}[)";
            bool result = IsValid(s);
            Console.WriteLine(result);
        }

        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                } else {
                    if (stack.Count == 0) return false;
                    char top = stack.Pop();
                    if( (c == ')' && top != '(') || 
                        (c == '}' && top != '{') || 
                        (c == ']' && top != '[') )
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
