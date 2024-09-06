//https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_014/csharp_abc01.html

namespace Array1
{
    using System;

    class Class1
    {
        static void Main(string[] args)
        {
            // 【C#の一次元配列】

            // 要素数が10個のint配列を宣言
            int[] ar = new int[10];

            for (int i = 0; i < 10; i++)
            {
                ar[i] = i;
                Console.WriteLine(ar[i]);
            }
            // 出力結果
            // 0
            // 1
            // 2
            // 3
            // 4
            // 5
            // 6
            // 7
            // 8
            // 9
        }
    }
}

namespace Array2
{
    using System;

    class Class1
    {
        static void Main(string[] args)
        {
            // 【2次元以上の配列】

            // 10x10(100)の要素を持つ2次元配列を宣言
            int[,] ar = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    ar[i, j] = i * j;
                    Console.Write(ar[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            // 出力結果
            // 0 0 0 0 0 0 0 0 0 0 
            // 0 1 2 3 4 5 6 7 8 9 
            // 0 2 4 6 8 10 12 14 16 18 
            // 0 3 6 9 12 15 18 21 24 27 
            // 0 4 8 12 16 20 24 28 32 36 
            // 0 5 10 15 20 25 30 35 40 45 
            // 0 6 12 18 24 30 36 42 48 54 
            // 0 7 14 21 28 35 42 49 56 63 
            // 0 8 16 24 32 40 48 56 64 72 
            // 0 9 18 27 36 45 54 63 72 81 
        }
    }
}

namespace Array3
{
    using System;

    class Class1
    {
        static void Main(string[] args)
        {
            // 【3次元配列】

            // 3x3x3(27)の要素数を持つ3次元配列を宣言
            int[,,] ar = new int[3, 3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        ar[i, j, k] = i * j * k;
                        Console.Write(ar[i, j, k]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            // 出力結果
            // 0  0  0 
            // 0  0  0 
            // 0  0  0

            // 0  0  0 
            // 0  1  2 
            // 0  2  4 

            // 0  0  0 
            // 0  2  4 
            // 0  4  8
        }
    }
}