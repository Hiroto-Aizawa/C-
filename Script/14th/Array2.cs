//https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_014/csharp_abc02.html

using System;

namespace ConsoleApplication73
{
    class Class1
    {
        static void Main(string[] args)
        {
            string[] ar = new string[10];
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine( ar[i].Length );  // 実行時にnullを参照したというエラーになる
            }
            for (int i = 0; i < 10; i++)
            {
                ar[i] = (i * 2).ToString();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(ar[i].Length);
            }
        }
    }
}

namespace ConsoleApplication74
{
    using System;
    
    class Class1
    {
        static void Main(string[] args)
        {
            int[] ar1 = new int[4] { 0, 1, 2, 3 };
            int[] ar2 = new int[] { 0, 1, 2, 3 };
            int[] ar3 = { 0, 1, 2, 3 };
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0},{1},{2}", ar1[i], ar2[i], ar3[i]);
            }
        }
    }
}