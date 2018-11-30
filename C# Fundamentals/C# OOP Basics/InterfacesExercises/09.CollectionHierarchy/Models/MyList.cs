using _09.CollectionHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _09.CollectionHierarchy.Models
{
    public class MyList : IAddable, IRemovable, ICountable
    {
        private List<string> data;

        public MyList()
        {
            data = new List<string>();
        }

        public int NumberOfElements
        {
            get
            {
                return data.Count;
            }
        }

        public int Add(string element)
        {
            data.Insert(0, element);
            return 0;
        }

        public string Remove()
        {
            string element = data[0];
            data.RemoveAt(0);
            return element;
        }
    }
}
