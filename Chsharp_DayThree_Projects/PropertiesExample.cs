//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Chsharp_DayThree_Projects
//{
//    class Student
//    {
//        private int studentID;
//         private string studentName;
//        private int studentAge;
//        private string city { get; set; }

//        public int StudentId
//        {
//            get { return studentID; }
//           // set { studentID = value; }
//        }

//        public string StudentName
//        {
//            get { return studentName; }
//            set { studentName = value; }
//        }
//        public int StudentAge
//        {
//            get { return studentAge; }
//            set
//            {
//                if (value< 18)
//                {
//                    Console.WriteLine("age is not valid");

//                }
//                else
//                {
//                    studentAge = value;
//                }
//            }
//        }

//        public Student()
//        {
//            this.studentID = 100;
//        }

//        public void DisplayDetails()
//        {
//            Console.WriteLine("age is {0}", studentAge);
//        }
//    }
//    class PropertiesExample
//    {
//        static void Main (string[] args)
//        {
//            Student student = new Student();

//            //student.studentID = 100; private cannot use directly
//            //student.studentName = "Madhu";
//            // hence using through the properties
//            //student.StudentId = 100;
//            student.StudentName = "madhu";
//            student.StudentAge = 17;
            
           
//            Console.WriteLine(" STudent id : {0}", student.StudentId);
//            Console.WriteLine("STudent name: {0}", student.StudentName);
//            Console.WriteLine("student age : {0}", student.StudentAge);
//            Console.ReadKey();

//        }
//    }
//}
