namespace HashTableAndBST
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring a new hashtable
            HashTables hashTables = new HashTables(5);

            // Entering the values of hash table
            string input = "To be or not to be";
            string[] sample =input.Split(' ');
            foreach (string s in sample)
                hashTables.Add(s);

             // Trying to get the frequency of a word
             hashTables.GetValue("bee");
        }
    }
}
