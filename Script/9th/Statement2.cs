
namespace Statement1
{
    // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_009/csharp_abc02.html

    using System;

    public class Class1
    {
        public static int Main(string[] args)
        {
            // 【分岐】

            if (args.Length != 0)
            {
                Console.WriteLine("yes args");
            }
            else
            {
                Console.WriteLine("no args");
            }

            switch (args.Length)
            {
                case 0:
                    Console.WriteLine("no args");
                    break;
                default:
                    Console.WriteLine("yes args");
                    break;
            }

            switch (args.Length)
            {
                case 0:
                    Console.WriteLine("args=0");
                    break;
                case 1:
                    Console.WriteLine("args=1");
                    goto case 2;
                case 2:
                    Console.WriteLine("args=2");
                    goto default;
                default:
                    Console.WriteLine("yes args");
                    break;
            }

            switch (args[0])
            {
                case "hello":
                    Console.WriteLine("hello!");
                    break;
                default:
                    Console.WriteLine("not hello!");
                    break;
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
            // 【繰り返し】

            int[] ar = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("for ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(ar[i]);
            }
            Console.WriteLine(" done");

            Console.Write("while ");
            int j = 0;
            while (j < 10)
            {
                Console.Write(ar[j]);
                j++;
            }
            Console.WriteLine(" done");

            Console.Write("do ");
            int k = 0;
            do
            {
                Console.Write(ar[k]);
                k++;
            } while (k < 10);
            Console.WriteLine(" done");

            Console.Write("foreach ");
            foreach (int l in ar)
            {
                Console.Write(l);
            }
            Console.WriteLine(" done");

            return 0;
        }
    }
}