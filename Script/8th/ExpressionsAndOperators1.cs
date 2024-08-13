namespace ExpressionsAndOperators1
{
    // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_008/csharp_abc01.html

    using System;

    public class Class1
    {
        // 【C#の演算子】

        //★★ 基本演算（みんな理解しよう）
        2 + 3 = 5
        2147483647 + 1 = -2147483648
        2147483647u + 1u = 2147483648
        4294967295u + 1u = 0
        3 - 2 = 1
        -2147483648 - 1 = 2147483647
        0u - 1u = 4294967295
        3 * 2 = 6
        2147483647 * 2 = -2
        2147483647u * 2u = 4294967294
        6 / 3 = 2
        6 / 5 = 1
        6.0 / 5.0 = 1.2
        6 % 3 = 0
        6 % 5 = 1
        1 < 2 = True
        2 < 1 = False
        3 < 3 = False
        1 > 2 = False
        2 > 1 = True
        3 > 3 = False
        1 <= 2 = True
        2 <= 1 = False
        3 <= 3 = True
        1 >= 2 = False
        2 >= 1 = True
        3 >= 3 = True
        1 == 2 = False
        2 == 1 = False
        3 == 3 = True
        1 != 2 = True
        2 != 1 = True
        3 != 3 = False
        1 is int = True
        1.0 is int = False
        false & false = False
        true & false = False
        true & true = True
        false ^ false = False
        true ^ false = True
        true ^ true = False
        false | false = False
        true | false = True
        true | true = True
        false ? 1 : 2 = 2
        true ? 1 : 2 = 1
        +(2 + 3) = 5
        -(2 + 3) = -5
        !true = False
        !false = True

        //★★ ビット演算（ビット表現がわかる人のみ）
        256 >> 1 = 128
        256 << 1 = 512
        2147483647 >> 1 = 1073741823
        2147483647 << 1 = -2
        2147483647u >> 1 = 1073741823
        2147483647u << 1 = 4294967294
        -2147483648 >> 1 = -1073741824
        -2147483648 << 1 = 0
        1 & 3 = 1
        1 ^ 3 = 2
        1 | 3 = 3
        ~1 = -2
        ~1u = 4294967294
        ~-1 = 0

        //★★ 変数の値を変える演算子（ソースと見比べて理解しよう）
        set x = 0
        ++x = 1
        ++x = 2
        ++x = 3
        set x = 0
        x++ = 0
        x++ = 1
        x++ = 2
        set x = 0
        --x = -1
        --x = -2
        --x = -3
        set x = 0
        x-- = 0
        x-- = -1
        x-- = -2
        set x = 0
        x = 1 = 1
        x is now 1
        x = 1; x += 2; value of x is 3
        x = 1; x -= 2; value of x is -1
        x = 2; x *= 3; value of x is 6
        x = 6; x /= 2; value of x is 3
        x = 6; x %= 2; value of x is 0
        x = 6; x <<= 2; value of x is 24
        x = 6; x >>= 2; value of x is 1
        x = 1; x &= 3; value of x is 1
        x = 1; x ^= 3; value of x is 2
        x = 1; x |= 3; value of x is 3

        //★★ 式を処理しない場合がある演算子（ソースと見比べて理解しよう）
        set x = 0
        returnFalse(x++) && returnFalse(x++) = False
        x is now 1
        set x = 0
        returnTrue(x++) && returnTrue(x++) = True
        x is now 2
        set x = 0
        returnFalse(x++) || returnFalse(x++) = False
        x is now 2
        set x = 0
        returnTrue(x++) || returnTrue(x++) = True
        x is now 1
    }
}

namespace ExpressionsAndOperators2
{
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

            Console.WriteLine("1 is int\t=\t{0}", 1 is int);
            Console.WriteLine("1.0 is int\t=\t{0}", 1.0 is int);

            Console.WriteLine("false&false\t=\t{0}", false & false);
            Console.WriteLine("true&false\t=\t{0}", true & false);
            Console.WriteLine("true&true\t=\t{0}", true & true);

            Console.WriteLine("false^false\t=\t{0}", false ^ false);
            Console.WriteLine("true^false\t=\t{0}", true ^ false);
            Console.WriteLine("true^true\t=\t{0}", true ^ true);

            Console.WriteLine("false|false\t=\t{0}", false | false);
            Console.WriteLine("true|false\t=\t{0}", true | false);
            Console.WriteLine("true|true\t=\t{0}", true | true);

            Console.WriteLine("false ? 1 : 2\t=\t{0}", false ? 1 : 2);
            Console.WriteLine("true ? 1 : 2\t=\t{0}", true ? 1 : 2);

            Console.WriteLine("+(2+3)\t=\t{0}", +(2 + 3));
            Console.WriteLine("-(2+3)\t=\t{0}", -(2 + 3));

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
            int x = 0; Console.WriteLine("set x=0");
            Console.WriteLine("++x\t=\t{0}", ++x);
            Console.WriteLine("++x\t=\t{0}", ++x);
            Console.WriteLine("++x\t=\t{0}", ++x);

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