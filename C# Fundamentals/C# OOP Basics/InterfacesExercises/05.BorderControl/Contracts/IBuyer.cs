using _05.BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BorderControl.Contracts
{
    public interface IBuyer
    {
        string Name { get; }
        int Food { get; }
        void BuyFood();
    }
}
