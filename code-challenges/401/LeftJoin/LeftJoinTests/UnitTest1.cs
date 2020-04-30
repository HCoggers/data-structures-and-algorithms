using LeftJoin.Classes;
using LeftJoin;
using System;
using Xunit;

namespace LeftJoinTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanJoinTables()
        {
            HashTable synonyms = new HashTable(5);
            synonyms.Add("fond", "enamored");
            synonyms.Add("wrath", "anger");
            synonyms.Add("diligent", "employed");

            HashTable antonyms = new HashTable(5);
            antonyms.Add("fond", "averse");
            antonyms.Add("wrath", "delight");
            antonyms.Add("diligent", "idle");

            string[][] joined = Program.LeftJoin(synonyms, antonyms);

            string[][] expected =
                {
                    new string[] { "fond", "enamored", "averse" },
                    new string[] { "diligent", "employed", "idle" } ,
                    new string[] { "wrath", "anger", "delight" }
                };

            Assert.Equal(expected, joined);
        }

        [Fact]
        public void CanJoinUneven()
        {
            HashTable synonyms = new HashTable(5);
            synonyms.Add("fond", "enamored");
            synonyms.Add("wrath", "anger");
            synonyms.Add("diligent", "employed");

            HashTable antonyms = new HashTable(5);
            antonyms.Add("fond", "averse");
            antonyms.Add("hot", "cold");
            antonyms.Add("guide", "follow");

            string[][] joined = Program.LeftJoin(synonyms, antonyms);

            string[][] expected =
                {
                    new string[] { "fond", "enamored", "averse" },
                    new string[] { "diligent", "employed", "NULL" } ,
                    new string[] { "wrath", "anger", "NULL" }
                };

            Assert.Equal(expected, joined);
        }

        [Fact]
        public void CanJoinEmpty()
        {
            HashTable synonyms = new HashTable(5);

            HashTable antonyms = new HashTable(5);

            string[][] joined = Program.LeftJoin(synonyms, antonyms);

            string[][] expected = new string[0][];

            Assert.Equal(expected, joined);
        }

        [Fact]
        public void CanJoinSingle()
        {
            HashTable synonyms = new HashTable(1);
            synonyms.Add("fond", "enamored");

            HashTable antonyms = new HashTable(1);
            antonyms.Add("fond", "averse");

            string[][] joined = Program.LeftJoin(synonyms, antonyms);

            string[][] expected =
                {
                    new string[] { "fond", "enamored", "averse" }
                };

            Assert.Equal(expected, joined);
        }
    }
}
