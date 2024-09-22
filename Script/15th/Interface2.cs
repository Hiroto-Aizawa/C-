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

using System;

namespace ConsoleApplication97
{
    public delegate void SampleEvent(object sender, EventArgs e);
    public interface ISample
    {
        int SampleProperty { get; set; }
        string this[int index] { get; set; }
        event SampleEvent sampleEvent;
    }
    class Class1 : ISample
    {
        private int sample = 0;
        public int SampleProperty
        {
            get { return sample; }
            set { sample = value; }
        }
        private string[] ar = new string[3];
        public string this[int index]
        {
            get { return ar[index]; }
            set { ar[index] = value; }
        }
        public event SampleEvent sampleEvent;
        public void handler(object sender, EventArgs e)
        {
            ISample isample = (ISample)sender;
            Console.WriteLine(isample.SampleProperty);
            Console.WriteLine(isample[0]);
            Console.WriteLine(isample[1]);
            Console.WriteLine(isample[2]);
        }
        public void invokeEvent()
        {
            sampleEvent(this, EventArgs.Empty);
        }
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.SampleProperty = 123;
            c1[0] = "ABC";
            c1[1] = "DEF";
            c1[2] = "GHI";
            c1.sampleEvent += new SampleEvent(c1.handler);
            c1.invokeEvent();
        }
    }
}