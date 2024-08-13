namespace ExpressionsAndOperators1
{
    // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_008/csharp_abc02.html

    using System;

    public class Class1
    {
        public static bool returnTrue(int value)
        {
            return true;
        }
        public static bool returnFalse(int value)
        {
            return false;
        }
        public static int Main(string[] args)
        {
            // 【四則演算】

            Console.WriteLine("★★ 基本演算（みんな理解しよう）");
            Console.WriteLine("2+3\t=\t{0}", 2 + 3);
            int x1 = 2147483647, y1 = 1;
            Console.WriteLine("2147483647+1\t=\t{0}", x1 + y1);
            Console.WriteLine("2147483647u+1u\t=\t{0}", 2147483647u + 1u);
            uint x2 = 4294967295u, y2 = 1u;
            Console.WriteLine("4294967295u+1u\t=\t{0}", x2 + y2);

            Console.WriteLine("3-2\t=\t{0}", 3 - 2);
            int x3 = -2147483648, y3 = 1;
            Console.WriteLine("-2147483648-1\t=\t{0}", x3 - y3);
            uint x4 = 0u, y4 = 1u;
            Console.WriteLine("0u-1u\t=\t{0}", x4 - y4);

            Console.WriteLine("3*2\t=\t{0}", 3 * 2);
            int x5 = 2147483647, y5 = 2;
            Console.WriteLine("2147483647*2\t=\t{0}", x5 * y5);
            Console.WriteLine("2147483647u*2u\t=\t{0}", 2147483647u * 2u);

            Console.WriteLine("6/3\t=\t{0}", 6 / 3);
            Console.WriteLine("6/5\t=\t{0}", 6 / 5);
            Console.WriteLine("6.0/5.0\t=\t{0}", 6.0 / 5.0);

            Console.WriteLine("6%3\t=\t{0}", 6 % 3);
            Console.WriteLine("6%5\t=\t{0}", 6 % 5);

            Console.WriteLine("1<2\t=\t{0}", 1 < 2);
            Console.WriteLine("2<1\t=\t{0}", 2 < 1);
            Console.WriteLine("3<3\t=\t{0}", 3 < 3);
            Console.WriteLine("1>2\t=\t{0}", 1 > 2);
            Console.WriteLine("2>1\t=\t{0}", 2 > 1);
            Console.WriteLine("3>3\t=\t{0}", 3 > 3);

            Console.WriteLine("1<=2\t=\t{0}", 1 <= 2);
            Console.WriteLine("2<=1\t=\t{0}", 2 <= 1);
            Console.WriteLine("3<=3\t=\t{0}", 3 <= 3);
            Console.WriteLine("1>=2\t=\t{0}", 1 >= 2);
            Console.WriteLine("2>=1\t=\t{0}", 2 >= 1);
            Console.WriteLine("3>=3\t=\t{0}", 3 >= 3);

            Console.WriteLine("1==2\t=\t{0}", 1 == 2);
            Console.WriteLine("2==1\t=\t{0}", 2 == 1);
            Console.WriteLine("3==3\t=\t{0}", 3 == 3);

            Console.WriteLine("1!=2\t=\t{0}", 1 != 2);
            Console.WriteLine("2!=1\t=\t{0}", 2 != 1);
            Console.WriteLine("3!=3\t=\t{0}", 3 != 3);

            // is演算（「is」）
            // データの型を判定する演算子
            // 値 is 型名 => true / false
            Console.WriteLine("1 is int\t=\t{0}", 1 is int);
            Console.WriteLine("1.0 is int\t=\t{0}", 1.0 is int);

            // 論理演算（「&」、「^」、「|」）
            // 「&」= AND演算
            // 左辺と右辺どちらもtrueの場合trueを返す
            Console.WriteLine("false&false\t=\t{0}", false & false);
            Console.WriteLine("true&false\t=\t{0}", true & false);
            Console.WriteLine("true&true\t=\t{0}", true & true);

            // 「^」= XOR演算
            // 左辺 or 右辺のどちらかのみtrueの場合trueを返す
            Console.WriteLine("false^false\t=\t{0}", false ^ false);
            Console.WriteLine("true^false\t=\t{0}", true ^ false);
            Console.WriteLine("true^true\t=\t{0}", true ^ true);

            // 「|」= OR演算
            // 左辺、右辺またはその両方ににtrueがある場合trueを返す
            Console.WriteLine("false|false\t=\t{0}", false | false);
            Console.WriteLine("true|false\t=\t{0}", true | false);
            Console.WriteLine("true|true\t=\t{0}", true | true);

            // 条件演算（「~ ? ~: ~」）
            // 式 ? trueの場合返す値 : falseの場合返す値
            // if文の省略形のイメージ
            Console.WriteLine("false ? 1 : 2\t=\t{0}", false ? 1 : 2);
            Console.WriteLine("true ? 1 : 2\t=\t{0}", true ? 1 : 2);

            // 単項演算子（「+」、「-」、「!」、「~」）
            // 「+」値の符号を変えない
            Console.WriteLine("+(2+3)\t=\t{0}", +(2 + 3));
            // 「-」値の符号を反転させる
            Console.WriteLine("-(2+3)\t=\t{0}", -(2 + 3));

            // 「!」trueとfalseを反転させる
            Console.WriteLine("!true\t=\t{0}", !true);
            Console.WriteLine("!false\t=\t{0}", !false);

            Console.WriteLine("★★ ビット演算（ビット表現がわかる人のみ）");
            Console.WriteLine("256>>1\t=\t{0}", 256 >> 1);
            Console.WriteLine("256<<1\t=\t{0}", 256 << 1);

            Console.WriteLine("2147483647>>1\t=\t{0}", 2147483647 >> 1);
            Console.WriteLine("2147483647<<1\t=\t{0}", 2147483647 << 1);

            Console.WriteLine("2147483647u>>1\t=\t{0}", 2147483647u >> 1);
            Console.WriteLine("2147483647u<<1\t=\t{0}", 2147483647u << 1);

            Console.WriteLine("-2147483648>>1\t=\t{0}", -2147483648 >> 1);
            Console.WriteLine("-2147483648<<1\t=\t{0}", -2147483648 << 1);

            Console.WriteLine("1&3\t=\t{0}", 1 & 3);
            Console.WriteLine("1^3\t=\t{0}", 1 ^ 3);
            Console.WriteLine("1|3\t=\t{0}", 1 | 3);

            Console.WriteLine("~1\t=\t{0}", ~1);
            Console.WriteLine("~1u\t=\t{0}", ~1u);
            Console.WriteLine("~-1\t=\t{0}", ~-1);

            Console.WriteLine("★★ 変数の値を変える演算子（ソースと見比べて理解しよう）");
            // インクリメント/デクリメント演算子（「++」、「--」）
            int x = 0; Console.WriteLine("set x=0");
            // 「++x」値の前に置く場合、xの値が利用される前に加算される
            Console.WriteLine("++x\t=\t{0}", ++x);
            Console.WriteLine("++x\t=\t{0}", ++x);
            Console.WriteLine("++x\t=\t{0}", ++x);

            // 「x++」値の後ろに置く場合、xの値が利用した後に加算される
            x = 0; Console.WriteLine("set x=0");
            Console.WriteLine("x++\t=\t{0}", x++);
            Console.WriteLine("x++\t=\t{0}", x++);
            Console.WriteLine("x++\t=\t{0}", x++);

            x = 0; Console.WriteLine("set x=0");
            Console.WriteLine("--x\t=\t{0}", --x);
            Console.WriteLine("--x\t=\t{0}", --x);
            Console.WriteLine("--x\t=\t{0}", --x);

            x = 0; Console.WriteLine("set x=0");
            Console.WriteLine("x--\t=\t{0}", x--);
            Console.WriteLine("x--\t=\t{0}", x--);
            Console.WriteLine("x--\t=\t{0}", x--);

            // 代入演算子（「=」、「+=」、「-=」...）
            x = 0; Console.WriteLine("set x=0");
            Console.WriteLine("x=1\t=\t{0}", x = 1);
            Console.WriteLine("x is now {0}", x);

            x = 1;
            x += 2;
            Console.WriteLine("x=1; x+=2; value of x is {0}", x);
            x = 1;
            x -= 2;
            Console.WriteLine("x=1; x-=2; value of x is {0}", x);
            x = 2;
            x *= 3;
            Console.WriteLine("x=2; x*=3; value of x is {0}", x);
            x = 6;
            x /= 2;
            Console.WriteLine("x=6; x/=2; value of x is {0}", x);
            x = 6;
            x %= 2;
            Console.WriteLine("x=6; x%=2; value of x is {0}", x);
            x = 6;
            x <<= 2;
            Console.WriteLine("x=6; x<<=2; value of x is {0}", x);
            x = 6;
            x >>= 2;
            Console.WriteLine("x=6; x>>=2; value of x is {0}", x);
            x = 1;
            x &= 3;
            Console.WriteLine("x=1; x&=3; value of x is {0}", x);
            x = 1;
            x ^= 3;
            Console.WriteLine("x=1; x^=3; value of x is {0}", x);
            x = 1;
            x |= 3;
            Console.WriteLine("x=1; x|=3; value of x is {0}", x);

            Console.WriteLine("★★ 式を処理しない場合がある演算子（ソースと見比べて理解しよう）");
            x = 0; Console.WriteLine("set x=0");
            Console.WriteLine("returnFalse(x++) && returnFalse(x++)\t=\t{0}", returnFalse(x++) && returnFalse(x++));
            Console.WriteLine("x is now {0}", x);
            x = 0; Console.WriteLine("set x=0");
            Console.WriteLine("returnTrue(x++) && returnTrue(x++)\t=\t{0}", returnTrue(x++) && returnTrue(x++));
            Console.WriteLine("x is now {0}", x);
            x = 0; Console.WriteLine("set x=0");
            Console.WriteLine("returnFalse(x++) || returnFalse(x++)\t=\t{0}", returnFalse(x++) || returnFalse(x++));
            Console.WriteLine("x is now {0}", x);
            x = 0; Console.WriteLine("set x=0");
            Console.WriteLine("returnTrue(x++) || returnTrue(x++)\t=\t{0}", returnTrue(x++) || returnTrue(x++));
            Console.WriteLine("x is now {0}", x);

            return 0;
        }
    }
};