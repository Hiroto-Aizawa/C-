https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_013/csharp_abc02.html

namespace EventFunction1
{
    using System;

    public class SampleEventArgs : EventArgs
    {
        public string message;
    }

    // イベントで使用するメソッドの引数を定義している
    // EventArgsを継承したSampleEventArgsのクラスを引数にしている
    public delegate void SampleEventHandler(object sender, SampleEventArgs e);

    class Class1
    {
        // イベント本体の定義
        public event SampleEventHandler sampleEvent;

        // イベント発生時に処理される内容
        public void handler(object o, SampleEventArgs e)
        {
            // 9行目の変数messageを出力する
            Console.WriteLine(e.message);
        }
        static void Main(string[] args)
        {
            // 【イベントに引数を渡す】

            // 【イベントに引数を渡す】

            Class1 target = new Class1();
            // delegeteのインスタンス生成
            target.sampleEvent += new SampleEventHandler(target.handler);
            SampleEventArgs sampleEventArgs = new SampleEventArgs();
            // 9行目のEventArgsを継承したSampleEventArgsクラスの変数messageに代入
            sampleEventArgs.message = "in main method";
            // イベントの発生
            target.sampleEvent(target, sampleEventArgs);
        }
    }
}

namespace EventFunction2
{
    using System;

    // イベントで使用するメソッドの引数を定義している
    // EventArgsクラスを引数にしている
    public delegate void SampleEventHandler(object sender, EventArgs e);

    class Class1
    {
        // staticなイベント本体の定義
        public static event SampleEventHandler sampleEvent;

        // staticなイベント発生時に処理される内容
        public static void handler(object o, EventArgs e)
        {
            Console.WriteLine("handler called");
        }

        static void Main(string[] args)
        {
            // 【staticなイベント】

            // staticでイベントを宣言しているため、インスタンス化は不要
            sampleEvent += new SampleEventHandler(handler);
            sampleEvent(null, EventArgs.Empty);
        }
    }
}

namespace EventFunction3_1
{
    using System;

    // イベントで使用するメソッドの引数を定義している
    // EventArgsクラスを引数にしている
    public delegate void SampleEventHandler(object sender, EventArgs e);

    class Class1
    {
        // イベント本体の定義
        public event SampleEventHandler sampleEvent;
    }

    class Class2
    {
        // イベント発生時に処理される内容
        public void handler(object o, EventArgs e)
        {
            Console.WriteLine("handler called");
        }

        static void Main(string[] args)
        {
            //　【イベントではできないこと】

            Class1 target1 = new Class1();
            Class2 target2 = new Class2();
            // イベントを通知される側に制約がないためハンドラの登録は問題なくできる
            target1.sampleEvent += new SampleEventHandler(target2.handler);
            // Class2の中から、Class1で記述されたイベントを呼び出そうとするとエラーになる
            // イベントの呼び出しはイベントが定義されているクラス内からしかできない
            target1.sampleEvent(target2, EventArgs.Empty);
        }
    }
}

namespace EventFunction3_2
{
    using System;

    // イベントで使用するメソッドの引数を定義している
    // EventArgsクラスを引数にしている
    public delegate void SampleEventHandler(object sender, EventArgs e);

    class Class1
    {
        // イベント本体の定義
        public event SampleEventHandler sampleEvent;
    }

    class Class2 : Class1
    {
        // イベント発生時に処理される内容
        public void handler(object o, EventArgs e)
        {
            Console.WriteLine("handler called");
        }

        static void Main(string[] args)
        {
            //　【イベントではできないこと】

            Class2 target2 = new Class2();
            target2.sampleEvent += new SampleEventHandler(target2.handler);
            // Class1を継承したClass2でイベントを呼び出そうとするとエラーになる
            // イベントを定義しているクラスを継承しても、イベントは同じクラス内からしか呼び出せない
            target2.sampleEvent(target2, EventArgs.Empty);
        }
    }
}