using CSharp_DayThree_SportLibrary;
using System;

namespace CSharp_DayThree_Results
{
    public class Results : Sports
    {
        float Totalmarks, AverageMarks;

        public void calculate()
        {
            this.Totalmarks = this.ObjectiveMarks + this.SubjetveMarks + this.score;
            Console.WriteLine("Total marks :" + this.Totalmarks);
            this.AverageMarks = this.Totalmarks / 3;
            Console.WriteLine("AVerage marks : {0}", AverageMarks);
        }
    }
}
