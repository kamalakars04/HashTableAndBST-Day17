namespace HashTableAndBST
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Text;

    class HashTables
    {
        /// <summary>
        /// MyMapNode class
        /// </summary>
        public class MyMapNode
        {
            // Variables
            public int Value;
            private string key;

            /// <summary>
            /// Gets or sets the key.
            /// </summary>
            /// <value>
            /// The key.
            /// </value>
            /// <exception cref="ArgumentNullException">Key cannot be null</exception>
            [DisallowNull]
            public string Key
            { 
                get 
                { 
                    return key; 
                } 
                set 
                { 
                    key = value ?? throw new ArgumentNullException("Key cannot be null"); 
                } 
            } 

            public MyMapNode(string key)
            {
                this.Key = key;
            }
        }

        // ReadOnly variables
        private readonly int size;
        public readonly LinkedList<MyMapNode>[] linkedlist;

        /// <summary>
        /// Initializes a new instance of the <see cref="HashTables"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        public HashTables(int size)
        {
            this.size = size;
            linkedlist = new LinkedList<MyMapNode>[size];
        }

        /// <summary>
        /// UC 1 Adds the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        public void Add(string key)
        {
            int index = GetArrayIndex(key);
            if(linkedlist[index] == null)
            {
                linkedlist[index] = new LinkedList<MyMapNode>();
            }
            foreach(MyMapNode element in linkedlist[index])
            {
                if (element.Key.Equals(key))
                {
                    element.Value += 1 ;
                    return;
                }
            }
            MyMapNode temp = new MyMapNode(key);
            temp.Value = 1;
            linkedlist[index].AddLast(temp);
        }

        /// <summary>
        /// UC 2 Gets the value.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public int GetValue(string key)
        {
            int index = GetArrayIndex(key);
            if(linkedlist[index] == null)
            {
                Console.WriteLine("The frequency of {0} is {1}", key, 0);
                return 0;
            }
            foreach(MyMapNode element in linkedlist[index])
            {
                if (element.Key.Equals(key))
                {
                    Console.WriteLine("The frequency of {0} is {1}",key, element.Value);
                    return element.Value;
                }
            }
            Console.WriteLine("The frequency of {0} is {1}", key, 0);
            return 0; 
        }

        /// <summary>
        /// Gets the index of the array.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        private int GetArrayIndex(string key)
        {
            int hash = key.GetHashCode();
            int index = hash % size;
            return Math.Abs(index);
        }
    }
}
