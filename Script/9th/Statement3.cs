
namespace ConsoleApplication15
{
  // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_009/csharp_abc03.html

  using System;

  public class Class1
  {
    public static int Main(string[] args)
    {
      // 繰り返しのコントロール
      
      for (int i = 0; i < 10; i++)
      {
        if (i < 4)
        {
          continue;
        }
        if (i == 7)
        {
          break;
        }
        Console.WriteLine(i);
      }
      return 0;
    }
  }
}
