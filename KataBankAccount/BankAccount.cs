using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataBankAccount
{
    public class BankAccount
    {
        private int _amount = 0;
        private List<Operation> _operations;


        public BankAccount()
        {
            _operations = new List<Operation>();
        }

        public int GetAmount()
        {
            return _amount;
        }

        public List<Operation> GetRecord()
        {
            return _operations;
        }

        public void Deposit(int amount)
        {
            if (_amount > 0)
            {
                _amount += amount;
                _operations.Add(new Operation(this, "Deposit", amount));
            }
            else
            {
                Console.WriteLine("Negative amount");
            }
        }

        public void Withdraw(int amount)
        {
            if (_amount - amount >= 0)
            {
                _amount -= amount;
                _operations.Add(new Operation(this, "Withdraw", amount));
            }
            else
            {
                Console.WriteLine("Unsufficiant credit");
            }
        }

        public string GetHistory()
        {
            String str = "";
            str += "------------------------------------------ \n";
            str += "--\t Current Balance :\t" + _amount + "\t--\n";
            str += "------------------------------------------ \n";
            foreach (Operation record in _operations)
            {
                str += record.toString();
            }
            return str;
        }

        public override bool Equals(BankAccount other)
        {
            if (_amount == other.GetAmount() && _operations.GetHashCode() == other.GetRecord().GetHashCode())
                return false;
        }

        public override int GetHashCode()
        {
            int result = 17;
            result += _amount.GetHashCode() * 17;
            result += _operations.GetHashCode() * 17;
            return result;
        }

    }
}
