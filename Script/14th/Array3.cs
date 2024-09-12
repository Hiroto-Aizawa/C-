// https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_014/csharp_abc03.html

namespace Array1
{
    using System;

    class Class1
    {
        private int n;
        public Class1(int param)
        {
            //メンバ変数のint nを明示
            this.n = param;
        }
        static void Main(string[] args)
        {
            // 【参照型配列の初期化】

            Class1[] ar = new Class1[] { new Class1(1), new Class1(2), new Class1(3) };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(ar[i].n);
            }
            // 出力結果
            // 1
            // 2
            // 3
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
            // 【配列のメソッド】

            int[] ar = { 0, 1, 2, 3, 4 };
            // Array.GetLowerBound(),Array.GetUpperBound() の引数は最初の次元を意味する
            // int i=0; i <= 4; i++と同じ内容を配列のメソッドを利用して実装
            for (int i = ar.GetLowerBound(0); i <= ar.GetUpperBound(0); i++)
            {
                Console.WriteLine(ar[i]);
            }
            // 出力結果
            // 0
            // 1
            // 2
            // 3
            // 4
        }
    }
}


namespace Array3
{
    using System;

    class Class1
    {
        static void Main(string[] args)
        {
            // 【配列をforeachでアクセス】

            int[] ar = { 0, 1, 2, 3, 4 };
            // 配列arからint nとして要素を一つずつ取り出す
            foreach (int n in ar)
            {
                Console.WriteLine(n);
            }
            // 出力結果
            // 0
            // 1
            // 2
            // 3
            // 4
        }
    }
}