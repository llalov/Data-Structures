using _3_0_Tree;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_1_Root_Node
{
    public class Program
    {
        //#### Defining methods and storing the data ####
        //#### START ####

        static Dictionary<int, Tree<int>> nodesByValue = new Dictionary<int, Tree<int>>();

        static Tree<int> GetNodesByValue(int value)
        {
            if (!nodesByValue.ContainsKey(value))
            {
                nodesByValue[value] = new Tree<int>(value);
            }
            return nodesByValue[value];
        }

        public static void AddEdge(int parent, int child)
        {
            Tree<int> parentNode = GetNodesByValue(parent);
            Tree<int> childNode = GetNodesByValue(child);

            parentNode.Children.Add(childNode);
            childNode.Parent = parentNode;
        }

        static Tree<int> GetRootNode()
        {
            return nodesByValue.Values.FirstOrDefault(x => x.Parent == null);
        }

        static void ReadTree ()
        {

            int nodeCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < nodeCount; i++)
            {
                string[] edge = Console.ReadLine().Split(' ');
                AddEdge(int.Parse(edge[0]), int.Parse(edge[1]));
            }

        }

        //#### Defining methods and storing the data ####
        //#### END ####

        //#### Main execution and running the program ####
        static void Main()
        {
            ReadTree();
            Tree<int> rootNode = GetRootNode();
            rootNode.Print();
        }
    }
}
