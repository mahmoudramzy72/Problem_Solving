using System;

namespace PS_Leetcode
{
    internal class Number_Of_Employees_Who_Met_The_Target
    {
        // There are n employees in a company, numbered from 0 to n - 1. Each employee i has worked for hours[i] hours in the company.
        // The company requires each employee to work for at least target hours.
        // You are given a 0-indexed array of non-negative integers hours of length n and a non-negative integer target.
        // Return the integer denoting the number of employees who worked at least target hours.
        public static void Run()
        {
            int[] hours = { 0, 1, 2, 3, 4 };
            int target = 2;
            int result = NumberOfEmployeesWhoMetTarget(hours, target);
            Console.WriteLine(result);
        }
        public static int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
        {
            int count = 0;
            for (int i = 0; i < hours.Length; i++)
            {
                if (hours[i] >= target)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
