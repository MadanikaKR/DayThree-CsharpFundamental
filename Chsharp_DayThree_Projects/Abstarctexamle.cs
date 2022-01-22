//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Chsharp_DayThree_Projects
//{
//    abstract class ManageAccount
//    {
//        public void Welcomemsg()
//        {
//            Console.WriteLine("welcome to bank");
//        }
//        public abstract void OpenAccount();
//        public abstract void CloseAccount();
//    }

//   abstract class BankAccount : ManageAccount
//    {
//        public static void transactmsg()
//        {
//            Console.WriteLine("transact in saving account");
//        }
//        public abstract void deposit();

//        public abstract void withdraw();
//        public abstract void balance();
//    }

//    class SavingAccount : BankAccount
//    {
//        public override void balance()
//        {
//            Console.WriteLine("balance from saving account");
//        }

//        public override void CloseAccount()
//        {
//            Console.WriteLine("close saving account");
//        }

//        public override void deposit()
//        {
//            Console.WriteLine("deposit  from saving account");
//        }

//        public override void OpenAccount()
//        {
//            Console.WriteLine("open saving account");
//        }

//        public override void withdraw()
//        {
//            Console.WriteLine("withdraw from saving account");

//        }
//    }

//    class CurrentAccount : BankAccount
//    {
//        public override void balance()
//        {
//            Console.WriteLine("balance from current account");
//        }

//        public override void CloseAccount()
//        {
//            Console.WriteLine("close currenct account");
//        }

//        public override void deposit()
//        {
//            Console.WriteLine("deposit  from current account");
//        }

//        public override void OpenAccount()
//        {
//            Console.WriteLine("open current account");
//        }

//        public override void withdraw()
//        {
//            Console.WriteLine("withdraw from current account");

//        }
//    }
//    class Abstarctexamle
//    {
//        static void Main(String[] args)
//        {
//            BankAccount.transactmsg();
            
//            SavingAccount savingacc = new SavingAccount();
//            savingacc.Welcomemsg();
//            savingacc.balance();
//            savingacc.deposit();
//            savingacc.withdraw();
//            savingacc.CloseAccount();
//            savingacc.OpenAccount();
//            CurrentAccount CA = new CurrentAccount();
//            Console.WriteLine("**************************************88");
//            CA.Welcomemsg();
//            CA.withdraw();
//            CA.balance();
//            CA.deposit();
//            CA.CloseAccount();
//            CA.OpenAccount();


//        }
//    }
//}
