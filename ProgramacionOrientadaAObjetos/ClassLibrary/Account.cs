using System.Text;

namespace ClassLibrary
{
    public class Account
    {
        private string _owner;
        private decimal _amount;

        public Account(string owner, decimal amount)
        {
            _owner = owner;
            _amount = amount;
        }

        public string Owner { get { return _owner; } }
        public decimal Amount { get { return _amount; } set { _amount = value; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Owner: {Owner}");
            sb.AppendLine($"Amount: ${Amount}");

            return sb.ToString();
        }

        public void Deposit(decimal newAmount)
        {
            if (newAmount > 0)
            {
                Amount += newAmount;
            }
        }

        public void Debit(decimal newAmount)
        {
            Amount -= newAmount;
        }
    }
}