## Big Os

**O(1)** Constant – no loops<br>
**O(log N)** Logarithmic – usually searching algorithms have log n if they are sorted (Binary Search)<br>
**O(n) Linear** – for loops, while loops through n items<br>
**O(n log(n))** Log Linear – usually sorting operations<br>
**O(n^2)** Quadratic – every element in a collection needs to be compared to ever other element. Two nested loops<br>
**O(2^n)** Exponential – recursive algorithms that solves a problem of size N <br>
**O(n!)** Factorial – you are adding a loop for every element <br>
**Iterating through half a collection is still O(n)** <br>
**Two separate collections: O(a \* b)** <br>

## What Can Cause Time in a Function?

Operations **(+, -, \*, /)**<br>
Comparisons **(<, >, ==)**<br>
Looping **(for, while)**<br>
Outside Function call **(function())**<br>

## Rule Book

**Rule 1**: Always worst Case<br>
**Rule 2**: Remove Constants<br>
**Rule 3**:

> - Different inputs should have different variables: **O(a + b)**
> - A and B arrays nested would be: **O(a \* b)**

**+** for steps in order<br>
**\*** for nested steps<br>

**Rule 4**: Drop Non-dominant terms

### What Causes Space Complexity?

• Variables<br>
• Data Structures<br>
• Function Call<br>
• Allocations<br>
