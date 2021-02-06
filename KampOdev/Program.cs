using System;

namespace KampOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyDictionary<int, string> students = new MyDictionary<int, string>();
            students.Add(123, "Gamze");
            students.Add(234, "Cemre");
            students.Add(345, "Ecrin");
            students.Add(456, "Tülay");
            students.Add(567, "Özgür");

            students.List();
        }
    }
}
