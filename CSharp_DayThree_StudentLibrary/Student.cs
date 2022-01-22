using System;

namespace CSharp_DayThree_StudentLibrary
{
    public class Student
    {
        //data members
        public int Studentid;
        public string STudentName;
        public int StudentAge;
        //new data memebr without access modifies a
        //string universityName;// not a good usage of memory usage for the same value of the member for all students
        public static string universityName;

        //static constructo for static members.
        static Student()
        {
            universityName = "Amity Unviversity";
        }

        //Member fucntions
        public void AcceptDetails()
        {
            Console.WriteLine("Enter the details");
            Console.Write("Enter Student id: ");
            this.Studentid = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            this.STudentName = Console.ReadLine();
            Console.WriteLine("Enter the student Age : ");
            this.StudentAge = int.Parse(Console.ReadLine());
        }

        public void Displaydetails()
        {
            Console.WriteLine("student details:");
            Console.WriteLine("student id: {0}", this.Studentid);
            Console.WriteLine("student Name : {0}", this.STudentName);
            Console.WriteLine("Student Age is {0}", this.StudentAge);
            //to display static member:
            Console.WriteLine("Unierstity name : {0}", Student.universityName);
        }

    }

}
