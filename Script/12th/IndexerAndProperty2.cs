// https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_012/csharp_abc02.html

namespace IndexerAndProperty1
{
    using System;

    class Class2
    {
        private char[] a = { 'A', 'B', 'C' };

        // インデクサの宣言
        // メソッドと異なり、名前をthisにし、引数を各括弧でくくる
        public char this[int index]
        {
            //インデクサにはプロパティが必要
            get
            {
                return a[index];
            }
            set
            {
                a[index] = value;
            }
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            // 【インデクサを自作する】

            // 
            Class2 t = new Class2();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(t[i]);
            }
            // 出力結果
            // A
            // B
            // C

            // データの上書き
            t[0] = 'X';
            t[1] = 'Y';
            t[2] = 'Z';

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(t[i]);
            }
            // 出力結果
            // X
            // Y
            // Z
        }
    }
}

namespace IndexerAndProperty2
{
    using System;

    class Class2
    {
        private char[] a = { 'A', 'B', 'C' };
        public char this[int index]
        {
            get
            {
                return a[index];
            }
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            Class2 t = new Class2();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(t[i]);
            }
            //t[0] = 'X';   // プロパティまたはインデクサ 'ConsoleApplication41.Class2.this[int]' は読み取り専用なので割り当てることはできません。

            // 出力結果
            // A
            // B
            // C
        }
    }
}