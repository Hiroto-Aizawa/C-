//https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_014/csharp_abc02.html

using System;

namespace Array1
{
    class Class1
    {
        static void Main(string[] args)
        {
            // 【参照型の配列】

            string[] ar = new string[10];
            for (int i = 0; i < 10; i++)
            {
                // 配列に値を入れる前に参照しようとすると実行時にnullを参照したというエラーになる
                //Console.WriteLine( ar[i].Length );  
            }
            for (int i = 0; i < 10; i++)
            {
                ar[i] = (i * 2).ToString();
            }
            for (int i = 0; i < 10; i++)
            {
                // 配列に値を入れた後は参照エラーにならない
                Console.WriteLine(ar[i].Length);
            }
            // 出力結果
            // 1
            // 1
            // 1
            // 1
            // 1
            // 2
            // 2
            // 2
            // 2
            // 2
        }
    }
}

namespace Array2
{
    using System;

    class Class1
    {
        static void Main(string[] args)
        {
            // 【初期化と省略構文】

            // 配列を宣言する際に、決まった値を入れてしまいたい場合に初期値を指定できる
            // また、宣言の構文には省略構文が存在する

            // 配列の初期化
            int[] ar1 = new int[4] { 0, 1, 2, 3 };
            int[] ar2 = new int[] { 0, 1, 2, 3 };
            // 省略構文
            int[] ar3 = { 0, 1, 2, 3 };

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0},{1},{2}", ar1[i], ar2[i], ar3[i]);
            }
            // 出力結果
            // 0,0,0
            // 1,1,1
            // 2,2,2
            // 3,3,3
        }
    }
}