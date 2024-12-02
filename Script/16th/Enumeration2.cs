//https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_016/csharp_abc02.html

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
            Console.WriteLine((int)Era.Meiji);
            Console.WriteLine((int)Era.Taisho);
            Console.WriteLine((int)Era.Showa);
            Console.WriteLine((int)Era.Heisei);
        }
    }
}

namespace Enumeration2
{
    using System;

    enum Era : byte
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
            Console.WriteLine((byte)Era.Meiji);
            Console.WriteLine((byte)Era.Taisho);
            Console.WriteLine((byte)Era.Showa);
            Console.WriteLine((byte)Era.Heisei);
        }
    }
}