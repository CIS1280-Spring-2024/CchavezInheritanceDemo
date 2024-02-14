using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CchavezInheritanceDemo
{
    //  3.2.	Add an HourlyEmployee class:     
    public class HourlyEmployee : Employee
    {
        public decimal HourlyRate { get; set; }

        public HourlyEmployee() : base()
        {
            HourlyRate = 15.0M;
        }

        //  4.2.	Add the following method to the HourlyEmployee class:
        //  4.2.1.	Notice the override keyword.
        public override string GetPaySummary()
        {
            return "This employee is payed " + HourlyRate + " per hour";
        }
        //  5.1.	Change the HourlyEmployee code to:
        //HourlyEmployee hourEmp = new HourlyEmployee();
        //        hourEmp.EmpNum = 2;
        //hourEmp.FirstName = "Bill";
        //hourEmp.LastName = "Gates";
        //hourEmp.HourlyRate = 15.00M;
        //Console.WriteLine("hourEmp.GetPaySummary: " + hourEmp.GetPaySummary());
        //Employee emp2 = hourEmp;

        //  5.1.1.	Console.WriteLine("emp2.GetPaySummary: " + emp2.GetPaySummary());
        //          Notice that we are assigning an HourlyEmployee object hourEmp into a
        //          variable declared as the base class Employee.

        //  5.1.2.	Before running this code try to predict what emp2.ToString());
        //          and emp2.GetPaySummary()); will display.

        //  5.2.	Try it with Ctrl-F5:
        //  5.2.1.	Notice that despite the fact that emp2 is an Employee class object, GetType(), ToString(), GetPaySummary() methods return the same value as the HourlyEmployee object!
        //  5.2.2.	This is the effect of the override key word.When you override a method, the overridden version of the method is what will be called, no matter what base type variable you assign the object into.

        //  6.1.	In the Hourly Employee class remove the override keywords:
        //public string GetPaySummary()
        //{
        //    return "This employee is payed " + HourlyRate + " per hour";
        //}

        //public string ToString()
        //{
        //    return base.ToString() + " Hourly Employee";
        //}

        //  6.2.	Build the project and notice the warning messages:
        //  6.3.	The warnings occur because we normally want to override class methods. 

        //  6.4.	Try it with Ctrl-F5:
        //  6.5.	Notice that emp2 now calls the ToString() and GetPaySummary() methods from the Employee class and not the HourlyEmployee class. 
        //  6.6.	Method hiding means that the method is only associated with an object when it is in a variable declared of the methods type.
        //  6.7.	In this example, it creates an actual problem, our hourly employees pay information is lost if we do not override these methods! Method hiding is not always a wrong answer however.This is why you have the option to pick which approach you want to use.
        //  6.8.	You can use the new keyword to suppress the warning:
        //new public string GetPaySummary()
        //{
        //    return "This employee is payed " + HourlyRate + " per hour";
        //}

        //new public string ToString()
        //{
        //    return base.ToString() + " Hourly Employee";
        //}

        //  7.2.	Change GetPaySummary() into a property in HourlyEmployee.cs as well:
        //public override string PaySummary
        //{
        //    get { return "This employee is payed " + HourlyRate + " per hour"; }
        //}

    }

}
