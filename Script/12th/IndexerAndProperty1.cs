// https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_012/csharp_abc01.html

namespace IndexerAndProperty1
{
  using System;

  class Class1
  {
    static void Main(string[] args)
    {
      // 【インデクサとは何か】

      string s = "Hello!";

      for (int i = 0; i < s.Length; i++)
      {
        // 文字列にアクセスしているように見えるが、実はインデクサにアクセスしている
        Console.WriteLine(s[i]);
      }
      // 出力結果
      // H
      // e
      // l
      // l
      // o
      // !
    }
  }
}

namespace IndexerAndProperty2
{
  using System;

  class Class1
  {
    static void Main(string[] args)
    {
      // 【インデクサと配列の違い】

      // オブジェクトを配列のように扱いアクセス可能にしている
      char[] a = { 'H', 'e', 'l', 'l', 'o', '!' };
      string s = "Hello!";

      // 配列の最大インデックスを取得する
      Console.WriteLine(a.GetUpperBound(0));
      //Console.WriteLine( s.GetUpperBound(0) );  // 'string' に 'GetUpperBound' の定義がありません。

      // 現在の文字列を大文字にしたもの
      Console.WriteLine(s.ToUpper());
      //Console.WriteLine( a.ToUpper() ); // 'System.Array' に 'ToUpper' の定義がありません。

      Console.WriteLine(s.GetType().FullName);
      Console.WriteLine(a.GetType().FullName);
      // 出力結果
      // 5
      // HELLO!
      // System.String
      // System.Char[]
    }
  }
}