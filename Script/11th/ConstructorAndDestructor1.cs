// https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_011/csharp_abc01.html

namespace ConstructorAndDestructor1
{
    using System;

    class Class2
    {
        // Class2のコンストラクタ
        // クラスメイト同じ名前のメソッド
        // コンストラクタに戻り値は存在しないため、戻り値のデータ型は書かない
        public Class2()
        {
            Console.WriteLine("public Class2()");
        }
    }

    class Class3
    {
        // Class3のコンストラクタ
        // クラスメイト同じ名前のメソッド
        // コンストラクタに戻り値は存在しないため、戻り値のデータ型は書かない
        // 戻り値はないが、引数をつけることは可能
        public Class3(int x, int y)
        {
            Console.WriteLine("public Class3({0},{1})", x, y);
        }
    }

    class Class1
    {
        static void Main(string[] args)
        {
            // 【コンストラクタとは何か？】

            // インスタンスの生成と消滅と密接に関係する機能である
            // コンストラクタはインスタンス生成時に実行されるメソッドの一種

            // インスタンスの生成
            Class2 t1 = new Class2();
            // 引数ありコンストラクタの場合は、newでインスタンス生成時に引数を渡す
            Class3 t2 = new Class3(1, 2);
            // 出力結果
            // public Class2()
            // public Class3(1,2)
        }
    }
}

namespace ConstructorAndDestructor2
{
    using System;

    class Class2
    {
        public Class2()
        {
            Console.WriteLine("public Class2() called");
        }
        public Class2(int x)
        {
            Console.WriteLine("public Class2( int x ) called");
        }
        public Class2(string s)
        {
            Console.WriteLine("public Class2( string s ) called");
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            // 【コンストラクタのオーバーロード】
            
            // オーバーロードは1つのクラスに引数が異なる同名メソッドを扱う機能

            // 1回のnewで実行されるコンストラクタは1つのみ
            Console.WriteLine("new Class2();");
            Class2 t1 = new Class2();
            Console.WriteLine("new Class2( 1 );");
            Class2 t2 = new Class2(1);
            Console.WriteLine("new Class2(( \"Hello!\" );");
            Class2 t3 = new Class2("Hello!");
            // 出力結果
            // new Class2();
            // public Class2() called
            // new Class2( 1 );
            // public Class2( int x ) called
            // new Class2(( "Hello!" );
            // public Class2( string s ) called

        }
    }
}

namespace ConstructorAndDestructor3
{
    using System;

    class Class2
    {
        public Class2()
        {
            Console.WriteLine("public Class2() called");
        }

        // this()は同じクラス内の引数なしコンストラクタを実行するという意味
        public Class2(int x) : this()
        {
            Console.WriteLine("public Class2( int x ) called");
        }

        // this(1)は同じクラス内のint引数ありコンストラクタを実行するという意味
        public Class2(string s) : this(1)
        {
            Console.WriteLine("public Class2( string s ) called");
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            // 【複数コンストラクタの実行】

            Console.WriteLine("new Class2();");
            Class2 t1 = new Class2();
            Console.WriteLine("new Class2( 1 );");
            Class2 t2 = new Class2(1);
            Console.WriteLine("new Class2( \"Hello!\" );");
            Class2 t3 = new Class2("Hello!");
            // 出力結果
            // new Class2();
            // public Class2() called

            // new Class2( 1 );
            // public Class2() called
            // public Class2( int x ) called
            
            // new Class2( "Hello!" );
            // public Class2() called
            // public Class2( int x ) called
            // public Class2( string s ) called

            // stringを呼ぶ際に、this(1)のintのコンストラクタが呼ばれ、
            // intコンストラクタのthis()が呼ばれsddddddddる
        }
    }
}