using System;

namespace Inheritance3_1
{
    // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_004/csharp_abc03.html
    // abstractは抽象を意味する
    // Personは抽象クラスで継承はできるがインスタンスの作成はできない
    public abstract class Person
    {
        // abstractは抽象を意味する
        // 抽象メソッドは中身を書かなくてもエラーにならない
        public abstract string getName();
    }

    public class Taro : Person
    {
        // 抽象メソッドのgetName()を上書き
        // virtualキーワードはないがabstractキーワードがあれば可能
        public override string getName()
        {
            return "My name is Taro";
        }
    }

    class Program
    {
        public static int Main(string[] args)
        {
            // 次の行は抽象クラスのインスタンスを作成しようとするためエラーになる
            // Person person = new Person();　

            Taro taro = new Taro();
            Console.WriteLine(taro.getName());

            Person someone = new Taro();
            Console.WriteLine(someone.getName());
            return 0;
            // 出力結果
            // My name is Taro
            // My name is Taro
        }
    }
}


namespace Inheritance3_2
{
    // // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_004/csharp_abc03.html
    // インターフェースの実装
    // インターフェースの作成
    // 頭に必ず「I」をつけて名前でインターフェースと分かるようにする
    public interface IPerson
    {
        // abstract同様中身のないメソッド
        // interfaceには必ずメソッドを実装する
        string getName();
    }

    public class Taro : IPerson
    {
        public string getName()
        {
            return "My name is Taro";
        }
    }

    class Program
    {
        public static int Main(string[] args)
        {
            // 次の行は抽象クラスのインスタンスを作成しようとするためエラーになる
            // Person person = new Person();　

            Taro taro = new Taro();
            Console.WriteLine(taro.getName());

            IPerson someone = new Taro();
            Console.WriteLine(someone.getName());
            return 0;
            // 出力結果
            // My name is Taro
            // My name is Taro
        }
    }

    /* まとめ
    インターフェイスなどの機能で足りる目的に継承は使わない
    継承するより、オブジェクトをメンバ変数としてクラス内に持つ
    継承関係で依存するクラスは少なければ少ないほど見通しがよくなる
    継承を使う場合でも、使いすぎないように心がける
    */
}