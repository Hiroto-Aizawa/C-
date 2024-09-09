// https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_014/csharp_abc03.html

using System;

namespace ConsoleApplication75
{
    class Class1
    {
        private int n;
        public Class1(int param)
        {
            this.n = param;
        }
        static void Main(string[] args)
        {
            Class1[] ar = new Class1[] { new Class1(1), new Class1(2), new Class1(3) };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(ar[i].n);
            }
        }
    }
}