// Program name: CchavezInheritanceDemo
//  Programed by: Colby Chavez
//  Contact email: cchhavez572@cnm.edu
//  Date 2/13/2024
//  Program Goal: Demo of class inheritance

namespace CchavezInheritanceDemo
{
    internal class Program
    {
        //  3.3.	Add the following code to Main in program.cs:
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpNum = 1;
            emp.FirstName = "David";
            emp.LastName = "Bowie";

            HourlyEmployee hourEmp = new HourlyEmployee();
            hourEmp.EmpNum = 2;
            hourEmp.FirstName = "Freddie";
            hourEmp.LastName = "Mercury";
            hourEmp.HourlyRate = 15.00M;

            Employee emp2 = hourEmp;

            //  4.3.    In Program.cs add the following two lines to Main():
            Console.WriteLine("\n\n4.3.");
            Console.WriteLine("emp.GetPaySummary: " + emp.GetPaySummary());
            Console.WriteLine(emp.GetType());Console.WriteLine(emp.GetType());
            Console.WriteLine("hourEmp.GetPaySummary: " + hourEmp.GetPaySummary());
            Console.WriteLine(emp.GetType()); Console.WriteLine(hourEmp.GetType());
            Console.WriteLine("hourEmp.GetPaySummary: " + emp2.GetPaySummary());
            Console.WriteLine(emp.GetType()); Console.WriteLine(emp2.GetType());
            //  4.4.	Run the program
            //  4.5.	Notice which method is called.

            //  7.3.    In Main change the calls to the get methods into calls to the properties:
            Console.WriteLine("\n\n7.3.");
            Console.WriteLine("emp.GetPaySummary: " + emp.PaySummary);
            Console.WriteLine("hourEmp.GetPaySummary: " + hourEmp.PaySummary);
            Console.WriteLine("emp2.GetPaySummary: " + emp2.PaySummary);
            //  7.4.    Try it with Ctrl - F5:
            Console.Write("\nPress any key to continue...");
            Console.ReadLine();
        }



    }
}
