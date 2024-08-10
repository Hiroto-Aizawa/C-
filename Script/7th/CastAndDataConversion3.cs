namespace CastAndDataConversion1
{
    // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_007/csharp_abc03.html
    
    using System;
    public class Class1
    {
        public string hello;
        public static int Main(string[] args)
        {
            // 【参照型のキャスト】

            // インスタンス化
            Class1 c = new Class1();
            c.hello = "Hello!";

            // object型への変換
            object o = (object)c;

            // Class1に再キャストすれば、完全に元通りの機能を取り戻す
            // ただし、値型の場合には元に戻らないので注意
            Class1 c2 = (Class1)o;

            Console.WriteLine("{0}\n{1}", c.hello, c2.hello);
            // 出力結果
            // コンパイラ内部で数値がdouble型だと認識され、暗黙的に変化できないとエラーになる
            return 0;
        }
    }
}


namespace CastAndDataConversion2
{
    using System;
    public class Class2
    {
        public String hello;
    }
    public class Class1
    {
        public String hello;
        public static int Main(string[] args)
        {
            // 【無関係の参照型へのキャスト】

            
            Class1 c = new Class1();
            c.hello = "Hello!";
            object o = (object)c;
            // Class1とは無関係なクラスにキャストしている
            Class2 c2 = (Class2)o;
            // コンパイルではエラーは起こらないが、
            // 実行すると例外が発生したというエラーメッセージが表示され強制終了する
            Console.WriteLine("{0},{1}", c.hello, c2.hello);
            // 出力結果
            Unhandled Exception:
            // System.InvalidCastException: Specified cast is not valid.
            //   at ConsoleApplication11.Class1.Main (System.String[] args) [0x00013] in <fdc616ebbbca43c08f364d635b2f19ff>:0 
            // [ERROR] FATAL UNHANDLED EXCEPTION: System.InvalidCastException: Specified cast is not valid.
            //   at ConsoleApplication11.Class1.Main (System.String[] args) [0x00013] in <fdc616ebbbca43c08f364d635b2f19ff>:0 

            return 0;
        }
    }
}