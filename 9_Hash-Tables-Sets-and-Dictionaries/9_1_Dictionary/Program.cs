using System;

namespace _9_1_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Receives input string and counts the occurrences of each character in it.
            string input = Console.ReadLine();
            Dictionary<char, int> Dict = new Dictionary<char, int>();
            foreach (char chr in input) 
            {
                if (Dict.ContainsKey(chr))
                {
                    Dict[chr] = Dict.Get(chr) + 1;
                }
                else
                {
                    Dict.Add(chr, 1);
                }
            }
            foreach(var element in Dict)
            {
                Console.WriteLine(element.Key + " : " + element.Value + " time/s");
            }
        }
    }
}
