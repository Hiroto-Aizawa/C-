namespace CastAndDataConversion1
{
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