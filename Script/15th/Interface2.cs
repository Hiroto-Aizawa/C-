// https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_015/csharp_abc02.html

using System;

namespace Interface1
{
    interface IBase
    {
        void task1();
    }
    interface IDerived : IBase
    {
        void task2();
    }
    class Class1 : IDerived
    {
        public void task1()
        {
            Console.WriteLine("task1() called");
        }
        public void task2()
        {
            Console.WriteLine("task2() called");
        }
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.task1();
            c1.task2();
        }
    }
}