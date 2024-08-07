namespace DataType1
{
    // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_005/csharp_abc02.html
    // ClassとStructの違いは値型か、参照型かという機能面の違いにある

    // 【値型】情報を引き渡す際に情報をコピーするデータ型のこと
    // メリット：小さいデータを扱い際にはコピーの方が早い
    // デメリット：毎回コピー処理が走るので、大きいデータを扱うのには処理効率が悪い（速度低下につながる）

    // 【参照型】：データの実体がある場所を保存しておき、情報を引き渡す際はコピーせず、データの場所だけ伝えて参照してもらう方式
    // メリット：大きなデータを扱う場合にコピー処理が無いので処理効率が良い
    // デメリット：小さいデータを扱う場合は、データの場所を渡す処理が回りくどい（効率が悪い）

    //値型と参照型でどれくらい処理効率の差があるかを試す

    using System;

    // クラスの場合
    public class Test
    {
        public int v;
    }
    public class Class1
    {
        // public static int Main(string[] args)
        // {
        //     // 【値型】
        //     Console.WriteLine(DateTime.Now);
        //     int count = 10000000;
        //     // クラスを用いる場合、1個のインスタンスは、1つの独立したメモリ領域として確保される。
        //     // つまり、メモリ確保という処理が1000万回実行されるのである。
        //     Test[] test = new Test[count];
        //     for (int i = 0; i < count; i++)
        //     {
        //         test[i] = new Test();
        //         test[i].v = i;
        //     }

        //     int sum = 0;

        //     for(int i=0; i<count; i++){
        //         sum += test[i].v;
        //     }

        //     Console.WriteLine(DateTime.Now);
        //     // 出力結果
        //     // 08/07/2024 08:54:03
        //     // 08/07/2024 08:54:08

        //     return 0;
        // }
    }
}

namespace DataType2
{
    // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_005/csharp_abc02.html

    using System;

    // 構造体の場合
    public struct Test
    {
        public int v;
    }
    public class Class1
    {
        public static int Main(string[] args)
        {
            // 【参照型】
            Console.WriteLine(DateTime.Now);
            int count = 10000000;
            // Structsの場合は、配列を作成した時点で、1000万個分のStructsを納めるたった1個の巨大なメモリを確保している。
            Test[] test = new Test[count];
            for (int i = 0; i < count; i++)
            {
                // 構造体のためインスタンス化せずともエラーにならない
                //test[i] = new Test();
                test[i].v = i;
            }

            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += test[i].v;
            }

            Console.WriteLine(DateTime.Now);
            // 出力結果
            // 08/07/2024 09:31:09
            // 08/07/2024 09:31:09

            return 0;
        }
    }
}