using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 34;
        Console.WriteLine(i);
        char c = 'm';
        Console.WriteLine(c);
        float f = 8.7f;
        Console.WriteLine(f);
        object o = c;
        Console.WriteLine(o);
        string name = "ayush";
        Console.WriteLine(name);
        int counter = i + 1;
        Console.WriteLine(counter);
        if(c=='m')
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}