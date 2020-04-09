# Find Maximum Value Binary Tree
Create a new BinaryTree instance method that will go through the entire tree, and return the maximum value it contains.

## Challenge
Create a method that traverses a Binary tree and compares every node's value. Then takes the maximum of those values and returns it.

## Approach & Efficiency
Because we have to check every single node in the tree, our Big O time will always be at best O(N), but my Big O space is O(1), because the only variable I create is my max value, I just change it throughout the method. I used an inner private recursive method to check each "root" of each left and right sub treee as the method moves along against the same max, update it if it was bigger, or leave it alone if it was less than or equal to.

### Visual
![image](../../../assets/FindMax.jpg)

[__CHECK OUT THE CODE__](FindMaxTree/Program.cs)
