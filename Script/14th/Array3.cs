// https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_014/csharp_abc03.html

namespace ConsoleApplication75
{
    using System;

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

namespace ConsoleApplication76
{
    using System;

    class Class1
    {
        static void Main(string[] args)
        {
            int[] ar = { 0, 1, 2, 3, 4 };
            for (int i = ar.GetLowerBound(0); i <= ar.GetUpperBound(0); i++)
            {
                Console.WriteLine(ar[i]);
            }
        }
    }
}