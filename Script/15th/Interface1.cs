// https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_015/csharp_abc01.html

namespace Interface1
{
    using System;

    interface ISpecialTask
    {
        void task();
    }

    class Class2 : ISpecialTask
    {
        public void task()
        {
            Console.WriteLine("task() in Class2");
        }
    }

    class Class3 : ISpecialTask
    {
        public void task()
        {
            Console.WriteLine("task() in Class3");
        }
    }

    class Class1
    {
        static void callTask(ISpecialTask ist)
        {
            ist.task();
        }
        static void Main(string[] args)
        {
            // 【インターフェイスの効能】

            
            Class2 c2 = new Class2();
            Class3 c3 = new Class3();
            callTask(c2);
            callTask(c3);
        }
    }
}