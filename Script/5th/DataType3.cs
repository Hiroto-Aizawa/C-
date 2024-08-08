namespace DataType1
{
    // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_005/csharp_abc03.html

    using System;

    public struct Struct1
    {
        // 中身はない
    }

    public class Class1
    {
        public static int Main(string[] args)
        {
            // 【ボクシング(boxing)】

            // objectはクラス。そしてクラスは参照型
            object[] test = new object[5];
            // 本来ならば参照型に値型（整数、実数、文字列、Structs）は代入することができない
            // が、ボクシング（boxing）という機能によって実現されている。
            // 値型の値をobjectなどの参照型に代入しようとすると、値型を包み込むクラスを自動的に挿入される
            // そのため参照型（クラス）として利用できる
            // しかし、元々の値型の値を参照するわけではないことに注意が必要
            test[0] = (int)1;
            test[1] = (float)0.1;
            test[2] = (string)"Hello!";
            // 構造体のインスタンスを作成
            test[3] = new Struct1();
            // クラスのインスタンスを作成
            test[4] = new Class1();

            for (int i = 0; i < test.Length; i++)
            {
                // 配列testの各要素についてデータ型と値を表示する
                Console.WriteLine(
                    "Class={0}, Value={1}", test[i].GetType().FullName, test[i].ToString()
                );
            }

            return 0;
        }
    }
}