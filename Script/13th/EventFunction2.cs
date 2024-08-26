https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_013/csharp_abc02.html

namespace EventFunction1
{
    using System;

    public class SampleEventArgs : EventArgs
    {
        public string message;
    }
    public delegate void SampleEventHandler(object sender, SampleEventArgs e);
    class Class1
    {
        public event SampleEventHandler sampleEvent;
        public void handler(object o, SampleEventArgs e)
        {
            Console.WriteLine(e.message);
        }
        static void Main(string[] args)
        {
            // 【イベントに引数を渡す】

            Class1 target = new Class1();
            target.sampleEvent += new SampleEventHandler(target.handler);
            SampleEventArgs sampleEventArgs = new SampleEventArgs();
            sampleEventArgs.message = "in main method";
            target.sampleEvent(target, sampleEventArgs);
        }
    }
}

namespace EventFunction2
{
    using System;

    public delegate void SampleEventHandler(object sender, EventArgs e);
    class Class1
    {
        public static event SampleEventHandler sampleEvent;
        public static void handler(object o, EventArgs e)
        {
            Console.WriteLine("handler called");
        }
        static void Main(string[] args)
        {
            // 【staticなイベント】
            sampleEvent += new SampleEventHandler(handler);
            sampleEvent(null, EventArgs.Empty);
        }
    }
}