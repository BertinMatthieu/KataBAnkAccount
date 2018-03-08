using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataBankAccount;

namespace KataBankAccountTest
{
    [TestClass]
    public class UTestKataBankAccount
    {
        [TestMethod]
        public void when_deposit_of_500_account_is_increased_by_500()
        {
            BankAccount bankAccount = new BankAccount();
            int oldAmount = bankAccount.getAmount();

            bankAccount.deposit(500);

            Assert.AreEqual(bankAccount.getAmount() - oldAmount, 500);
        }

        [TestMethod]
        public void when_withdraw_of_500_account_is_decreased_by_500()
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.deposit(500);
            int oldAmount = bankAccount.getAmount();

            bankAccount.withdraw(500);

            Assert.AreEqual(bankAccount.getAmount(), 0);
        }

        [TestMethod]
        public void when_see_history_show_information()
        {
            int amount = 500;
            BankAccount bankAccount = new BankAccount();
            bankAccount.deposit(amount);

            String str = "";
            str += "------------------------------------------ \n";
            str += "--\t Current Balance :\t" + amount + "\t--\n";
            str += "------------------------------------------ \n";
            Record record = new Record(bankAccount, "Deposit", amount);
            str += record.toString();
            Assert.IsTrue(bankAccount.toString().Equals(str));
        }

    }
}
