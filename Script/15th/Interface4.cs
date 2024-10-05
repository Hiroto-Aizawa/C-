using System;
using System.Collections;

namespace ConsoleApplication100
{
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