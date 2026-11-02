// Homework 5: Trees  (starter code)
// 1. Finish every method marked TODO. Use loops, not recursion.
// 2. Write your answers for Questions 1 to 5 in the comment box at the bottom of this file.
// Do not change the tests in Main. Run with: dotnet run
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // ======================= TESTS (do not change) =======================
        var empty = new BinarySearchTree();
        var one = new BinarySearchTree();
        one.Insert(7);
        var t1 = new BinarySearchTree();
        foreach (int v in new[] { 50, 30, 70, 20, 40, 80, 35, 45 }) t1.Insert(v);
        var line = new BinarySearchTree();
        foreach (int v in new[] { 10, 20, 30, 40, 50 }) line.Insert(v);

        Console.WriteLine("== Min ==");
        Console.WriteLine(t1.Min());
        Console.WriteLine(line.Min());
        Console.WriteLine(one.Min());
        Console.WriteLine();

        Console.WriteLine("== Max ==");
        Console.WriteLine(t1.Max());
        Console.WriteLine(line.Max());
        Console.WriteLine(one.Max());
        Console.WriteLine();

        Console.WriteLine("== Depth ==");
        Console.WriteLine(t1.Depth(50));
        Console.WriteLine(t1.Depth(70));
        Console.WriteLine(t1.Depth(35));
        Console.WriteLine(t1.Depth(99));
        Console.WriteLine(line.Depth(50));
        Console.WriteLine(empty.Depth(5));
        Console.WriteLine();
    }
}

// ======================= CLASSES =======================
public class Node
{
    public int Value;
    public Node? Left;
    public Node? Right;
    public Node(int value) { Value = value; }
}

public class BinarySearchTree
{
    private Node? root;
    public Node? Root => root;

    public bool Insert(int value)
    {
        Node newNode = new Node(value);
        if (root == null) { root = newNode; return true; }
        Node temp = root;
        while (true)
        {
            if (newNode.Value == temp.Value) return false;
            if (newNode.Value < temp.Value)
            {
                if (temp.Left == null) { temp.Left = newNode; return true; }
                temp = temp.Left;
            }
            else
            {
                if (temp.Right == null) { temp.Right = newNode; return true; }
                temp = temp.Right;
            }
        }
    }

    public bool Contains(int value)
    {
        Node? temp = root;
        while (temp != null)
        {
            if (value < temp.Value) temp = temp.Left;
            else if (value > temp.Value) temp = temp.Right;
            else return true;
        }
        return false;
    }

    // TODO: return the smallest value in the tree. (You can assume the tree is not empty.)
    public int Min()
    {
        return 0;
    }

    // TODO: return the biggest value in the tree. (You can assume the tree is not empty.)
    public int Max()
    {
        return 0;
    }

    // TODO: return the depth of the node that holds "value".
    //       The root has depth 0. If the value is not in the tree, return -1.
    //       Hint: it works like Contains, but count the steps as you go down.
    public int Depth(int value)
    {
        return 0;
    }
}

/* ======================= WRITTEN ANSWERS (Questions 1 to 5) =======================
   Type your answers here. Draw trees with spaces and slashes, like the trees on the
   assignment page.

   ---- Question 1 ----
   a) root:50
   b) leaves:20, 35, 45, 80
   c) internal nodes:30, 40, 70
   d) parent of 35:40            sibling of 20:40
   e) depth of 35:3             height of node 30:2
   f) height of tree:3          size:9
   g) degree of 70:1
   h) valid BST? why: yes because every node has 0, 1, or 2 children

   ---- Question 2 ----   (Yes / No)
                 Tree A    Tree B    Tree C
   Full?          yes       yes        yes
   Perfect?       no        yes        no
   Complete?      yes       yes        no
   Reasons for each No:
   Trees A and C are not perfect because they both only have 2 out of their 4 possible children in the bottom most layer
   Tree C is not complete because it has children on its right side with there still being open space on the left

   ---- Question 3 ----
   a) tree:              41
                       /    \
                    20        65
                   / \        / \
                 11   29    50   91
                        \       /  \
                         32   72    99

   b) height:3                  number of leaves:4
   c) Contains(32) visits:41, 20, 29, 32              returns:true
      Contains(60) visits:41, 65, 50              returns:false

   ---- Question 4 ----
   a) tree:  10
               \
                20
                  \
                   30
                     \
                      40
                        \
                         50

      height:4
   b) nodes visited by Contains(50):10, 20, 30, 40, 50     Big O: O(n)     acts like: Singly Linked List

   ---- Question 5 ----
   a) tree:              90
                       /    \
                    70        85
                   /  \      / 
                 40    65  80
                /
              30
             /  \
           10    35

   b) children of 70 (show math):
   c) parent of 35 (show math):
   d) why 65 is a leaf (show math):
*/
