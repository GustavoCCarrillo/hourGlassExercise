using System;

namespace hourGlassExercise
{
    class Program
    {
        //THIS IS A HACKERRANK CHALLENGE


        static int hourglassSum(int[][] arr)
        {
            int max_sum = int.MinValue;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    max_sum = Math.Max(max_sum, sum);
                }
            }
            return max_sum;
        }

        static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            int result = hourglassSum(arr);
            Console.WriteLine($"The hourglass max sum is {result}");

        }
    }
}
