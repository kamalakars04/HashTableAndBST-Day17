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
        }
    }
}
