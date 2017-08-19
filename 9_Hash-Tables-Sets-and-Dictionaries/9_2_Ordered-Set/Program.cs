using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2_Ordered_Set
{
    class Program
    {
        static void Main()
        {
            var set = new OrderedSet<int>();
            set.Add(17);
            set.Add(9);
            set.Add(12);
            set.Add(12);
            set.Add(19);
            set.Add(6);
            set.Add(25);
            set.Add(25);

            List<int> nodes = new List<int>();
            set.EachInOrder(nodes.Add);

            foreach (var node in nodes)
            {
                Console.WriteLine(node);
            }
        }
    }
}
