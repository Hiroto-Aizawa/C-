namespace CastAndDataConversion1
{
    // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_007/csharp_abc02.html

    using System;
    public class Class1
    {
        public static int Main(string[] args)
        {
            // 【実数でもキャスト】

            double d = 0.123456789012345;
            float f = (float)d;
            // 桁数の多いdouble型を桁数の少ないfloat型にキャストした場合、
            // 数値の精度が落ちる可能性がある
            Console.WriteLine("{0}\n{1}", d, f);
            // 出力結果
            // 0.123456789012345 
            // 0.1234568
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
            //  【定数値にキャスト】

            decimal e = 0.123456789;
            Console.WriteLine("{0}", e);
            // 出力結果
            // コンパイラ内部で数値がdouble型だと認識され、暗黙的に変化できないとエラーになる
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
            // 【定数値にキャスト】

            // 数値の末尾に「m」を追加することでdecimal型であることを明示する
            // 他には「u」= 符号なし。「l」= long型。「f」= float型。「d」= double型などがある
            decimal e = 0.123456789m;
            Console.WriteLine("{0}", e);
            // 出力結果
            // 0.123456789
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
            // 【符号の有無は注意】

            short i = -1;
            // 符号なしのデータ型に代入すると元の値を保持できるとは限らない
            ushort u = (ushort)i;
            Console.WriteLine("{0} , {1}", i, u);
            // 出力結果
            // -1 , 65535
            return 0;
        }
    }
}

namespace CastAndDataConversion5
{
    using System;
    public class Class1
    {
        public static int Main(string[] args)
        {
            // 【小数の切り捨て】

            //0.25「f」でfloat型であるこ明示する
            for (float f = -2; f < 2; f += 0.25f)
            {
                int i = (int)f;
                // 実数から整数にキャストする場合は、
                // 同一符号で絶対値がその値を超えない最大の整数に変換される
                Console.WriteLine("{0}, {1}", f, i);
                // 出力結果
                // -2, ||  -2
                // -1.75, ||  -1
                // -1.5, ||  -1
                // -1.25, ||  -1
                // -1, ||  -1
                // -0.75, ||  0
                // -0.5, ||  0
                // -0.25, ||  0
                // 0, ||  0
                // 0.25, ||  0
                // 0.5, ||  0
                // 0.75, ||  0
                // 1, ||  1
                // 1.25, ||  1
                // 1.5, ||  1
                // 1.75, ||  1
            }
            return 0;
        }
    }
}