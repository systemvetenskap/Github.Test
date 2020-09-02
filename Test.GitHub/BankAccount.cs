namespace Test.GitHub
{
    
    public abstract class BankAccount
    {
        public decimal Interest { get; set; }
      

        public virtual void Deposit(decimal value)
        {

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
