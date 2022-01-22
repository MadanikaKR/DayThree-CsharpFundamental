using CSharp_DayThree_MarksLibrary;
using System;

namespace CSharp_DayThree_SportLibrary
{
    public class Sports : Marks
    {
        public float score;
        public new void AcceptDetails()
        {
            base.AcceptDetails();
            Console.Write("Enter sport scope: ");
            this.score = float.Parse(Console.ReadLine());
        }
        public new void Displaydetails()
        {
            base.Displaydetails();
            Console.WriteLine("Sports score : {0}", this.score);

        }

    }
}
