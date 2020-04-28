# Hashtables
Hashtable class with add, get, contains and hash functions.

## Challenge

Implement a Hashtable that is an array containing key value pairs. those key value pairs should be stored using a hash method to define their index point. If there are collisions and more than one pair gets the same index, they should create a linked list, where the first pair is the first node, and any colliding pairs are attached after. This table should have an add method to add a new pair, a get method that retrieves a value based on a provided key, and a contains method that returns a boolean whether or not a certain key is in the table.

## Approach & Efficiency

- `Add`: Adding is always O(1) time and O(N) space efficiency. Since I didn't have a value type for key-value pairs, I store each in their own 2 index array as a node value. I hash the key, and can add the new node directly to that index.
- `Get`: Although if there is a collision I will have to iterate through an index's linked list, The actual finding of the index in Get is still O(1) time. I set up a current node variable, but change it in place, so it's also O(1) space.
- `Contains`: Actually uses almost identical code to get. It hashes the key, uses that index to retrieve the linked list, and if there's more than one node, searches the linked list until the current node is null or until it finds the searched key. Time is O(1) to find the index. space is O(1) for the node variable.
- `Hash`: Since my hash uses the full key, and iterates through it to create it's returned index, it's O(N) time, but O(1) space, because it uses the one product variable and changes it in place.

## API
- `Add`: takes in both the key and value. This method should hash the key, and add the key and value pair to the table, handling collisions as needed.
- `Get`: takes in the key and returns the value from the table.
- `Contains`: takes in the key and returns a boolean, indicating if the key exists in the table already.
- `Hash`: takes in an arbitrary key and returns an index in the collection.