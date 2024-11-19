using System;

namespace Inheritance2
{
    // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_004/csharp_abc02.html
    // 継承元のクラスはpublicである必要がある（外部クラスからアクセスを受け入れるため）
    // 継承元のクラスをスーパークラスという
    public class Person
    {
        public string getName()
        {
            //return "私には名前がありません。";
            return "I don't have a name.";
        }
    }

    // Personクラスを継承したサブクラス
    public class Taro : Person
    {
        // 継承したクラスの同名メソッドの中身を置き換える
        // newキーワードを使用する
        public new string getName()
        {
            // return "私の名前は太郎です。";
            return "My name is Taro.";
        }
    }

    public class Class1
    {
        public static int Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.getName());

            // Personクラスを継承したTaroクラスをインスタンス化
            Taro taro = new Taro();
            //Taroクラスで新たに定義したgetName関数を呼ぶ
            Console.WriteLine(taro.getName());

            // Person型のsomeoneにTaroクラスのインスタンスを作成し、格納する
            // この場合、TaroクラスのgetName関数ではなく、PersonクラスのgetName関数が呼ばれる
            // newキーワードを用いた置き換えは万能ではない
            Person someone = new Taro();
            Console.WriteLine(someone.getName());

            return 0;
            // 出力結果
            // I don't have a name.
            // My name is Taro.
            // I don't have a name.
        }
    }
}

namespace Inheritance3
{
    // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_004/csharp_abc02.html
    // 継承元のクラスはpublicである必要がある（外部クラスからアクセスを受け入れるため）
    // 継承元のクラスをスーパークラスという
    public class Person
    {
        // virtualキーワードとoverrideキーワードは対になって意味がある
        // サブクラスで継承した機能を根本的に置き換えるために使用する
        public virtual string getName()
        {
            //return "私には名前がありません。";
            return "I don't have a name.";
        }
    }

    // Personクラスを継承したサブクラス
    public class Taro : Person
    {
        // overrideキーワードを使用して継承したクラスの同名メソッドの中身を根本的に置き換える
        // スーパークラスにvirtualキーワードがないと置き換えができないので注意
        public override string getName()
        {
            // return "私の名前は太郎です。";
            return "My name is Taro.";
        }
    }

    public class Class1
    {
        public static int Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.getName());

            // Personクラスを継承したTaroクラスをインスタンス化
            Taro taro = new Taro();
            //Taroクラスで置き換えらgetName関数を呼ぶ
            Console.WriteLine(taro.getName());

            // Person型のsomeoneにTaroクラスのインスタンスを作成し、格納する
            // この場合、overrideによって置き換えられたTaroクラスのgetName関数が呼ばれる
            Person someone = new Taro();
            Console.WriteLine(someone.getName());

            return 0;
            // 出力結果
            // I don't have a name.
            // My name is Taro.
            // My name is Taro.
        }
    }
}

