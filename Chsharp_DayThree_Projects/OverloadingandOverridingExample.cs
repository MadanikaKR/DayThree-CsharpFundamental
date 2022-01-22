using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Chsharp_DayThree_Projects
//{
//    class Calculate
//    {
//        public int Add(int num, int num2)
//        {
//            return num + num2;
//        }

//        public int Add(int n , int M, int O)

//        {
//            return n + M + O;
//        }
//        public float Add(float n1, int M1, int O1)

//        {
//            return n1 + M1 + O1;
//        }


//    }
//    class OverloadingExample
//    {
//        static void Main ()
//        {
//            Calculate cal = new Calculate();
//            Console.WriteLine("cal Add of two int: {0}", cal.Add(1, 2));
//            Console.WriteLine("cal add of three int {0}", cal.Add(1, 1, 1));
//            Console.WriteLine("fload and int {0}", cal.Add(111, 1, 1));
//        }
//    }
//}

//*******************************************************************************************
//Overriding Methods example

//class Person
//{
//    private int personId;
//    private string personName;

//    public Person(int personID, string personname)
//    {
//        this.personId = personID;
//        this.personName = personname;
//    }

//    public void Displaydetails()
//    {
//        Console.WriteLine("Person id: {0}, Name is {1}", this.personId, this.personName);
//    }
//}
//class Employee : Person
//{
//    private float salary;
//    private string designation;

//    public Employee(int PersonID, string Personname, float Salary, string Designation) : base( PersonID,  Personname)
//    {
//        this.salary = Salary;
//        this.designation = Designation;

//    }

//    public void Displaydetails()
//    {
//        base.Displaydetails();
//        Console.WriteLine("\nPerson salary : {0} and designation {1} ",this.salary, this.designation );
//    }
//}

//class Overridingexample
//{
//    static void Main(string[] args)
//    {
//        Employee emp = new Employee(123, "Madhu", 12000, "Manager");
//        emp.Displaydetails();

//        Person per = new Employee(123, "Madhu", 12000, "Manager");
//        per.Displaydetails();
//    }
//}