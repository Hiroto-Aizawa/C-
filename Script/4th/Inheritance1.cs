using System;

namespace Inheritance1
{
    // https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_004/csharp_abc01.html
    // 継承元のクラスはpublicである必要がある（外部クラスからアクセスを受け入れるため）
    // 継承元のクラスをスーパークラスという
    public class Person
    {
        public string getName()
        {
            //return "私には名前がありません。";
            return "I don’t have a name.";
        }
    }

    // Personクラスを継承したサブクラス
    public class Taro : Person
    {
        public string getTaroName()
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
            //Personクラスを継承しているので、getName関数を呼べる
            Console.WriteLine(taro.getName());
            Console.WriteLine(taro.getTaroName());
            return 0;
        }
    }
}