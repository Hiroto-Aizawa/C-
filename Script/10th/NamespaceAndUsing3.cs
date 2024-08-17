// https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_010/csharp_abc03.html

using System;

namespace Space1.Sub1
{
    class Class2
    {
        public static void test()
        {
            Console.WriteLine("Space1.Sub1.Class2.test()");
        }
    }
}

namespace NamespaceAndUsing1
{
    using Space1;
    class Class1
    {
        static void Main(string[] args)
        {
            // 【不完全なnamespaceとusing】

            // namespaceのネストの一部だけを指定するものであってはならない
            Sub1.Class2.test(); // Sub1が見つからないというコンパイル・エラーになる
            // 出力結果
            // Main.cs(24,13): error CS0103: The name `Sub1' does not exist in the current context
            // Compilation failed: 1 error(s), 0 warnings

            // 正しくは、Space1.Sub1.Class2.test();
        }
    }
}

///////////////////////////////////////////////////////////////////////////////

using System;

namespace Space1.Sub1
{
    class Class2
    {
        public static void test()
        {
            Console.WriteLine("Space1.Sub1.Class2.test()");
        }
    }
}

namespace Space2.Sub1
{
    class Class2
    {
        public static void test()
        {
            Console.WriteLine("Space2.Sub1.Class2.test()");
        }
    }
}

namespace NamespaceAndUsing2
{
    using Space1.Sub1;
    using Space2.Sub1;
    class Class1
    {
        static void Main(string[] args)
        {
            // 【デフォルトnamespaceを指定するusingの複数使用】

            // namespaceを省略した記載だが、複数のnamespaceにClass2が存在しているため、
            // どのnamespaceから呼び出そうとしているかが分からない
            Class2.test(); // Class2はあいまいな参照、というコンパイル・エラーになる
        }
    }
}

// 上記のあいまいな参照を解決した例↓

using System;

namespace Space1.Sub1
{
    class Class2
    {
        public static void test()
        {
            Console.WriteLine("Space1.Sub1.Class2.test()");
        }
    }
}

namespace Space2.Sub1
{
    class Class2
    {
        public static void test()
        {
            Console.WriteLine("Space2.Sub1.Class2.test()");
        }
    }
}

namespace NamespaceAndUsing3
{
    using Space1.Sub1;
    using Space2.Sub1;
    using MyClass2 = Space1.Sub1.Class2;
    class Class1
    {
        static void Main(string[] args)
        {
            // usingでSpace1.Sub1.Class2を使用することを明示する
            MyClass2.test();
            // 出力結果
            // Space1.Sub1.Class2.test()
        }
    }
}