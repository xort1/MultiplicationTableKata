using System;

namespace Solution
{
    class Solution
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine(MultiplicationTable(size));
        }
        public static int[,] MultiplicationTable(int size)
        {
            int[,] arr = new int[size, size];

            for (int i = size - 1; i >= 0; i--)
                arr[0, i] = i + 1;

            for (int i = size - 1; i >= 0; i--)
                arr[i, 0] = i + 1;

            for (int i = 1; i < size; i++)
                for (int j = 1; j < size; j++)
                    arr[i, j] = arr[0, j] * arr[i, 0];
            return arr;
        }
    }
}