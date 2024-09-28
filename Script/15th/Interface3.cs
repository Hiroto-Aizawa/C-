// https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_015/csharp_abc03.html


using System;

namespace Interface1
{
    interface ISample1
    {
        void task();
    }
    interface ISample2
    {
        void task();
    }
    class Class2 : ISample1
    {
        public void task()
        {
            Console.WriteLine("task() in class2 called");
        }
    }
    class Class3 : ISample1, ISample2
    {
        void ISample1.task()
        {
            Console.WriteLine("ISample1.task() in class3 called");
        }
        void ISample2.task()
        {
            Console.WriteLine("ISample2.task() in class3 called");
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            // 【同名のメソッドを持つインターフェイス】

            Class2 c2 = new Class2();
            c2.task();
            Class3 c3 = new Class3();
            //c3.task();  // 'ConsoleApplication98.Class3' に 'task' の定義がありません。
            ISample1 i1 = (ISample1)c3;
            i1.task();
            ISample2 i2 = (ISample2)c3;
            i2.task();
        }
    }
}

namespace ConsoleApplication99
{
    using System;
    using System.Collections;

    class ClassMyEnumerator : IEnumerator
    {
        private int pointer;
        string[] target;
        object IEnumerator.Current
        {
            get { return target[pointer]; }
        }
        bool IEnumerator.MoveNext()
        {
            if (pointer >= target.GetUpperBound(0)) return false;
            pointer++;
            return true;
        }
        void IEnumerator.Reset()
        {
            pointer = target.GetLowerBound(0) - 1;
        }
        public ClassMyEnumerator(string[] array)
        {
            target = array;
            pointer = target.GetLowerBound(0) - 1;
        }
    }
    class ClassSample : IEnumerable
    {
        string[] ar = { "ABC", "DEF", "GHI" };
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ClassMyEnumerator(ar);
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            ClassSample c = new ClassSample();
            foreach (string s in c)
            {
                Console.WriteLine(s);
            }
        }
    }
}