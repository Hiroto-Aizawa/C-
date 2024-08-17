// https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_010/csharp_abc02.html

using System;

namespace Space1.Sub1
{
    class Class1
    {
        public static void test()
        {
            Console.WriteLine("Space1.Sub1.Class1.test() called");
        }
    }
}

namespace NamespaceAndUsing1
{
    // usingを用いて既存のnamespaceに別名をつける
    using MyClass = Space1.Sub1.Class1;
    using MySpace1 = Space1.Sub1;
    using MySpace2 = Space1;
    // using Class1 = Space1.Sub1.Class1; // 下のClass1と名前が同じになるのでエラー
    // using MySpace3 = MySpace2.Sub1; // usingの対象にusingされたキーワードMySpace2は使用できないのでエラー
    class Class1
    {
        static void Main(string[] args)
        {
            // 【namespaceやクラスの別名を宣言するusing】

            MyClass.test();
            MySpace1.Class1.test();
            MySpace2.Sub1.Class1.test();
            // 出力結果
            // Space1.Sub1.Class1.test() called
            // Space1.Sub1.Class1.test() called
            // Space1.Sub1.Class1.test() called
        }
    }
}

///////////////////////////////////////////////////////////////////////////////

// デフォルトのnamespaceを宣言するusing
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

namespace NamespaceAndUsing2
{
    using Space1.Sub1;
    class Class1
    {
        static void Main(string[] args)
        {
            // 【デフォルトのnamespaceを宣言するusing】

            // using Space1.Sub1を宣言しているため、
            // Class2.test();と記述するだけで、自動的にSpace1.Sub1が保管される
            Class2.test();
            // 出力結果
            // 
        }
    }
}