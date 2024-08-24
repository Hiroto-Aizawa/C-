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
            // getしかないため値を出力する機能しかない
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
            // 【読み出し専用インデクサ】

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

namespace IndexerAndProperty3
{
    using System;
    using System.Collections;

    class Class1
    {
        static void Main(string[] args)
        {
            // 【数値以外で指定するインデクサ】

            // インデクサの[]内の値が整数とは限らない
            // .NET Frameworkに標準で含まれるHashtable(System.Collections.Hashtable)クラスを用いた記述
            Hashtable h = new Hashtable();
            // Hashtableクラスのインデクサは
            // 読み書きする値、添え字もobject型として定義されている
            // 文字列で指定する配列を連想配列という
            h["斉藤"] = "Windows 2000";
            h["田中"] = "Windows 98";
            h["鈴木"] = "FreeBSD";
            Console.WriteLine(h["斉藤"]);
            Console.WriteLine(h["田中"]);
            Console.WriteLine(h["鈴木"]);
            // 出力結果
            // Windows 2000
            // Windows 98
            // FreeBSD
        }
    }
}