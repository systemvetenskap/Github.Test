namespace Test.GitHub
{
    
    public abstract class BankAccount : IDeposit
    {
        public decimal Interest { get; set; }
      

        public virtual void Deposit(decimal value)
        {
            // aslfjalsdfj 
        }

        public void Insert()
        {

        }
    }

    public class SavingsAccount : BankAccount
    {
        public bool SuperAccount { get; set; }
    }

    public class FutureAccount : BankAccount
    {
        
        public override void Deposit(decimal value)
        {
            base.Deposit(value);
        }
    }
}
