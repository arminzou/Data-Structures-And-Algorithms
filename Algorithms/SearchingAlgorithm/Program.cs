// See https://aka.ms/new-console-template for more information
using SearchingAlgorithm;

var tree = new BinarySearchTree();
tree.Insert(9);
tree.Insert(4);
tree.Insert(6);
tree.Insert(20);
tree.Insert(170);
tree.Insert(15);
tree.Insert(1);

//      9
//   4     20
// 1   6  15  170

// 
// BFS [9, 4, 20, 1, 6, 15, 170]
// Iterative
// var bfsList = tree.BFS();
// Console.WriteLine(string.Join(" ", bfsList));

// Recursive
// Queue<Node> queue = new Queue<Node>();
// queue.Enqueue(tree.Root);
// List<int> list = new List<int>();
// var bfsRecList = tree.BFSRec(queue, list);
// Console.WriteLine(string.Join(" ", bfsRecList));


// DFS
// in-order [1, 4, 6, 9, 15, 20, 170]
var inOrderList = tree.DFSInOrder();
Console.WriteLine(string.Join(" ", inOrderList));

// pre-order [9, 4, 1, 6, 20, 15, 170]
var preOrderList = tree.DFSPreOrder();
Console.WriteLine(string.Join(" ", preOrderList));

// post-order [1, 6, 4, 15, 170, 20, 9]
var postOrderList = tree.DFSPostOrder();
Console.WriteLine(string.Join(" ", postOrderList));