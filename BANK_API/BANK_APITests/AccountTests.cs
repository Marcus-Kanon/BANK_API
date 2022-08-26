using Microsoft.VisualStudio.TestTools.UnitTesting;
using BANK_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_API.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void DepositTest()
        {
            Account.Deposit(20);

            var expected = 20;

            Assert.AreEqual(expected, Account.Balance);
        }

        [TestMethod()]
        public void WithdrawTest()
        {
            Account.Balance = 20;
            Account.Withdraw(20);

            var expected = 0;

            Assert.AreEqual(expected, Account.Balance);
        }

    }
}