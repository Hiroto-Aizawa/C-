//https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_012/csharp_abc04.html

namespace IndexerAndProperty1
{
    using System;
    class Sum
    {
        private int sum = 0;
        public int Add
        {
            set { sum += value; }
        }
        public int Result
        {
            get { return sum; }
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            // 【好ましくない使い方】

            Sum sum = new Sum();
            sum.Add = 1;
            // 2を代入しているので1は消えるはず?
            sum.Add = 2;
            // しかし実際は3が出力される
            // ここの処理だけみると詳しい処理が分からない点に注意
            Console.WriteLine(sum.Result);
            // 出力結果
            // 3
        }
    }
}

namespace IndexerAndProperty2
{
    using System;

    class Sum
    {
        private int sum = 0;
        // プロパティと値を増やす処理を切り分ける

        // 値を増やす関数
        public void Add(int number)
        {
            sum += number;
        }

        // プロパティ
        public int Value
        {
            set { sum = value; }
            get { return sum; }
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            // 【プロパティのベターな使い方】

            Sum sum1 = new Sum();
            // 関数を実行しているので変数のような振る舞いをしないことが分かる
            // 関数の処理
            sum1.Add(1);
            sum1.Add(2);
            Console.WriteLine(sum1.Value);
            // 出力結果
            // 3

            Sum sum2 = new Sum();
            // プロパティのデータ型がintなので+=演算子が使える
            // プロパティの処理（set）
            sum2.Value += 1;
            sum2.Value += 2;
            Console.WriteLine(sum2.Value);
            // 出力結果
            // 3
        }
    }
}