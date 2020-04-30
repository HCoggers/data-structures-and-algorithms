using LeftJoin.Classes;
using System;
using System.Collections.Generic;

namespace LeftJoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            HashTable synonyms = new HashTable(5);
            synonyms.Add("fond", "enamored");
            synonyms.Add("wrath", "anger");
            synonyms.Add("diligent", "employed");

            HashTable antonyms = new HashTable(5);
            antonyms.Add("fond", "averse");
            antonyms.Add("wrath", "delight");
            antonyms.Add("guide", "follow");

            string[][] joined = LeftJoin(synonyms, antonyms);

            for (int i = 0; i < joined.Length; i++)
            {
                Console.WriteLine(joined[i][0] + joined[i][1] + joined[i][2]);
            }
        }

        static public string[][] LeftJoin(HashTable synonyms, HashTable antonyms)
        {
            List<string[]> result = new List<string[]>();
            foreach(var b in synonyms.Buckets)
            {
                if(b != null)
                {
                    LinkedListNode<string[]> current = b.First;
                    while (current != null)
                    {
                        result.Add(new string[] { current.Value[0], current.Value[1], "NULL" });
                        current = current.Next;
                    }
                }
            }
            foreach(var k in result)
            {
                if(antonyms.Contains(k[0]))
                    k[2] = antonyms.Get(k[0]);
            }
            return result.ToArray();
        }
    }
}
