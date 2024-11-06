// https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_016/csharp_abc01.html


namespace Enumeration1
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
        static void WriteEra(Era t)
        {
            switch (t)
            {
                case Era.Meiji:
                    Console.WriteLine("明治");
                    break;
                case Era.Taisho:
                    Console.WriteLine("大正");
                    break;
                case Era.Showa:
                    Console.WriteLine("昭和");
                    break;
                case Era.Heisei:
                    Console.WriteLine("平成");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Era t = Era.Taisho;
            WriteEra(t);
        }
    }
}

namespace Enumeration1
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
            Era t = Era.Taisho;
            Console.WriteLine(t);
        }
    }
}