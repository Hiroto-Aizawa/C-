
namespace Statement1
{
    // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_009/csharp_abc01.html

    using System;

    public class Class1
    {
        public static int Main(string[] args)
        {
            // 【ブロック】
            // 複数のステートメントを集めて1つのステートメントのように見せる機能

            // ブロックステートメントは{}で閉じるだけ
            int a = 1;
            {
                // 変数bはブロックステートメントの中でのみ使用可能
                int b = 2;
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            Console.WriteLine(a);
            // Console.WriteLine(b); // エラーになる
            // 出力結果
            // 1
            // 2
            // 1
            return 0;
        }
    }
}


namespace Statement2
{
    using System;

    public class Class1
    {
        public static int Main(string[] args)
        {
            // 【変数と定数の宣言】
            //
            int i = 1;
            // constで宣言された変数はローカル定数となる
            // 定数は値を決めたら一切変更できない点に注意
            const int j = 1;
            i = i + 1;
            // j = j + 1;   // エラーになる
            Console.WriteLine(i);
            Console.WriteLine(j);
            return 0;
        }
    }
}