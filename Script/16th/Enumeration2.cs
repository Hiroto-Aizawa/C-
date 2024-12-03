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


namespace Enumeration3
{
    using System;
    class Class2
    {
        private enum Era
        {
            Meiji,
            Taisho
        }
        public static void WriteMeiji()
        {
            Console.WriteLine(Class2.Era.Meiji);
        }
    }
    class Class1
    {
        enum Era
        {
            Showa,
            Heisei
        }
        static void Main(string[] args)
        {
            //Console.WriteLine( Class2.Era.Meiji );  //エラー 'ConsoleApplication7.Class2.Era' はアクセスできない保護レベルになっています。
            Class2.WriteMeiji();
            Console.WriteLine(Class1.Era.Showa);
        }
    }
}