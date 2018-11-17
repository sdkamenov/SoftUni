﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _02.BookShop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, decimal price) : base(title, author, price)
        {

        }

        public override decimal Price { get { return base.Price * 1.3m; } set => base.Price = value; }
    }
}
