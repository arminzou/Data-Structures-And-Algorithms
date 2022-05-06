using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchingAlgorithm
{
    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }
        public Node(int value)
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }
    }

    public class BinarySearchTree
    {
        public Node Root { get; set; }
        public BinarySearchTree()
        {
            Root = null;
        }
        public void Insert(int value)
        {
            Node newNode = new Node(value);
            if (Root == null)
            {
                Root = newNode;
                return;
            }
            else
            {
                Node currentNode = Root;
                while (true)
                {
                    // Left
                    if (value < currentNode.Value)
                    {
                        if (currentNode.Left == null)
                        {
                            currentNode.Left = newNode;
                            return;
                        }
                        currentNode = currentNode.Left;
                    }
                    // Right
                    else
                    {
                        if (currentNode.Right == null)
                        {
                            currentNode.Right = newNode;
                            return;
                        }
                        currentNode = currentNode.Right;
                    }
                }
            }
        }

        public Node LookUp(int value)
        {
            if (Root == null)
                return null;
            Node currentNode = Root;
            while (currentNode != null)
            {
                if (value < currentNode.Value)
                {
                    currentNode = currentNode.Left;
                }
                else if (value > currentNode.Value)
                {
                    currentNode = currentNode.Right;
                }
                else if (value == currentNode.Value)
                {
                    return currentNode;
                }
            }
            return null;
        }

        public bool Remove(int value)
        {
            if (Root == null)
                return false;

            Node currentNode = Root;
            Node parentNode = null;
            while (currentNode != null)
            {
                if (value < currentNode.Value)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.Left;
                }
                else if (value > currentNode.Value)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.Right;
                }
                else if (currentNode.Value == value)
                {
                    // 1. No right child
                    if (currentNode.Right == null)
                    {
                        if (parentNode == null)
                            Root = currentNode.Left;
                        else
                        {
                            if (currentNode.Value < parentNode.Value)
                            {
                                parentNode.Left = currentNode.Left;
                            }
                            else if (currentNode.Value > parentNode.Value)
                            {
                                parentNode.Right = currentNode.Left;
                            }
                        }
                    }

                    // 2. Right child which doesn't have a left child
                    else if (currentNode.Right.Left == null)
                    {
                        currentNode.Right.Left = currentNode.Left;
                        if (parentNode == null)
                        {
                            Root = currentNode.Right;
                        }
                        else
                        {
                            if (currentNode.Value < parentNode.Value)
                            {
                                parentNode.Left = currentNode.Right;
                            }
                            else if (currentNode.Value > parentNode.Value)
                            {
                                parentNode.Right = currentNode.Right;
                            }
                        }
                    }

                    // 3. Right child that has a left child
                    else
                    {
                        var leftMost = currentNode.Right.Left;
                        var leftMostParent = currentNode.Right;
                        while (leftMost.Left != null)
                        {
                            leftMostParent = leftMost;
                            leftMost = leftMost.Left;
                        }

                        // Parent's left subtree is now leftmost's right subtree
                        leftMostParent.Left = leftMost.Right;
                        leftMost.Left = currentNode.Left;
                        leftMost.Right = currentNode.Right;

                        if (parentNode == null)
                        {
                            this.Root = leftMost;
                        }
                        else
                        {
                            if (currentNode.Value < parentNode.Value)
                            {
                                parentNode.Left = leftMost;
                            }
                            else if (currentNode.Value > parentNode.Value)
                            {
                                parentNode.Right = leftMost;
                            }
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        public List<int> BFS()
        {
            Node currentNode = Root;
            List<int> list = new List<int>();
            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(currentNode);

            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();
                // Console.WriteLine(currentNode.Value);
                list.Add(currentNode.Value);
                if (currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }
                if (currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                }
            }
            return list;
        }

        public List<int> BFSRec(Queue<Node> queue, List<int> list)
        {
            if (queue.Count == 0)
            {
                return list;
            }
            Node currentNode = queue.Dequeue();
            list.Add(currentNode.Value);
            if (currentNode.Left != null)
            {
                queue.Enqueue(currentNode.Left);
            }
            if (currentNode.Right != null)
            {
                queue.Enqueue(currentNode.Right);
            }
            return BFSRec(queue, list);

        }

        // in-order DFS
        public List<int> DFSInOrder()
        {
            List<int> list = new List<int>();
            return traverseInOrder(Root, list);
        }

        // pre-order DFS
        public List<int> DFSPreOrder()
        {
            List<int> list = new List<int>();
            return traversePreOrder(Root, list);
        }

        // post-order DFS
        public List<int> DFSPostOrder()
        {
            List<int> list = new List<int>();
            return traversePostOrder(Root, list);
        }

        private List<int> traverseInOrder(Node node, List<int> list)
        {
            // Console.WriteLine(node.Value);
            if (node.Left != null)
            {
                traverseInOrder(node.Left, list);
            }
            list.Add(node.Value);
            if (node.Right != null)
            {
                traverseInOrder(node.Right, list);
            }
            return list;
        }

        private List<int> traversePreOrder(Node node, List<int> list)
        {
            // Console.WriteLine(node.Value);
            list.Add(node.Value);
            if (node.Left != null)
            {
                traversePreOrder(node.Left, list);
            }

            if (node.Right != null)
            {
                traversePreOrder(node.Right, list);
            }
            return list;
        }

        private List<int> traversePostOrder(Node node, List<int> list)
        {
            // Console.WriteLine(node.Value);
            if (node.Left != null)
            {
                traversePostOrder(node.Left, list);
            }

            if (node.Right != null)
            {
                traversePostOrder(node.Right, list);
            }
            list.Add(node.Value);
            return list;
        }
    }
}


