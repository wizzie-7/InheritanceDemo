using System;


namespace InheritanceDemo
{
    public class Employee
    {
        internal int empid;
        public string fname;
        public string lname;

    }
    public class SoftEng : Employee
    {
        public string Designation;
        public void printSoftEnggDetails()
        {
            empid = 1001;
            fname = "xyz";
            lname = "pqr";
            Console.WriteLine(empid);
            Console.WriteLine(fname);
            Console.WriteLine(lname);
            Designation = "Software Engineer";
            Console.WriteLine(Designation);
        }
    }
    class Program
    {
        
        public class SenSoftEngg : SoftEng
        {
            public void printSenSofEnggTeDetails()
            {
                empid = 10002;
                fname = "abc";
                lname = "lmn";
                Designation = "Senior Software Engineer";
                Console.WriteLine(empid);
                Console.WriteLine(fname);
                Console.WriteLine(lname);

                Console.WriteLine(Designation);

            }

        }
        static void Main(string[] args)
        {
            SoftEng SE = new SoftEng();


            Employee SE1 = new SoftEng();
            SE1.fname = "asd";
            SE1.lname = "lkj";
            //SE1.Designation = "soft engg" // can not call 
            //SE1.printSoftEnggDetails(); // can not call method
            Employee SSE1 = new SenSoftEngg();
            SSE1.fname = "asd";
            SSE1.lname = "lkj";
            //SSE.Designation = "soft engg" // can not call 
            //SSE.printSoftEnggDetails(); // can not call method
            //SoftEng SE2 = new Employee(); //
        }
    }
}
