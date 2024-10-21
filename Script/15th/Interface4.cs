// https://atmarkit.itmedia.co.jp/fdotnet/csharp_abc/csharp_abc_015/csharp_abc04.html

namespace Interface1
{
    using System;
    using System.Collections;
    class ClassSample : IComparable
    {
        public string number;
        public int CompareTo(object obj)
        {
            string s = ((ClassSample)obj).number;
            if (number == "one" && s == "two") return -1;
            if (number == "one" && s == "three") return -1;
            if (number == "two" && s == "one") return 1;
            if (number == "two" && s == "three") return -1;
            if (number == "three" && s == "one") return 1;
            if (number == "three" && s == "two") return 1;
            return 0;
        }
        public ClassSample(string s)
        {
            number = s;
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(new ClassSample("two"));
            al.Add(new ClassSample("three"));
            al.Add(new ClassSample("one"));
            al.Sort();
            foreach (ClassSample cs in al)
            {
                Console.WriteLine(cs.number);
            }
        }
    }
}



namespace Interfaec2
{
    using System;
    using System.Collections;

    class ClassComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            double dx = (double)x;
            double dy = (double)y;
            return (int)dx - (int)dy;
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(2.2);
            al.Add(3.7);
            al.Add(1.5);
            al.Add(2.7);
            al.Add(3.2);
            al.Add(1.1);
            al.Sort(new ClassComparer());
            foreach (double d in al)
            {
                Console.WriteLine(d);
            }
        }
    }
}


namespace Interface3
{
    using System;
    using System.Globalization;

    class ClassSample : IFormattable
    {
        public int x;
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (formatProvider is CultureInfo)
            {
                CultureInfo ci = (CultureInfo)formatProvider;
                if (ci.Name == "ja-JP")
                {
                    switch (x)
                    {
                        case 1:
                            return "一";
                        case 2:
                            return "二";
                        case 3:
                            return "三";
                    }
                }
            }
            return x.ToString();
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            ClassSample cs = new ClassSample();
            cs.x = 3;
            Console.WriteLine(cs);
        }
    }
}