using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataBankAccount;

namespace KataBankAccountTest
{
    [TestClass]
    public class KataBankAccountTest
    {
        [TestMethod]
        public void should_account_is_increased_by_500_when_deposit_of_500()
        {
            BankAccount bankAccount = new BankAccount();
            int oldAmount = bankAccount.GetAmount();

            bankAccount.Deposit(500);

            Assert.AreEqual(bankAccount.GetAmount() - oldAmount, 500);
        }

        [TestMethod]
        public void should_account_is_decreased_by_500_when_withdraw_of_500()
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.Deposit(500);
            int oldAmount = bankAccount.GetAmount();

            bankAccount.Withdraw(500);

            Assert.AreEqual(bankAccount.GetAmount(), 0);
        }

        [TestMethod]
        public void should_have_date_type_of_operation_and_amount_when_create_operation()
        {
            int amount = 500;
            string type = "Deposit";
            BankAccount bankAccount = new BankAccount();
            string str = "--   " + DateTime.Today.ToString("dd/MM/yyyy") + "   --\t" + type + " : " + amount + "\t--\n";

            Operation operation = new Operation(bankAccount, "Deposit", amount);

            Assert.IsTrue(operation.toString().Equals(str));
        }

        [TestMethod]
        public void should_show_information_when_see_history()
        {
            int amount = 500;
            BankAccount bankAccount = new BankAccount();
            bankAccount.Deposit(amount);

            String str = "";
            str += "------------------------------------------ \n";
            str += "--\t Current Balance :\t" + amount + "\t--\n";
            str += "------------------------------------------ \n";
            Operation operation = new Operation(bankAccount, "Deposit", amount);
            str += operation.toString();
            Assert.IsTrue(bankAccount.toString().Equals(str));
        }

    }
}
