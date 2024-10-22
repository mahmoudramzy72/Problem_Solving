namespace PS_Leetcode
{
    internal class Add_Binary
    {
        // Given two binary strings a and b, return their sum as a binary string.
        public static void Run()
        {
            string a = "11111010";
            string b = "101000000";
            string sum = AddBinary(a, b);

            int num1 = Convert.ToInt32(a, 2); 
            int num2 = Convert.ToInt32(b, 2);
            int add = Convert.ToInt32(sum, 2);

            Console.WriteLine("Decimal Addation");
            Console.WriteLine($"{num1} + {num2} = {add}\n");

            Console.WriteLine("Binary Addation");
            Console.WriteLine($"{a} + {b} = {sum}");
        }

        /* public static string AddBinary(string a, string b)
        {
            int number1 = Convert.ToInt32(a, 2);
            int number2 = Convert.ToInt32(b, 2);
            int sum = number1 + number2;
            string result = Convert.ToString(sum, 2);
            return result;
        }
        */
        public static string AddBinary(string a, string b)
        {
            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;
            var result = new System.Text.StringBuilder();

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int sum = carry;

                if (i >= 0)
                {
                    sum += a[i] - '0';
                    i--;
                }
                if (j >= 0)
                {
                    sum += b[j] - '0';
                    j--;
                }

                if (sum == 0)
                {
                    result.Insert(0, '0');
                    carry = 0;
                }
                else if (sum == 1)
                {
                    result.Insert(0, '1');
                    carry = 0;
                }
                else if (sum == 2)
                {
                    result.Insert(0, '0');
                    carry = 1;
                }
                else if (sum == 3)
                {
                    result.Insert(0, '1');
                    carry = 1;
                }

            }

            return result.ToString();
        }
    }
}
