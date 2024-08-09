
namespace CastAndDataConversion1
{
    // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_007/csharp_abc01.html

    using System;
    public class Class1
    {
        public static int Main(string[] args)
        {
            // 【目に見えない変換】

            // 桁数が少ない方からに多い型へ（暗黙的に）変換は可能
            sbyte b = 123;
            // byte型からshort型へ（暗黙的に）変換
            short s = b;
            // short型からint型へ（暗黙的に）変換
            int i = s;
            // int型からlong型へ（暗黙的に）変換
            long l = i;
            Console.WriteLine("{0},{1},{2},{3}", b, s, i, l);
            return 0;
        }
    }
}


namespace CastAndDataConversion2
{
    using System;
    public class Class1
    {
        public static int Main(string[] args)
        {
            // 【暗黙の変換ができないとき】

            // 桁数が多い型から少ない方に（暗黙的に）変換するとエラーになる
            long l = 123;
            int i = l;
            short s = i;
            sbyte b = s;
            Console.WriteLine("{0},{1},{2},{3}", b, s, i, l);
            return 0;
        }
    }
}


namespace CastAndDataConversion3
{
    using System;
    public class Class1
    {
        public static int Main(string[] args)
        {
            // 【明示的に変換する】

            long l = 123;
            // (型名)変数 の形式で明示的に型のキャストする

            // 桁数の多い型から少ない型にキャストする場合変数に代入されている値が、
            // キャスト後の型の上限を超えないように注意する
            int i = (int)l;
            short s = (short)i;
            sbyte b = (sbyte)s;
            // 型の上限を超えない値が格納されているためエラーにならない
            Console.WriteLine("{0},{1},{2},{3}", b, s, i, l);
            return 0;
        }
    }
}


namespace CastAndDataConversion4
{
    using System;
    public class Class1
    {
        public static int Main(string[] args)
        {
            // 【キャストがデータを壊すとき】
            long l = 1844674407370955161;

            // 桁数の多い方から少ない型にキャスト
            // キャスト後の型の上限を超える値が代入されている場合
            int i = (int)l;
            short s = (short)i;
            sbyte b = (sbyte)s;
            // 型の上限を超えない値が格納されているためエラーになる
            Console.WriteLine("{0},{1},{2},{3}", b, s, i, l);
            return 0;
        }
    }
}