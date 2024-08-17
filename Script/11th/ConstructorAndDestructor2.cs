// https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_011/csharp_abc02.html

namespace ConstructorAndDestructor1
{
    using System;

    class ClassBase
    {
        public int x1, y1;
        public ClassBase(int x, int y)
        {
            x1 = x;
            y1 = y;
        }
    }
    class ClassDelived : ClassBase
    {
        public int x2, y2;
        public ClassDelived(int x, int y) : base(x + 1, y + 1)
        {
            x2 = x;
            y2 = y;
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            // 【baseクラスのコンストラクタの呼び出し】

            // 継承先のコンストラクタで引数を渡すためには:base()を使用する

            ClassDelived cd = new ClassDelived(10, 20);
            // base(ClassBase)のコンストラクタの実行結果
            Console.WriteLine(cd.x1);
            Console.WriteLine(cd.y1);
            // ClassDelivedのコンストラクタの実行結果
            Console.WriteLine(cd.x2);
            Console.WriteLine(cd.y2);
            // 出力結果
            // 11
            // 21
            // 10
            // 20
        }
    }
}

namespace ConstructorAndDestructor2
{
    using System;

    class Test1
    {
        public int x = 1;
        public Test1()
        {
            Console.WriteLine(x);
        }
    }
    class Test2
    {
        public int x;
        public Test2()
        {
            // この時変数xは初期化されていないためデフォルト値の0となる
            Console.WriteLine(x);
            x = 2;
            Console.WriteLine(x);
        }
    }
    class Test3
    {
        public int x = 1;
        public Test3()
        {
            Console.WriteLine(x);
            x = 2;
            Console.WriteLine(x);
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            // 【メンバ変数の初期化】

            Test1 t1 = new Test1();
            Test2 t2 = new Test2();
            Test3 t3 = new Test3();
            // 出力結果
            // 1
            // 0
            // 2
            // 1
            // 2 
        }
    }
}

namespace ConstructorAndDestructor3
{
    using System;

    class Class2
    {
        // privateな引数なしコンストラクタ
        private Class2() { }

        public static void special(string message)
        {
            Console.WriteLine(message);
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            // 【privateなコンストラクタ】

            Class2.special("Hello!");

            // Class2 t = new Class2();
            // エラーになる 'ConsoleApplication31.Class2.Class2()' はアクセスできない保護レベルになっています。
            // privateなコンストラクタはインスタンスの生成が不可能になる
        }
    }
}

namespace ConstructorAndDestructor4
{
    using System;

    class Class2
    {
        // staticなコンストラクタにはprivate,publicなどのアクセス制御キーワードはつけない
        // 暗黙のうちに実行する以外の選択肢がないため
        static Class2()
        {
            Console.WriteLine("static Class2() called");
        }
        static public void special()
        {
            Console.WriteLine("static public special() called");
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            // 【staticなコンストラクタ】

            // staticなコンストラクタの場合はnewでインスタンスを作成せずに実行可能
            Class2.special();
            // 出力結果
            // static Class2() called
            // static public special() called
        }
    }
}