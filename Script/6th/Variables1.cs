
namespace Variables1
{
    // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_006/csharp_abc01.html

    using System;

    public class TestClass : ICloneable
    {
        public int n;
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
    public struct TestStructs
    {
        public int n;
    }
    public class Class1
    {
        public static int Main(string[] args)
        {
            // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_006/csharp_abc02.html
            // 【第1～3の答】

            int testInt1, testInt2;
            testInt1 = 123;
            testInt2 = testInt1;
            testInt1 = 456;
            Console.WriteLine("Answer1 testInt1={0}, testInt2={1}", testInt1, testInt2);
            // 予想：456 123
            // 結果：456 123

            TestClass testClass1, testClass2;
            testClass1 = new TestClass();
            testClass2 = new TestClass();
            testClass1.n = 123;
            testClass2.n = testClass1.n;
            testClass1.n = 456;
            Console.WriteLine("Answer2 testClass1.n={0}, testClass2.n={1}", testClass1.n, testClass2.n);
            // 予想：456 123
            // 結果：456 123

            TestClass testClass1a, testClass2a;
            testClass1a = new TestClass();
            testClass1a.n = 123;
            testClass2a = testClass1a;
            testClass1a.n = 456;
            Console.WriteLine("Answer3 testClass1a.n={0}, testClass2a.n={1}", testClass1a.n, testClass2a.n);
            // 予想：456 456
            // 結果：456 456

            // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_006/csharp_abc03.html
            // 【第4～6の答】

            TestClass testClass1b, testClass2b;
            testClass1b = new TestClass();
            testClass1b.n = 123;
            testClass2b = (TestClass)testClass1b.Clone();
            testClass1b.n = 456;
            Console.WriteLine("Answer4 testClass1b.n={0}, testClass2b.n={1}", testClass1b.n, testClass2b.n);
            // 予想：456 123
            // 結果456 123

            TestStructs testStructs1, testStructs2;
            testStructs1.n = 123;
            testStructs2 = testStructs1;
            testStructs1.n = 456;
            Console.WriteLine("Answer5 testStructs1.n={0}, testStructs2.n={1}", testStructs1.n, testStructs2.n);
            // 予想：456 123
            // 結果：456 123

            object testObject1, testObject2;
            testObject1 = 123;
            testObject2 = testObject1;
            testObject1 = 456;
            Console.WriteLine("Answer6 testObject1={0}, testObject2={1}", testObject1, testObject2);
            // 予想：456 456
            // 結果：456 123

            return 0;
        }
    }
}