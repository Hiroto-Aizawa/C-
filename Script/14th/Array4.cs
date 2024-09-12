namespace Array1
{
    using System;

    class Class1
    {
        static void Main(string[] args)
        {
            // 【配列をソートする】

            int[] ar = { 4, 1, 3, 2, 0 };
            // ソート関数で並び替える
            Array.Sort(ar);

            foreach (int n in ar)
            {
                Console.WriteLine(n);
            }
            // 出力結果
            // 0
            // 1
            // 2
            // 3
            // 4
        }
    }
}

namespace Array2
{
    using System;

    // インターフェースを継承しているItemクラス
    class Item : IComparable
    {
        public string name;
        public int price;

        public Item(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        // 
        public int CompareTo(object obj)
        {
            int objPrice = ((Item)obj).price;
            int calcPrice = price - objPrice;
            Console.WriteLine($"price: {price} || obj price: {(objPrice)} || calcPrice: {calcPrice}");
            return price - ((Item)obj).price;
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            // 【ソートの条件をカスタマイズする】

            Console.WriteLine("Main Method");

            Item[] ar = {
                new Item("チョコ",50),
                new Item("煎餅",200),
                new Item("飴",10),
                new Item("ポテチ",100)
            };

            Console.WriteLine("before Array.Sort()");

            Array.Sort(ar);

            Console.WriteLine("before foreach()");

            foreach (Item it in ar)
            {
                Console.WriteLine("{0},{1}", it.name, it.price);
            }
            // 出力結果
            // 飴,10
            // チョコ,50
            // ポテチ,100
            // 煎餅,200
        }
    }
}