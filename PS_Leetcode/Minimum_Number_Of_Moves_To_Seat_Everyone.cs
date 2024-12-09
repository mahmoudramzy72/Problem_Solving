namespace PS_Leetcode
{
    internal class Minimum_Number_Of_Moves_To_Seat_Everyone
    {
        // There are n availabe seats and n students standing in a room. You are given an array seats of length n,
        // where seats[i] is the position of the ith seat. You are also given the array students of length n,
        // where students[j] is the position of the jth student.
        public static void Run()
        {
            int[] seats = { 2, 2, 6, 6 };
            int[] students = { 1, 3, 2, 6 };
            int moves = MinMovesToSeat(seats, students);
            Console.WriteLine(moves);
        }
        public static int MinMovesToSeat(int[] seats, int[] students)
        {
            Array.Sort(seats);
            Array.Sort(students);
            int moves = 0;
            for (int i = 0; i < seats.Length; i++)
            {
                moves += Math.Abs(seats[i] - students[i]);
            }
            return moves;
        }
    }
}

