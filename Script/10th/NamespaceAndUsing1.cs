// https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_010/csharp_abc01.html

using System;

namespace Space1.Sub1
{
    class Class1
    {
        public static void test()
        {
            Console.WriteLine("Space1.Sub1.test() called");
        }
    }
}

namespace Space2
{
    namespace Sub1
    {
        class Class1
        {
            public static void test()
            {
                Console.WriteLine("Space2.Sub1.test() called");
            }
        }
    }
}

namespace NamespaceAndUsing1
{
    class Class1
    {
        static void Main(string[] args)
        {
            // 【ネストするnamespace】

            // Space1.Sub1はネストしていないnamespace
            Space1.Sub1.Class1.test();
            // Space2 > Sub1はネストしているnamespace
            Space2.Sub1.Class1.test();

            // 出力結果
            // Space1.Sub1.test() called
            // Space2.Sub1.test() called

            // ピリオド区切り、ネストしたnamespaceも機能的な差はない
        }
    }
}

///////////////////////////////////////////////////////////////////////////////

using System;

namespace Space1
{
    class Class1
    {
        public static void test()
        {
            Console.WriteLine("Space1.Class1.test() called");
        }
    }
}

namespace Space1
{
    class Class2
    {
        public static void test()
        {
            Console.WriteLine("Space1.Class2.test() called");
        }
    }
}

namespace NamespaceAndUsing2
{
    class Class1
    {
        static void Main(string[] args)
        {
            // 【繰り返し宣言されるnamespace】

            Space1.Class1.test();
            Space1.Class2.test();
            // 出力結果
            // Space1.Class1.test() called
            // Space1.Class2.test() called

            // namespaceの宣言は1ブロックにまとめる必要はない
            // しかし、namespace内に同じ名前のクラスを2つ以上持つことはできない点に注意

        }
    }
}