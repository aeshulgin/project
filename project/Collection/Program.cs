using System;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] field = new char[3][];
            field[0] = new char[3];
            field[1] = new char[3];
            field[2] = new char[3];

            field[0][0] = 'X';
            field[2][2] = '0';

            for(int i = 0; i < field.Length; i++)
            {
                for(int j = 0; j < field[i].Length; j++)
                {
                    Console.Write(field[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
