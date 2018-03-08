using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataBankAccount
{
    public class Record
    {
        private BankAccount _bankAccount;
        private DateTime _date;
        private string _type;
        private int _amount;

        public Record(BankAccount bankAccount, string type, int amount)
        {
            _bankAccount = bankAccount;
            _amount = amount;
            _type = type;
            _date = DateTime.Today;
        }

        public string toString()
        {
            return "--   " + _date.ToString("dd/MM/yyyy") + "   --\t" + _type + " : " + _amount + "\t--\n";
        }
    }
}
