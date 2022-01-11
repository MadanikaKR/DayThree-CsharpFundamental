//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpBasics
//{
//    class COnditionalConstructs
//    {
//        static void Main(string[] args)
//        {

//            //    int temp = 19;
//            //    //int temp = 39;
//            //    //int temp = 49;
//            //    if (temp <20)
//            //    {
//            //        Console.WriteLine("its very cold outside");
//            //    }
//            //    if (temp < 30)
//            //    {
//            //        Console.WriteLine("its moderate outside");
//            //    }
//            //    if (temp < 45)
//            //    {
//            //        Console.WriteLine("its very hot outside");
//            //    }
//            //// -------------------------------------------------
//            //         // if elseif else conditions
//            //     int SP = 200, CP = 120;
//            //     //int SP = 100, CP = 100;
//            //     if (SP > CP)
//            //     {
//            //         Console.WriteLine("its profit");
//            //     }
//            //     //if (CP > SP)
//            //     else if (CP > SP)
//            //     {
//            //         Console.WriteLine("its loss");
//            //     }
//            //     else 
//            //     {
//            //         Console.WriteLine("No profit no loss");
//            //     }


//            //     Console.ReadLine();

//            //---------------------------------------------
//            //A user is allowed to make a ourchase when he is logged in, email is verified and cardinfo is valid

//            //    //bool isLoggedIn = false;
//            //    bool isLoggedIn = true;
//            //    //bool IsEmailverified = false;
//            //    bool IsEmailverified = true;
//            //    //bool cardinfo = true;
//            //    bool cardinfo = false;


//            //    if (isLoggedIn)
//            //    {
//            //        Console.WriteLine("Logged in success");
//            //        if (IsEmailverified)
//            //        {
//            //            Console.WriteLine("Email is verified");
//            //            if (cardinfo)
//            //            {
//            //                Console.WriteLine("you can make purchase");
//            //            }
//            //            else
//            //            {
//            //                Console.WriteLine("you cannot make purchase due to card fail");
//            //            }
//            //        }
//            //        else
//            //        {
//            //            Console.WriteLine( "purchase failed due to email wrong");
//            //        }
//            //    }
//            //    else
//            //    {
//            //        Console.WriteLine("purchase failed due to logged in failure");
//            //    }

//            //    //to use && operator instead of nested if's
//            //    if (isLoggedIn && IsEmailverified && cardinfo)
//            //    {
//            //        Console.WriteLine("you can make purchase&&");
//            //    }
//            //    else
//            //    {
//            //        Console.WriteLine("&& failed");
//            //    }


//            //testcase: allow user to access login from email, google, facebook
//            //    bool email = false;
//            //    bool FB = false;
//            //    bool goofle = false;

//            //    if (email || FB || goofle)
//            //    {
//            //        Console.WriteLine("logged in");
//            //    }
//            //    else
//            //    {
//            //        Console.WriteLine("failed to login");
//            //    }
//            //************************************************************

//            ////USE CASE: show user sign out button if auth else show login or sign up button
//            ////second way to write conditional statements latets used liek this 
//            //bool auth = true;
//            //string result =auth ? "signout" : "login button";
//            //Console.WriteLine(result);

//            //*************************************************************************************

//            //USecase: user has access to 1.admin : gets full acess
//            //2. subadmin -gets access to delee/create
//            //3.testprep:gets access to tests
//            //4.User- gets access to content
//            string userType = "admin2";
//            switch (userType)
//            {
//                case "admin":
//                    Console.WriteLine("you get ful access");
//                    break;

//                case "user":
//                    Console.WriteLine("content access");
//                    break;

//                default:
//                    Console.WriteLine("trial access");
//                    break;
//            }


//        }

//    }
//}
