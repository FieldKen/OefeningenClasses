using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankmanager
{
    class Program
    {
        static void Main(string[] args)
        {
            Account[] bAccount = new Account[10];

            for (int i = 0; i < bAccount.Length; i++)
            {
                bAccount[i] = new Account();
                bAccount[i].Name = $"Account_{i}";
                bAccount[i].PayInFunds(i * 100);
            }

            bAccount[2].PayInFunds(10000);
            bAccount[4].PayInFunds(20000);

            int afTeHalen = 10;
            int effectiefAfgehaald = bAccount[7].Withdrawfunds(afTeHalen);

            if (effectiefAfgehaald == -1)
            {
                Console.WriteLine("Rekening is blocked");
            }
            else
            {
                if (effectiefAfgehaald != afTeHalen)
                {
                    Console.WriteLine($"Saldo ontoereikend. Er is maar {effectiefAfgehaald} afgehaald.");
                }
            }
            bAccount[3].PayInFunds(bAccount[4].Withdrawfunds(2000));
            bAccount[1].ChangeState(BankAccountState.Blocked);

            if (bAccount[1].Withdrawfunds(5) == -1)
            {
                Console.WriteLine("Blocked");
            }

            Console.WriteLine($"3: {bAccount[3].GetBalance()} {bAccount[3].AccountState}");
            Console.ReadLine();
        }
    }
}
