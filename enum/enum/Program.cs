using System;

namespace ns
{
    public enum Weekdays
    {
        Sun,Mon,Tue,Wed,Thurs,Fri,Sat
    };
    public enum RGB
    {
        Red,Green,Blue
    };

    class Prog
    {
        static void Main(string[] args)
        {
            Weekdays wd = Weekdays.Tue;
            Console.WriteLine(wd);
            RGB r = RGB.Red;
            Console.WriteLine(r);
        }
    }
}