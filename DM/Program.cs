using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[3, 3];
        int value = 1, row = 1, col = 1;
        matrix[row, col] = value++;

        int[,] directions = { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };
        int directionIndex = 0, steps = 1;

        while (value <= 9)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < steps; j++)
                {
                    row += directions[directionIndex, 0];
                    col += directions[directionIndex, 1];
                    if (row >= 0 && row < 3 && col >= 0 && col < 3)
                    {
                        matrix[row, col] = value++;
                    }
                }
                directionIndex = (directionIndex + 1) % 4;
            }
            steps++;
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
