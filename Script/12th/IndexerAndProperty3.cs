//https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_012/csharp_abc03.html

namespace IndexerAndProperty1
{
    using System;

    class Class2
    {
        private int number;

        // インデクサと似ているが、[]がないためインデクサでないことが分かる
        // これはプロパティ変数のふりをするので、変数同様名前を付けて区別する意味がある
        public string Order
        {
            get
            {
                switch (number)
                {
                    case 1:
                        return "one";
                    case 2:
                        return "two";
                    case 3:
                        return "three";
                    default:
                        return "unknown";
                }
            }
            set
            {
                switch (value)
                {
                    case "one":
                        number = 1;
                        break;
                    case "two":
                        number = 2;
                        break;
                    case "three":
                        number = 3;
                        break;
                    default:
                        number = -1;
                        break;
                }
            }
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            // 【プロパティを使う】

            Class2 t = new Class2();
            // setの処理のvalueにoneが代入される
            t.Order = "one";
            // getの処理で先ほど代入されたoneによって'one'が出力される
            Console.WriteLine(t.Order);
            // 出力結果
            // one
        }
    }
}

namespace IndexerAndProperty2
{
    using System;

    class Class2
    {
        private int number;
        public int Number
        {
            get
            {
                Console.WriteLine("property get called");
                return number;
            }
            set
            {
                Console.WriteLine("property set called");
                number = value;
            }
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            // 【プロパティと+=演算子】
            Class2 t = new Class2();
            // set call
            t.Number = 1;
            // get call
            // set call
            t.Number += 2;// t.Number = t.Number + 2と同じ
            // get call
            Console.WriteLine(t.Number);
            // +=が機能するデータ型のプロパティであれば、+=演算子を使用できる

            // 出力結果
            // property set called
            // property get called
            // property set called
            // property get called
            // 3
        }
    }
}