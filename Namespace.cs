using System;

namespace Namespace1
{
    class Class1
    {
        public static void Hello()
        {
            Console.WriteLine("Namespace1のClass1のHello()");
        }

        public static void Test()
        {
            Hello();
            Class1.Hello();
            Namespace1.Class1.Hello();
            Namespace2.Class1.Hello();
        }

        public static int Main(string[] args)
        {
            Namespace1.Class1.Test();
            Namespace2.Class1.Test();
            return 0;

            /* 出力結果
            // Namespace1のClass1のHello()
            // Namespace1のClass1のHello()
            // Namespace1のClass1のHello()
            // Namespace2のClass1のHello()
            // Namespace2のClass1のHello()
            // Namespace2のClass1のHello()
            // Namespace1のClass1のHello()
            // Namespace2のClass1のHello()
            */
        }
    }
}

namespace Namespace2
{
    class Class1
    {
        public static void Hello()
        {
            Console.WriteLine("Namespace2のClass1のHello()");
        }

        public static void Test()
        {
            Hello();
            Class1.Hello();
            Namespace1.Class1.Hello();
            Namespace2.Class1.Hello();
        }
    }
}