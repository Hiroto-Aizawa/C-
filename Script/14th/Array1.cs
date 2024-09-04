//https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_014/csharp_abc01.html

namespace Array1
{
    using System;

    class Class1
    {
        static void Main(string[] args)
        {
            int[] ar = new int[10];
            for (int i = 0; i < 10; i++)
            {
                ar[i] = i;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(ar[i]);
            }
        }
    }
}