//https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_013/csharp_abc01.html

namespace EventFunction1
{
    using System;

    // delegate(デレゲート)機能を用いてイベントで使用するメソッドの引数を定義している
    // クラスの外側で中身のないメソッドを宣言する（SampleEventHandlerはデータ型の名前となる）
    public delegate void SampleEventHandler(object sender, EventArgs e);

    class Class1
    {
        // イベントの本体の定義
        // eventキーワードを使用してイベントを定義する
        // SampleaEvnetHandlerは、9行目の定義をデータ型のように使っている
        public event SampleEventHandler sampleEvent;

        // ハンドラ
        // イベントが呼び出された時に処理されるコードのこと
        // ハンドラとして機能するのは、メソッドの戻り値と引数が、
        // 9行目のデレゲートと一致しているため
        public void handler(object o, EventArgs e)
        {
            Console.WriteLine("handler called");
        }

        static void Main(string[] args)
        {
            // 【C#のイベント機能とは何か？】

            // C#のイベント機能は、あるクラスで発生した出来事を、
            // あらかじめ登録されたメソッドに対して、１回の呼び出しですべてを伝える機能

            Class1 target = new Class1();
            // イベント本体にはハンドラの追加(+=) / 削除(-=)の機能がある

            // ハンドラの追加
            // newキーワードでデレゲートのインスタンスを作成している
            target.sampleEvent += new SampleEventHandler(target.handler);

            // イベントの発生
            // イベント名をメソッドのように使って行う
            // 第１引数：イベントを発生させたオブジェクト
            // 第２引数：ハンドラに渡す引数を指定
            target.sampleEvent(target, EventArgs.Empty);// EventArgs.Emptyは引数がないことを示す

            // 出力結果
            // handler called
        }
    }
}

namespace EventFunction2
{
    using System;

    public delegate void SampleEventHandler(object sender, EventArgs e);

    class Class2
    {
        public void startHandler(object o, EventArgs e)
        {
            Console.WriteLine("start handler called");
        }
        public void endHandler(object o, EventArgs e)
        {
            Console.WriteLine("end handler called");
        }
    }
    class Class1
    {
        public event SampleEventHandler startEvent;
        public event SampleEventHandler endEvent;
        Class2 target1 = new Class2();
        Class2 target2 = new Class2();
        Class2 target3 = new Class2();
        public Class1()
        {
            startEvent += new SampleEventHandler(target1.startHandler);
            endEvent += new SampleEventHandler(target1.endHandler);
            startEvent += new SampleEventHandler(target2.startHandler);
            endEvent += new SampleEventHandler(target2.endHandler);
            startEvent += new SampleEventHandler(target3.startHandler);
            endEvent += new SampleEventHandler(target3.endHandler);
        }

        public void process()
        {
            // 何かの処理があると思ってください
        }

        static void Main(string[] args)
        {
            // 【複数ハンドラを扱うイベント】
            
            Class1 main = new Class1();
            main.startEvent(main, EventArgs.Empty);
            main.process();
            main.endEvent(main, EventArgs.Empty);
            // 出力結果
            // start handler called
            // start handler called
            // start handler called
            // end handler called
            // end handler called
            // end handler called
        }
    }
}