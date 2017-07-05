using System;

namespace _6_1_Exercise_First_Last_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            FirstLastList<int> list = new FirstLastList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Console.WriteLine();
        }
    }
}
