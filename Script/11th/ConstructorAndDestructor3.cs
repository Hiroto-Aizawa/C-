// https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_011/csharp_abc03.html

namespace ConstructorAndDestructor1
{
    using System;

    class Class2
    {
        // デストラクタ
        // クラス名の前に「~」をつけることで明示する
        ~Class2()
        {
            Console.WriteLine("Class2's destructor called");
        }
    }
    class Class1
    {
        static private void test()
        {
            Console.WriteLine("static private void test() called");
            Class2 t1 = new Class2();
            Console.WriteLine("static private void test() done");
        }
        static void Main(string[] args)
        {
            // 【デストラクタとは何か？】

            // デストラクタとは、インスタンスが消滅する際に呼び出されるメソッド
            // デストラクタが呼ばれるタイミングは予測不可能なため注意が必要

            Console.WriteLine("static void Main(string[] args) called");
            test();
            Console.WriteLine("static void Main(string[] args) done");
            // 出力結果
            // static void Main(string[] args) called
            // static private void test() called
            // static private void test() done
            // static void Main(string[] args) done
            // Class2's destructor called
        }
    }
}

namespace ConstructorAndDestructor2
{
    using System;

    class Class2
    {
        public void close()
        {
            Console.WriteLine("public void close() called");
        }
    }
    class Class1
    {
        static private void test()
        {
            Console.WriteLine("static private void test() called");
            Class2 t1 = new Class2();
            try
            {
                // 何かの処理がここにあると想像してください
            }
            // 例外処理
            // try処理が終わった後に必ず実行される
            finally
            {
                // 終了処理
                t1.close();
            }
            Console.WriteLine("static private void test() done");
        }
        static void Main(string[] args)
        {
            // 【確実な終了処理】
            // コンストラクタとデストラクタとは別の内容

            Console.WriteLine("static void Main(string[] args) called");
            test();
            Console.WriteLine("static void Main(string[] args) done");
            // 出力結果
            // static void Main(string[] args) called
            // static private void test() called
            // public void close() called
            // static private void test() done
            // static void Main(string[] args) done
        }
    }
}

namespace ConsoleApplication35
{
    using System;

    // 確実な終了処理をさせたいクラスにIDispaosableインターフェイスを実装する
    class Class2 : IDisposable
    {
        // デストラクタ
        ~Class2()
        {
            Console.WriteLine("Class2's destructor called");
        }
        void IDisposable.Dispose()
        {
            Console.WriteLine("void IDisposable.Dispose() called");
        }
    }
    class Class1
    {
        static private void test()
        {
            Console.WriteLine("static private void test() called");
            // usingステートメントを使ってインスタンスを生成する
            // すると、usingステートメントの範囲（116~119行目）から抜け出す時点で、
            // IDisposableインターフェイスのDisposeメソッドを呼び出す
            using (Class2 t1 = new Class2())
            {
                // ここに何かの処理があると想像してください
            }
            Console.WriteLine("static private void test() done");
        }
        static void Main(string[] args)
        {
            // 【IDisposableとusingによる終了処理】
            
            Console.WriteLine("static void Main(string[] args) called");
            test();
            Console.WriteLine("static void Main(string[] args) done");
        }
    }
}