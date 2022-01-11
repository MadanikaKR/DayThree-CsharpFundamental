using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class LoopingCOnstructs
    {
        //static void Main(string[] args)
        //    {
        //    //while (false)
        //    //{
        //    //    Console.WriteLine("never execute");
        //    //}
        //    //while (true)
        //    //{
        //    //    Console.WriteLine("never stops");
        //    //}


        //    }
//************************************************************************************

        //input from user
        //static void Main(string[] args)
        //{
            //bool iNeedmorecandles = true;
            //int candleCount = 0;

            //while (iNeedmorecandles)
            //{
            //    Console.WriteLine("do you need one more candle? (Y/N)");
            //    string answer = Console.ReadLine();

            //    if (answer == "Y")

            //    {
            //        candleCount++;

            //    }
            //    else
            //    {
            //        iNeedmorecandles = false;
            //    }
            //}
            //Console.WriteLine("candles needed : {0}", candleCount);
            //Console.ReadLine();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("print");
            //    i++;
            //}
////***************************************************
//            string answer;
//            int candlecount = 0;
//            do
//            {
//                candlecount++;
//                Console.WriteLine("more?");
//                answer = Console.ReadLine();
//            } while (answer == "yes");
//            Console.WriteLine(candlecount);
//            Console.ReadLine();
        
        //}
//********************************
//Arrays using for loop

        static void Main (string[] args)
        {
            string[] pets = { "dog", "bird", "cats" };
            //for (int i = 0; i < pets.Length; i++)
            //{
            //    Console.WriteLine(pets[i]);
            //}

            foreach (string item in pets)
            {
                Console.WriteLine(item);
            }
        }

   

    }
}
