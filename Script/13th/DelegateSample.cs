// ChatGPT
// └ C#のdelegateを使うべき例をdelegateを使用しない場合と使用する場合を比較して説明してください

//【delegateを使わない場合】
using System;

public class Button
{
    public void Click()
    {
        Console.WriteLine("Button clicked!");
    }
}

public class Program
{
    public static void Main()
    {
        // 問題点

        // 固定された動作: 
        // ButtonクラスのClickメソッドは、
        // クリックされたときに「Button clicked!」と表示するだけです。もしクリックされたときに異なる処理を行いたい場合は、Buttonクラスを変更する必要があります。

        // 拡張性の欠如: 
        // もしボタンをクリックしたときに複数の処理を行いたい場合、
        // Buttonクラスに複数のメソッドを追加するか、もしくは他の方法で管理しなければならなくなります。
        Button button = new Button();
        button.Click();  // ボタンがクリックされた時の動作を直接指定
    }
}

// 【delegateを使う場合】

// delegateはクラスの外側に宣言する
public delegate void ButtonClickHandler();

public class Button
{
    // デリゲート型の変数
    public event ButtonClickHandler OnClick;

    public void Click()
    {
        // クリック時に登録されている全ての処理を実行
        OnClick?.Invoke();
    }
}

public class Program
{
    public static void Main()
    {
        Button button = new Button();

        // クリック時の処理を追加
        button.OnClick += () => Console.WriteLine("Button clicked!");  // 処理1
        button.OnClick += () => Console.WriteLine("Another action!");  // 処理2
        // 柔軟性: 
        // Buttonクラスの内部実装を変更せずに、外部からクリック時の処理を簡単に追加できます。
        // 必要に応じて複数の処理を登録することもできます。

        // 拡張性: 
        // 新しい処理を追加する場合、Buttonクラスのコードを変更することなく、
        // OnClickイベントに新しいメソッドを追加するだけで済みます。

        // 再利用性: 
        // デリゲートを使うことで、同じButtonクラスを使い回し、
        // 異なる処理を外部から簡単に指定できるようになります。

        button.Click();  // ボタンがクリックされた時の動作をデリゲートで管理
    }
}