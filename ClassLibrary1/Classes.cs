using System;

namespace ClassLibrary1
{
    public class Class1 
    {
        public string Str { get; private set; }
        public int Num { get; private set; }
        public DateTime Date { get; private set; }
        public Class1(string str, int num, DateTime date)
        {
            Str = str;
            Num = num;
            Date = date;
        }
    }

    public class Class2
    {
        public Class2() // if removed everything works
        { }
        public Class2(string str, int num, DateTime date)
        {
            Str = str;
            Num = num;
            Date = date;
        }
        public string Str { get; private set; } // if remove the private, everything works
        public int Num { get; set; }
        public DateTime Date { get; set; }
    }
}
