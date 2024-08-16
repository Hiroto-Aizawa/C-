
namespace Statement1
{
  // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_009/csharp_abc03.html

  using System;

  public class Class1
  {
    public static int Main(string[] args)
    {
      // 【繰り返しのコントロール】

      for (int i = 0; i < 10; i++)
      {
        if (i < 4)
        {
          //以降の処理を打ち切って繰り返しを続行する
          continue;
        }
        if (i == 7)
        {
          //繰り返しから抜ける
          break;
        }
        Console.WriteLine(i);
        // 出力結果
        // 4
        // 5
        // 6
      }
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
      // 【メソッドからの脱出】
      
      for( int i=0; i<10; i++ )
      {
        if( i==7 )
        {
          // returnで繰り返しから抜ける
          return 0;
        }
        Console.WriteLine(i);
        // 出力結果
        // 0
        // 1
        // 2
        // 3
        // 4
        // 5
        // 6
      }
      Console.WriteLine("All Done");
      return 0;
    }
  }
}


namespace Statement3
{
  using System;

  public class Class1
  {
    public static int Main(string[] args)
    {
      // 【オーバーフローチェック】

      int i=1;
      i = i + int.MaxValue;
      Console.WriteLine(i);
      // オーバーフローが発生し、異常な値が表示される
      // -2147483648

      // オーバーフローをチェックしない
      unchecked {
        int j=1;
        j = j + int.MaxValue;
        Console.WriteLine(j);
        // オーバーフローが発生し、異常な値が表示される
        // -2147483648
      }

      // オーバーフローをチェックする
      checked {
        int k=1;
        k = k + int.MaxValue;
        Console.WriteLine(k);
        // 例外が発生する
        // Unhandled Exception:
        // System.OverflowException: Arithmetic operation resulted in an overflow.
        //   at Statement3.Class1.Main (System.String[] args) [0x00022] in <8c8697d0e0494c5cba135756053776de>:0 
        // [ERROR] FATAL UNHANDLED EXCEPTION: System.OverflowException: Arithmetic operation resulted in an overflow.
        //   at Statement3.Class1.Main (System.String[] args) [0x00022] in <8c8697d0e0494c5cba135756053776de>:0 
      }

      return 0;
    }
  }
}


namespace Statement4
{
  using System;

  public class Class1
  {
    public static int Main(string[] args)
    {
      // 【ラベルとジャンプ】

      int i = 1;

      if( i == 1 )
      {
        // x:~の処理に飛ぶ
        goto x;
        // 出力結果
        // with label x
        // with label y
      }
      if( i == 2 )
      {
        // y:~の処理に飛ぶ
        goto y;
        // 出力結果
        // with label y
      }
      Console.WriteLine("without labels");
      x: Console.WriteLine("with label x");
      y: Console.WriteLine("with label y");
      return 0;
    }
  }
}