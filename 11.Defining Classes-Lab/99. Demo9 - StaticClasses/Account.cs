using System;
using System.Collections.Generic;
using System.Text;

namespace _99._Demo9___StaticClasses
{
    class Account
    {
        public static decimal Tax { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get; set; }
        public void PayTax()
        {
            this.Balance -= Account.Tax;
        }

        
    }
}
