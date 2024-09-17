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
        // インターフェイスの共有
        // 引数としてISpecialTaskを参照する
        // ISpecialTaskを継承したクラスからは必ずインターフェイスへの参照を取得できる
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
            // 出力結果
            // task() in Class2
            // task() in Class3
        }
    }
}

namespace Interface2
{
    using System;

    abstract class ClassSpecialTask
    {
        public abstract void task();
    }
    class Class2 : ClassSpecialTask
    {
        public override void task()
        {
            Console.WriteLine("task() in Class2");
        }
    }
    class Class3 : ClassSpecialTask
    {
        public override void task()
        {
            Console.WriteLine("task() in Class3");
        }
    }
    class Class1
    {
        static void callTask(ClassSpecialTask ist)
        {
            ist.task();
        }
        static void Main(string[] args)
        {
            // 【軽症で実現した例】

            Class2 c2 = new Class2();
            Class3 c3 = new Class3();
            callTask(c2);
            callTask(c3);
        }
    }
}