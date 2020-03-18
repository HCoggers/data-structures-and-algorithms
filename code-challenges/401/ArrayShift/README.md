# Challenge Summary
Inserts a new value in the center of an array.

## Challenge Description
Create a method called InsertShiftArray that takes an array and a value as arguments,  
and inserts the value in the center index of the array. Do Not use any built in C# methods,  
and make sure to thoroughly unit test your method.

## Approach & Efficiency
- Make new "result" array, one index longer than input
- Use a for loop, with three if/else statements
  - Populate the first half of the array with one if
  - Insert the new value with the next if
  - Populate the rest of the array with the else
- Return the new Altered Array!
I used this approach because it seemed the simplest, step-by-step method right away.
I like to keep all my code connected and chronological, so it would be going against my nature to, say,
Fill in the first value right away, then use two half-size for loops to populate the rest.
Luckily, thanks to the way C# rounds integers, finding the center as it's outlined in our instructions was
fairly straight-forward. just divide the **result** array length by 2, and it'll round down to either the true
center, or the highest closest index from the original array.  

If I understand Big O Notation correctly, this is a pretty efficient approach. With a single for loop, 
based on the length of the input array, it's an O(N) rank method?

## Code
[Go See The Code!](./ArrayShift/Program.cs)

## Solution
![image](../../../assets/ArrayShift.png)
