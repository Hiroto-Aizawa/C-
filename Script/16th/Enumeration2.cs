//https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_016/csharp_abc02.html

namespace ConsoleApplication5
{
    using System;

    enum Era
    {
        Meiji,
        Taisho,
        Showa,
        Heisei
    }
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Era.Meiji);
            Console.WriteLine((int)Era.Taisho);
            Console.WriteLine((int)Era.Showa);
            Console.WriteLine((int)Era.Heisei);
        }
    }
}