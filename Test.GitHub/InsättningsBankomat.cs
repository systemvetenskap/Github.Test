using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Test.GitHub
{
    public class InsättningsBankomat 
    {
        private IDeposit account;

        public IDeposit MyAccount { get; set; }

        private void DoStuff()
        {
          
        }

        public InsättningsBankomat(IDeposit account)
        {
            this.account = account;
            
        }

        public void SetAccount(IDeposit account)
        {
            this.account = account;
        }

        // Dependency injection

        // via konstruktor
        // via property
        // via Metod

        // dependecy inversion

    }
}
