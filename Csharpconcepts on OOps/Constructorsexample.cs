//using System;

//namespace Csharpconcepts_on_OOps
//{
//    class Student : iCloneable
//    {
//        //data members
//        public int Studentid;
//        public string STudentName;
//        public int StudentAge;
//        //new data memebr without access modifies a
//        //string universityName;// not a good usage of memory usage for the same value of the member for all students
//        public static string universityName;

//        //static constructo for static members.
//        static Student()
//        {
//            universityName = "Amity Unviversity";
//        }

//        //default contructor
//        public Student()
//        {
//            this.Studentid = 100;
//            this.STudentName = "madhu";
//            this.StudentAge = 21;

//        }
//        //to accept different  input
//        public Student(int StudentID, string STudentName, int STudentage)
//        {
//            this.Studentid = StudentID;
//            this.STudentName = STudentName;
//            this.StudentAge = STudentage;
            
//        }

//        //copy constructor:
//        public Student (Student st)
//        {
//            this.Studentid = st.Studentid;
//            this.STudentName = st.STudentName;
//            this.StudentAge = st.StudentAge;
//        }
//        //member wise cloning fucntion other than copy constructr
//        public object Clone()
//        {
//            return this.MemberwiseClone();
//        }
//        //Member fucntions

//        public void  Displaydetails()
//        {
//            Console.WriteLine("student details:");
//            Console.WriteLine("student id: {0}", this.Studentid);
//            Console.WriteLine("student Name : {0}", this.STudentName);
//            Console.WriteLine("Student Age is {0}", this.StudentAge);
//            //to display static member:
//            Console.WriteLine("Unierstity name : {0}", Student.universityName);
//        }

//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine(Student.universityName= "Madurai ");//can be called using CLass only and if it public //override university name
//            Console.WriteLine("student 1 details");
//            Student student1 = new Student();//defining the object to call STudent's functions.
//            student1.Displaydetails();
//            //creating multiple obejcts to assign different values to data members
//            Console.WriteLine("details of student2");
//            Student student2 = new Student(200, "maddy" , 22);
//           student2.Displaydetails();


//            //Student student3 = new Student(200, "Maddy", 22);
//            //COpy constructors:
//            //Student student3 = new Student();
//            //student3 = student2;//allocation  as student2 refernce variable but when needed as memory allocation:
//            Console.WriteLine("details of student 3");
//            Student student3 = new Student(student2);
//            student3.Displaydetails();
//            Console.WriteLine("details of student 4");
//            Student student4 = student2.Clone() as Student;
//            student4.Displaydetails();
//            Console.ReadLine();
                

//        }
//    }
//}
