// https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_014/csharp_abc06.html

namespace Array1
{
    using System;

    class Class1
    {
        static void Main(string[] args)
        {
            // 【文字配列と文字列の相互変換】


            char[] ar1 = { 'A', 'B', 'C' };

            foreach (char c in ar1)
            {
                Console.WriteLine(c);
            }

            // 配列の要素を文字列としてstrign sに代入
            string s = new string(ar1);
            Console.WriteLine(s);
            // string sをパースして文字の配列を返す
            char[] ar2 = s.ToCharArray();

            foreach (char c in ar2)
            {
                Console.WriteLine(c);
            }
            // 出力結果
            // A
            // B
            // C
            // ABC
            // A
            // B
            // C
        }
    }
}