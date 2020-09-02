using System;
using System.Collections.Generic;
using System.Text;

namespace Test.GitHub
{
    public class StandardAccount : IDeposit
    {
        public int Value { get; set; }
        public void Deposit(decimal value)
        {
            throw new NotImplementedException();
        }
    }
}
