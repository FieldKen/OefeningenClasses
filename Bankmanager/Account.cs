using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankmanager
{
    enum BankAccountState { Ok, Blocked }
    class Account
    {
        public BankAccountState AccountState { get; private set; } = BankAccountState.Ok;
        private string name = "unknown";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int saldo = 0;
        private string bankAccountNummer = "unknown";

        public string BankAccountNummer
        {
            get { return bankAccountNummer; }
            set { bankAccountNummer = value; }
        }

        public int Withdrawfunds(int value)
        {
            if (AccountState == BankAccountState.Blocked)
                return -1;

            if (value > saldo)
            {
                int terug = saldo;
                saldo = 0;
                return terug;
            }
            else
            {
                saldo -= value;
                return value;
            }
        }

        public int PayInFunds(int value)
        {
            if (AccountState == BankAccountState.Blocked)
                return -1;

            saldo += value;
            return saldo;
        }

        public int GetBalance()
        {
            return saldo;
        }

        public void ChangeState(BankAccountState newState)
        {
            AccountState = newState;
        }
    }
}
