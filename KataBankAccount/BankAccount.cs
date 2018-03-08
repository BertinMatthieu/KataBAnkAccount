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
        private List<Record> _records;


        public BankAccount()
        {
            _records = new List<Record>();
        }

        public int getAmount()
        {
            return _amount;
        }

        public List<Record> getRecord()
        {
            return _records;
        }

        public void deposit(int amount)
        {
            _amount += amount;
            _records.Add(new Record(this, "Deposit", amount));
        }

        public void withdraw(int amount)
        {
            _amount -= amount;
            _records.Add(new Record(this, "Withdraw", amount));
        }

        public string toString()
        {
            String str = "";
            str += "------------------------------------------ \n";
            str += "--\t Current Balance :\t" + _amount + "\t--\n";
            str += "------------------------------------------ \n";
            foreach (Record record in _records)
            {
                str += record.toString();
            }
            return str;
        }
    }
}
