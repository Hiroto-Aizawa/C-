
using System;

namespace IndexerAndProperty1
{
  class Class1
  {
    static void Main(string[] args)
    {
      string s = "Hello!";
      for (int i = 0; i < s.Length; i++)
      {
        Console.WriteLine(s[i]);
      }
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
      string s = "Hello!";
      char[] a = { 'H', 'e', 'l', 'l', 'o', '!' };
      Console.WriteLine(a.GetUpperBound(0));
      //Console.WriteLine( s.GetUpperBound(0) );  // 'string' に 'GetUpperBound' の定義がありません。
      Console.WriteLine(s.ToUpper());
      //Console.WriteLine( a.ToUpper() ); // 'System.Array' に 'ToUpper' の定義がありません。
      Console.WriteLine(s.GetType().FullName);
      Console.WriteLine(a.GetType().FullName);
    }
  }
}