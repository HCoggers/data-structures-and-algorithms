using System;
using System.Collections.Generic;
using System.Text;

namespace LeftJoin.Classes
{
    public class HashTable
    {
        public LinkedList<string[]>[] Buckets { get; set; }

        /// <summary>
        /// Constructor allows you to specify how many indexes your hashtable is
        /// </summary>
        /// <param name="length">the number of indexes in the hash table</param>
        public HashTable(int length)
        {
            Buckets = new LinkedList<string[]>[length];
        }

        /// <summary>
        /// Add a key value pair to the hashtable
        /// </summary>
        /// <param name="key">key to search for</param>
        /// <param name="value">value to be added</param>
        public void Add(string key, string value)
        {
            string[] kvpair = new string[] { key, value };
            int idx = Hash(key);

            if (Buckets[idx] == null)
                Buckets[idx] = new LinkedList<string[]>();
            Buckets[idx].AddLast(kvpair);
        }

        /// <summary>
        /// returns the value of the searched for key, or null if it does not exist.
        /// </summary>
        /// <param name="key">key to search for</param>
        /// <returns>value of key value pair</returns>
        public string Get(string key)
        {
            int idx = Hash(key);
            if (Buckets[idx] == null)
                return null;
            LinkedListNode<string[]> current = Buckets[idx].First;
            while (current != null && current.Value[0] != key)
                current = current.Next;
            if (current != null)
                return current.Value[1];
            else
                return null;
        }

        /// <summary>
        /// returns true or false whether the hashtable contains a key
        /// </summary>
        /// <param name="key">key to search for</param>
        /// <returns>true if key is found or else false</returns>
        public bool Contains(string key)
        {
            int idx = Hash(key);
            if (Buckets[idx] == null)
                return false;
            LinkedListNode<string[]> current = Buckets[idx].First;
            while (current != null && current.Value[0] != key)
                current = current.Next;
            if (current != null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Hashes a provided key into an index slot in the hashtable
        /// </summary>
        /// <param name="key">key to hash</param>
        /// <returns>index to place the key and its value</returns>
        public int Hash(string key)
        {
            char[] chars = key.ToCharArray();
            long product = 1;
            foreach(char c in chars)
            {
                product *= (int)c;
            }
            return (int)(Math.Abs(product) % Buckets.Length);
        }
    }
}
