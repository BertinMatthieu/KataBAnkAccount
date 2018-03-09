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
            _amount += amount;
            _operations.Add(new Operation(this, "Deposit", amount));
        }

        public void Withdraw(int amount)
        {
            _amount -= amount;
            _operations.Add(new Operation(this, "Withdraw", amount));
        }

        public string toString()
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
    }
}
