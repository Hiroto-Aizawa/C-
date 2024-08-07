namespace DataType1
{
    // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_005/csharp_abc01.html

    using System;
    public class Class1
    {
        public static int Main(string[] args)
        {
            // 【整数型からメソッドを呼ぶ】
            int i = 123;
            string s = i.ToString();
            Console.WriteLine("i={0}, s={1}", i, s);

            // 【2つの名前を持つデータ型】
            // System.Int32 == int
            System.Int32 num = 123;
            // Systen.String == string
            System.String str = num.ToString();
            // 型名が異なっても、データ型が一致していれば同じ出力になる
            Console.WriteLine("i={0}, s={1}", num, str);
            string int = "hello";

            return 0;
        }
    }
}


namespace DataType2
{
    //https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_005/csharp_abc01.html

    using System;

    public class Class1
    {
        public static int Main(string[] args)
        {
            // 【数値の範囲】
            // 各データ型の上限、下限を出力する
            Console.WriteLine("System.SByte   {0}, {1}",
              System.SByte.MinValue, System.SByte.MaxValue);

            Console.WriteLine("System.Byte    {0}, {1}",
              System.Byte.MinValue, System.Byte.MaxValue);

            Console.WriteLine("System.Int16   {0}, {1}",
              System.Int16.MinValue, System.Int16.MaxValue);

            Console.WriteLine("System.UInt16  {0}, {1}",
              System.UInt16.MinValue, System.UInt16.MaxValue);

            Console.WriteLine("System.Int32   {0}, {1}",
              System.Int32.MinValue, System.Int32.MaxValue);

            Console.WriteLine("System.UInt32  {0}, {1}",
              System.UInt32.MinValue, System.UInt32.MaxValue);

            Console.WriteLine("System.Int64   {0}, {1}",
              System.Int64.MinValue, System.Int64.MaxValue);

            Console.WriteLine("System.UInt64  {0}, {1}",
              System.UInt64.MinValue, System.UInt64.MaxValue);

            // charは文字型なので、int型にキャストして出力する
            Console.WriteLine("System.Char    {0}, {1}",
              (int)System.Char.MinValue, (int)System.Char.MaxValue);

            Console.WriteLine("System.Single  {0}, {1}",
              System.Single.MinValue, System.Single.MaxValue);

            Console.WriteLine("System.Double  {0}, {1}",
              System.Double.MinValue, System.Double.MaxValue);

            Console.WriteLine("System.Decimal {0}, {1}",
              System.Decimal.MinValue, System.Decimal.MaxValue);
            return 0;
        }
    }
}

namespace DataType3
{
    // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_005/csharp_abc01.html

    using System;

    public class Class1
    {
        private static int i;
        public static int Main(string[] args)
        {
            // 【初期化される変数値】

            // 変数iはなにも代入されていない空の状態である
            // しかし、出力結果は「0」となる
            // これは初期化されていない変数を使用した際に
            // 不安定なプログラムになることを避けるための使用
            Console.WriteLine(i);
            return 0;
        }
    }
}