//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpBasics
//{
//    class TypeCasting
//    {
//        static void Main (string[] args)
//        {
//            //Console.WriteLine("something");
//            int Variable1 = 100;
//            float fvariable = Variable1;// implicit casting 

//            Console.WriteLine("{0} : {1}", Variable1, fvariable);

//            double doublevariable = 123.45d;
//           //data loss
//            Variable1 = (int )doublevariable;// explicit casting
//            Console.WriteLine("{0} : {1}", Variable1, doublevariable);

//            int num1 = 1;
//            int num2 = 2;
//            int num3 = num1 + num2;
//            Console.WriteLine("{0} + {1}={2}", num1, num2, num3);
            

//            double num11 = 1.5;
//            double num22 = 2.5;
//            //int num33 = num1 + num2;
//           // double num33 =  (num1 + num2);
//            int num33 = (int) (num1 + num2);
//            Console.WriteLine("{0} + {1}={2}", num11, num22, num33);
//            Console.ReadLine();


//            byte  num111 = 100;
//            byte num222 = 200;
//            //int num333 = (num111 + num222);//implicit 
//            byte num333 = (byte)(num111 + num222);
//            Console.WriteLine("{0} + {1}={2}", num111, num222, num333);

//        }
//    }
//}
