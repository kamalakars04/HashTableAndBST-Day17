// --------------------------------------------------------------------------------------------------------------------
// <copyright file="fileName.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Your name"/>
// --------------------------------------------------------------------------------------------------------------------
namespace HashTableClassModel
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Text;

    public class HashTableClass<K, V>
    {
        /// <summary>
        /// Creates a struct of required node
        /// </summary>
        /// <typeparam name="k"></typeparam>
        /// <typeparam name="v"></typeparam>
        public struct MyMapNode<k, v>
        {
            [DisallowNull]
            public k Key { get; set; }
            public v Value { get; set; }
        }

        // Varaiable declarations
        private readonly int size;
        private readonly LinkedList<MyMapNode<K, V>>[] linkedlist;

        /// <summary>
        /// Initializes a new instance of the <see cref="HashTableClass{K, V}"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        public HashTableClass(int size)
        {
            this.size = size;
            this.linkedlist = new LinkedList<MyMapNode<K, V>>[size];
        }

        /// <summary>
        /// Gets the array position.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        protected int GetArrayPosition(K key)
        {
            int hash = key.GetHashCode();
            int index = hash % size;
            return Math.Abs(index);
        }

        /// <summary>
        /// Gets the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public V Get(K key)
        {
            // Get the index of key using hashcode
            int index = GetArrayPosition(key);

            // Get the linked list of that particular index
            LinkedList<MyMapNode<K, V>> linkedList = GetLinkedList(index);

            // Search for key and return item
            foreach (MyMapNode<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                    return item.Value;
            }

            return default(V);
        }

        /// <summary>
        /// Adds the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void Add(K key, V value)
        {
            // Get the index of key using hashcode
            int index = GetArrayPosition(key);

            // Get the linkedlist of respective index
            LinkedList<MyMapNode<K, V>> linkedList = GetLinkedList(index);

            // Add the element
            MyMapNode<K, V> item = new MyMapNode<K, V>()
            { Key = key, Value = value };
            linkedList.AddLast(item);
            Console.WriteLine(item.Key + " " + item.Value);
        }
        public void Remove(K key)
        {
            // Get the index of key using hashcode
            int index = GetArrayPosition(key);

            // Get the linkedlist of respective index
            LinkedList<MyMapNode<K, V>> linkedList = GetLinkedList(index);
            bool itemFound = false;
            MyMapNode<K, V> foundItem = default(MyMapNode<K, V>);

            // Search for item to be removed
            foreach (MyMapNode<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }

        /// <summary>
        /// Gets the linked list.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns></returns>
        protected LinkedList<MyMapNode<K, V>> GetLinkedList(int position)
        {
            LinkedList<MyMapNode<K, V>> linkedList = linkedlist[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<MyMapNode<K, V>>();
                linkedlist[position] = linkedList;
            }
            return linkedList;
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            // Iterate through all index
            foreach (var linkedList in linkedlist)
            {
                if (linkedList != null)
                {
                    // Iterate through all elements
                    foreach (var element in linkedList)
                    {
                        string res = element.ToString();
                        if (res != null)
                            Console.WriteLine(element.Key + " " + element.Value);
                    }
                }
            }
        }
    }
}

