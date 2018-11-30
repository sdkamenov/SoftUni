using _09.CollectionHierarchy.Contracts;
using _09.CollectionHierarchy.Models;
using System;
using System.Collections.Generic;

namespace _09.CollectionHierarchy.Core
{
    public class Engine
    {
        private AddCollection addCollection;
        private AddRemoveCollection addRemoveCollection;
        private MyList myList;
        private List<int> addCollectionResult;
        private List<int> addRemoveCollectionResult;
        private List<int> myListResult;
        private List<List<int>> resultInts;
        private List<string> addRemoveCollectionRemoves;
        private List<string> myListRemoves;
        private List<List<string>> resultStrings;

        public Engine()
        {
            addCollection = new AddCollection();
            addRemoveCollection = new AddRemoveCollection();
            myList = new MyList();


            addCollectionResult = new List<int>();
            addRemoveCollectionResult = new List<int>();
            myListResult = new List<int>();
            resultInts = new List<List<int>>() { addCollectionResult, addRemoveCollectionResult, myListResult };

            addRemoveCollectionRemoves = new List<string>();
            myListRemoves = new List<string>();
            resultStrings = new List<List<string>>() { addRemoveCollectionRemoves, myListRemoves };
        }
        public void Run()
        {
            string[] elements = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            foreach (var element in elements)
            {
                addCollectionResult.Add(addCollection.Add(element));
                addRemoveCollectionResult.Add(addRemoveCollection.Add(element));
                myListResult.Add(myList.Add(element));
            }

            for (int i = 0; i < n; i++)
            {
                addRemoveCollectionRemoves.Add(addRemoveCollection.Remove());
                myListRemoves.Add(myList.Remove());
            }

            foreach (var item in resultInts)
            {
                Console.WriteLine(string.Join(" ", item));
            }
            foreach (var item in resultStrings)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
