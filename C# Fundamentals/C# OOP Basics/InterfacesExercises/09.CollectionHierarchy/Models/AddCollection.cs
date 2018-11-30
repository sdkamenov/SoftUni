using _09.CollectionHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _09.CollectionHierarchy.Models
{
    public class AddCollection : IAddable
    {
        private List<string> data;

        public AddCollection()
        {
            this.data = new List<string>();
        }

        public int Add(string element)
        {
            data.Add(element);
            return data.LastIndexOf(element);
        }
    }
}
