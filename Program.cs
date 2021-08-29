using System;
using InhertanceDemoWork;

namespace InheritanceDemo
{
    class Program
    {
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
