namespace HashTableClassModel
{
    using System;
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            // Add elements
            HashTableClass<string, string> hashtable = new HashTableClass<string, string>(5);
            Console.WriteLine("Adding KeyValue pair");
            hashtable.Add("0", "to");
            hashtable.Add("1", "be");
            hashtable.Add("2", "or");
            hashtable.Add("3", "to");
            hashtable.Add("4", "be");
            hashtable.Add("5", "not");

            // Get the value
            Console.WriteLine("getting the value of index 1=" + hashtable.Get("0"));
            Console.WriteLine("getting the value of index 5=" + hashtable.Get("5"));

            // remove at a particular index
            Console.WriteLine("Removing");
            hashtable.Remove("4");
            Console.WriteLine("Displaying");
            hashtable.Display();
            Console.ReadLine();
        }
    }
}
