using System;

namespace MatrixMultiply
{
    class MatrixMultiply
    {
        //output result
        static void Output(int[,] result)
        {
            for (int r = 0; r < result.GetLength(0); r++)
            {
                for (int c = 0; c < result.GetLength(1); c++)
                {
                    Console.Write("{0} ", result[r, c]);
                }
                Console.WriteLine();
            }
        }
        //multiply matrix
        static int[,] Multiply(int[,] a, int[,] b)
        {
            int[,] result = new int[2, 2];
            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 2; c++)
                {
                    result[r, c] = a[r, 0] * b[0, c] + a[r, 1] * b[1, c];
                }
            }
            return
                result;
        }
        //enter matrix elem
        static void Input(int[,] dst)
        {
            for (int r = 0; r < dst.GetLength(0); r++)
            {
                for (int c = 0; c < dst.GetLength(1); c++)
                {
                    Console.Write("Enter element of matrix for [{0},{1}]: ", r, c);
                    string s = Console.ReadLine();
                    dst[r, c] = int.Parse(s);
                }
            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
            Input(a);
            Input(b);
            int[,] result = Multiply(a, b);
            Output(result);

            Console.ReadKey();
        }
    }
}