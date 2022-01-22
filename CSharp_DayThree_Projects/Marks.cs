using System;
using StudentLibrary;

namespace CSharp_DayThree_Projects
{
    
       public class Marks : Student
        {
            public float ObjectiveMarks, SubjetveMarks;
            public new void AcceptDetails()
            {
                base.AcceptDetails();
                Console.Write("Enter Obejective marks: ");
                this.ObjectiveMarks = float.Parse(Console.ReadLine());
                Console.Write("Enter subjective marks: ");
                this.SubjetveMarks = float.Parse(Console.ReadLine());
            }

            public new void Displaydetails()
            {
                base.Displaydetails();
                Console.WriteLine("Marks Deatils:");
                Console.WriteLine("Obejctive marks : {0}", ObjectiveMarks);
                Console.WriteLine("Subjective marks : {0}", SubjetveMarks);
            }
        }

    }

