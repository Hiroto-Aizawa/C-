
using System;

namespace IndexerAndProperty1
{
  class Class1
  {
    static void Main(string[] args)
    {
      string s = "Hello!";
      for( int i=0; i<s.Length; i++ )
      {
        Console.WriteLine( s[i] );
      }
    }
  }
}