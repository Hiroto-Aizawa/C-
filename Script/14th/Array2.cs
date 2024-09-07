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