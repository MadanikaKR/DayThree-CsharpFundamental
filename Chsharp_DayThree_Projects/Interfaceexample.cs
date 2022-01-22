using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chsharp_DayThree_Projects
{

    interface ManageAccount
    {

        void OpenAccount();
        void CloseAccount();
    }

    interface BankAccount
    {
        void deposit();

        void withdraw();
        void balance();
    }

    class Savingccount : ManageAccount, BankAccount
    {
        public void balance()
        {
            Console.WriteLine("balance");
        }

        public void CloseAccount()
        {
            Console.WriteLine("close acc");
        }

        public void deposit()
        {
            Console.WriteLine("deposit");
        }

        public void OpenAccount()
        {
            Console.WriteLine("openacc");
        }

        public void withdraw()
        {
            Console.WriteLine("withdraw");
        }
    }

    class Interfaceexample
    {
        static void Main (string[] args)
        {
            Savingccount savingccount = new Savingccount();

            savingccount.balance();
            savingccount.CloseAccount();
            savingccount.OpenAccount();
            savingccount.withdraw();
            savingccount.deposit();
        }
    }
}    
    


