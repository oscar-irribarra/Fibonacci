using System;

namespace ConsoleApp1
{
    public class ArreglosOps : IArreglosOps
    {
        Random r = new Random();
        public int[,] RellenarArreglo(int[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    x[i, j] = r.Next(0, 10);
                }
            }
            return x;
        }

        public void LeerArreglo(int[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                Console.Write("\n");
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write($"{x[i, j]} ");
                }
            }
            Console.WriteLine("\n");
        }

        public int[,] MultiplicarArreglo(int[,] x, int[,] y, int[,] n)
        {
            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    n[i, j] = (x[i, j] * y[i, j]);
                }
            }
            return n;
        }

    }
}