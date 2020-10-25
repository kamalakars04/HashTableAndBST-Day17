// --------------------------------------------------------------------------------------------------------------------
// <copyright file="fileName.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Your name"/>
// --------------------------------------------------------------------------------------------------------------------

namespace HashTableAndBST
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring a new hashtable
            HashTables hashTables = new HashTables(5);

            // UC 1 Entering the values of hash table
            string input = "To be or not to be";
            string[] sample =input.Split(' ');
            foreach (string s in sample)
                hashTables.Add(s);

            // UC 2 Trying to get the frequency of a word
            hashTables.GetValue("be");
            hashTables.GetValue("To");

            // UC 3 Remove a value
            Console.WriteLine("\nElements and their frequencies before deletion");
            hashTables.Display();
            hashTables.Remove("To");
            Console.WriteLine("\nElements and their frequencies after deletion");
            hashTables.Display();

            // UC 1 Add to BinarySearchTree
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.Add(56);
            binarySearchTree.Add(30);
            binarySearchTree.Add(70);

            // UC 2 To create given tree
            BinarySearchTree<int> binarySearchTreeOne = new BinarySearchTree<int>();
            binarySearchTreeOne.Add(56);
            binarySearchTreeOne.Add(30);
            binarySearchTreeOne.Add(70);
            binarySearchTreeOne.Add(22);
            binarySearchTreeOne.Add(40);
            binarySearchTreeOne.Add(11);
            binarySearchTreeOne.Add(16);
            binarySearchTreeOne.Add(3);
            binarySearchTreeOne.Add(60);
            binarySearchTreeOne.Add(95);
            binarySearchTreeOne.Add(65);
            binarySearchTreeOne.Add(63);
            binarySearchTreeOne.Add(67);

            Console.WriteLine("No of elements in binary search tree are : {0} ",binarySearchTreeOne.Size()); 
        }
    }
}
