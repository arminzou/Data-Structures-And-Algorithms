# Algorithms

**Algorithms** are just functions that programmers write. It's simply steps in a process that we take to perform a desired action with computers.

## Common Algorithms

- [Algorithms](#algorithms)
  - [Common Algorithms](#common-algorithms)
  - [Recursion](#recursion)
  - [Sorting](#sorting)
    - [When to use which sorting algorithm?](#when-to-use-which-sorting-algorithm)
  - [Non-Comparison Sort](#non-comparison-sort)
  - [List of questions on what type algorithm will you use](#list-of-questions-on-what-type-algorithm-will-you-use)
  - [Searching](#searching)
    - [Trees/Graphs are better than other data structures to store complexy data:](#treesgraphs-are-better-than-other-data-structures-to-store-complexy-data)
    - [Two types of Traversal (visit every node) in tree/graph:](#two-types-of-traversal-visit-every-node-in-treegraph)
    - [**Pro & Cons of Both Traversal**:](#pro--cons-of-both-traversal)
  - [Dynamic Programming](#dynamic-programming)

## Recursion

**Recursion**: A process in which a function calls itself until a specified condition is met.

**Problem with recursion**: The computer needs to allocate memory to remember things, stack overflow can occur when we have recursion and there's no way to stop the recursive call, it will run out of memory.

-   Every recursive function needs to have a **base case** or a stop point.

```
// Time complexity O(n)
function findFactorialIterative(number)
{
    var answer = 1;
    for (var i = number; i > 0; i--) {
        answer = answer * i;
    }
    return answer;
}

// Time complexity O(n)
function findFactorialRecursive(number) {
    if (number === 2) {
        return 2;
    }

    return number * findFactorialRecursive(number - 1);
}

```

```
// O(n)
function fibonacciIterative(n) {
    var arr = [0, 1];
    for (var i = 2; i <= n; i++)
    {
        arr.push(arr[i - 2] + arr[i + 1]);
    }
    return arr[n];
}

// O(2^n) exponential time
function fibonacciRecursive(n) {
    if (n < 2)
    {
        return n;
    }
    return fibonacciRecursive(n - 1) + fibonacciRecursive(n - 2);
}
```

---

## Sorting

-   Bubble Sort $~$ **(Time: O(n^2) Space: O(1) )**
-   Selection Sort $~$ **(Time: O(n^2) Space: O(1) )**
-   Insertion Sort $~$ **(Time: O(n^2) Space: O(1) )**
-   Merge Sort $~$ **(Time: O(nlogn) Space: O(n) )**
-   Quick Sort $~$ **(Time: O(nlogn) Space: O(logn) )**
-   Heap Sort $~$ **(Time: O(nlogn) Space: O(1) )**

### When to use which sorting algorithm?

**Insertion Sort**: Only with a few items and mostly sorted data.

**Merge Sort**: Generally the best, but take in consideration of space complexity of O(n).

**Quick Sort**: Better than Merge Sort if we pick the pivot properly

## Non-Comparison Sort

-   Counting Sort $~$ **(Time: O(n+k) Space: O(k) )**
-   Radix Sort $~$ **(Time: O(nk) Space: O(n+k) )**
-   Bucket Sort $~$ **(Time: O(n^2) Space: O(n) )**

These sorting algorithms are only useful for **fixed length integers**.

## List of questions on what type algorithm will you use

**1. Sort 10 schools aound your house by distance:**

-   insertion sort: Really fast on small inputs, easy to code and it has space complexity of O(1)

**2. eBay sorts listings by the current Big amount:**

-   Radix or Counting sort: Bids are usually a fixed length of integers that are most likely not going to be one hundred million. O(o)

**3. Sport scores on ESPN**

-   Quick Sort: Most efficient, space complexity

**4. Massive database (can't fit all into memory) needs to sort through past year's user data**

-   Merge Sort: Because of the huge data, we really want to ensure the performance

**5. Almost sorted Udemy review data needs to update and add 2 new reviews**

-   Insertion Sort: Almost sorted list, because it will work better tha any other types of sorting with pre-ordered lists

**6. Temperature Records for the past 50 years in Canada**

-   Radix or counting sort: Without decimal
-   Quick Sort: With decimal

**7. Large user name database needs to be sorted. Data is very random.**

-   Merge Sort: Memory is not too expensive
-   Quick Sort: If not worry about worst case

**8. You want to teach sorting for the first time**

-   Bubble Sort, Selection Sort

> **Important Take Away:**
>
> **Use Quick Sort** if your average case performance matters more than the worst case performance because it quicksort allows us to sort in O(nlogn) and worst case O(n^2)
>
> **Merge Sort** is stable, always O(nlogn) although the space complexity is a bit higher
>
> **Insertion Sort** is fast for small list of data

---

## Searching

-   Linear Search
-   Binary Search
-   Depth First Search
-   Breadth First Search

### Trees/Graphs are better than other data structures to store complexy data:

-   O(logn) in searching
-   Insert and Delete has better performance
-   Maintain data in order

### Two types of Traversal (visit every node) in tree/graph:

**Breadth First Search**: Start with root node, move left to right to explore all nodes at the present level then continue to the next level.

**Depth First Search**: Start with root node and explore as far as possible along each branch before backtracking.

### **Pro & Cons of Both Traversal**:

**Breadth First Search**

**Pros**

-   Shortest Path
-   Close Nodes

**Cons**

-   More Memory

**Depth First Search**
**Pros**

-   Less Memory
-   Does Path Exist

**Cons**

-   Can Get Slow

**Traversal Quiz:**
If you know a solution is not far from the root of the tree:

-   BFS: It starts searching the closest nodes to the parent first

If the tree is very deep and solutions are rare:

-   BFS (DFS will take long)

If the tree is very wide:

-   DFS (BFS will need too much memory)

If solutions are frequent but located deep in the tree:

-   DFS

Determining whether a path exists between two nodes:

-   DFS

Finding the shortest path:

-   BFS

Use **Bellman-Ford Algorithm** or **Dijkstra Algorithm** to find shortest path in a weighted graph.

**Bellman-Fort Algorithm** is very effective at solving the shortest path over Dijkstra's algorithm because it can accommodate negative weights.

-   It can take a long time to run in terms of complexity, not the most efficient algorithm
-   Dijkstra's algorithm is faster than Bellman-Fort Algorithm but it can't accommodate for negative weights between nodes

---

## Dynamic Programming

**Dynamic Programming (cache)**: Optimization technique that is a way to solve problems by breanking it down into a collection of problems, solving each of those problems just once and storing their solutions in case next time the same sub problem occurs.

**Caching**: A way to speed up programs and hold some piece of data in an easily accessible box.

**Memoization**: A specific form of caching

When to use Dynamic Programming?
1. Can be divided into subproblem
2. Recursive solution
3. Are there repetitive subproblems
4. Memoize subproblems