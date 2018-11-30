using _09.CollectionHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.CollectionHierarchy.Models
{
    public class AddRemoveCollection : IAddable, IRemovable
    {
        private List<string> data;

        public AddRemoveCollection()
        {
            data = new List<string>();
        }

        public int Add(string element)
        {
            data.Insert(0, element);
            return 0;
        }

        public string Remove()
        {
            string element = data.Last();
            data.RemoveAt(data.Count - 1);
            return element;
        }

    }
}
