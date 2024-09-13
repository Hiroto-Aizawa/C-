// https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_014/csharp_abc05.html

namespace Array1
{
    using System;

    class Class1
    {
        static void Main(string[] args)
        {
            // 【配列のバイナリ・リサーチ】

            // バイナリ・リサーチ
            // ソートされたデータを高速に検索する手法
            int[] ar = { 4, 9, 3, 6, 1, 0 };
            // 配列のソート
            Array.Sort(ar);

            foreach (int n in ar)
            {
                Console.WriteLine(n);
            }

            // 配列arの3が格納されているindexを返す
            int index = Array.BinarySearch(ar, 3);
            Console.WriteLine("index of 3 is {0}", index);
            // 出力結果
            // 0
            // 1
            // 3
            // 4
            // 6
            // 9
            // index of 3 is 2

        }
    }
}

namespace ConsoleApplication81
{
    using System;

    class Class1
    {
        static public int[] makeArray(bool select)
        {
            if (select)
            {
                int[] ar = { 0, 1, 2, 3 };
                return ar;
            }
            else
            {
                int[] ar = { 0, 1 };
                return ar;
            }
        }

        static public void dumpArray(int[] ar)
        {
            foreach (int n in ar)
            {
                Console.WriteLine(n);
            }
        }

        static void Main(string[] args)
        {
            // 【引数と戻り値に使われる配列】

            // 0,1の要素を持つ配列arを宣言
            int[] ar = makeArray(false);
            dumpArray(ar);
            Console.WriteLine();
            // 0,1,2,3の要素を持つ配列arを宣言
            ar = makeArray(true);
            dumpArray(ar);
            // 出力結果
            // 0
            // 1

            // 0
            // 1
            // 2
            // 3
        }
    }
}