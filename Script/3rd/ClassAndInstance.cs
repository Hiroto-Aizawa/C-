using System;

namespace ClassAndInstance1
{
    // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_003/csharp_abc02.html
    class Person
    {
        public string name;
        public int age;
    }

    class Sample1
    {
        static void Test()
        {
            //インスタンス化
            Person taro = new Person();
            // このままでは中身がないので変数を初期化する
            taro.name = "taro";
            taro.age = 20;

            //インスタンス化と同時に初期化
            Person hanako = new Person()
            {
                name = "hanako",
                age = 17,
            };

            Console.WriteLine("PersonClass: \n name: {0}, age: {1}", taro.name, taro.age);
            Console.WriteLine("PersonClass: \n name: {0}, age: {1}", hanako.name, hanako.age);
        }

        public static int Main(string[] args)
        {
            Console.WriteLine("ClassAndInstance1のSample1のTest()");
            Sample1.Test();
            return 0;
        }
    }
}

namespace ClassAndInstance2
{
    // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_003/csharp_abc03.html
    // static
    // クラス自身が変数やメソッドを（インスタンス化しなくても）持てるようにする
    class Person
    {
        // staticを付けた変数は実体が1つしか作成されないため、Personクラスを使って2人分の情報を扱う。ということはできない
        public static string name;
        public static int age;
    }

    class Sample2
    {
        // static or インスタンス化をしないで関数を呼ぶとエラーになる
        static void Test()
        {
            // インスタンス化の後に初期化
            Person taro = new Person();
            // static変数はインスタンスではなく、クラスに属するのでtaro.nameではなく、Person.nameと書かなければならない
            Person.name = "taro";
            Person.age = 20;

            Person hanako = new Person();
            // static変数はインスタンスではなく、クラスに属するのでhanako.nameではなく、Person.nameと書かなければならない
            Person.name = "hanako";
            Person.age = 21;

            Console.WriteLine("PersonClass: \n name: {0}, age: {1}", Person.name, Person.age);
            Console.WriteLine("PersonClass: \n name: {0}, age: {1}", Person.name, Person.age);
        }

        // public static int Main(string[] args)
        // {
        //     Console.WriteLine("ClassAndInstance2のSample2のTest()");
        //     Sample2.Test();
        //     return 0;
        // }
    }
}