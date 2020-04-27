using System;
using Xunit;
using HashTable.Classes;

namespace HashTableTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddValueToHashTable()
        {
            HashTable.Classes.HashTable hashTable = new HashTable.Classes.HashTable(1);
            hashTable.Add("red", "rojo");
            Assert.Equal("rojo", hashTable.Get("red"));
        }

        [Fact]
        public void CanSearchByKey()
        {
            HashTable.Classes.HashTable hashTable = new HashTable.Classes.HashTable(3);
            hashTable.Add("green", "verde");
            hashTable.Add("yellow", "amarillo");
            hashTable.Add("white", "blanco");
            Assert.Equal("amarillo", hashTable.Get("yellow"));
        }

        [Fact]
        public void ReturnsNullIfKeyNotFound()
        {
            HashTable.Classes.HashTable empty = new HashTable.Classes.HashTable(1);
            Assert.Null(empty.Get("something"));
        }

        [Fact]
        public void HandlesCollisions()
        {
            HashTable.Classes.HashTable onlyOne = new HashTable.Classes.HashTable(1);
            onlyOne.Add("first", "the worst");
            onlyOne.Add("second", "the best!");
            onlyOne.Add("third", "the nerd...");
            Assert.Equal("the best!", onlyOne.Get("second"));
        }

        [Fact]
        public void CanHash()
        {
            HashTable.Classes.HashTable ten = new HashTable.Classes.HashTable(10);
            int[] hashes = new int[]
            {
                ten.Hash("test key"),
                ten.Hash("Sup3rPa55w0rd+ +"),
                ten.Hash("sduebur3988u9834hu2f932n4uc89u3b823ybf8923h89eb238eb892bu38bu9238uedb823ueb89ru238ed2b73yf2b748j92f[23f[]23r3,4][.")
            };

            Assert.All(hashes, hash => Assert.True(hash < 10 && hash >= 0));
        }
    }
}
