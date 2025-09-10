using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    // A class should only do one jb and have only one reason to change.

    //Single responsinility principle


    //Bad Example
    //public class Employee
    //{
    //    public void GetEmployees()
    //    {

    //    }

    //    public void AddEmployee()
    //    {

    //    }

    //    public void GenerateReport()
    //    {

    //    }
    //    public void GetStudentsList()
    //    {

    //    }
    //}

    // A class should only do one jb and have only one reason to change.
    public class Employee {
        public void GetEmployees()
        {

        }

        public void AddEmployee()
        {

        }
    }


    // A class should only do one jb and have only one reason to change.
    public class ReportGenerator
    {
        public void GenerateReport()
        {

        }
    }

    // A class should only do one jb and have only one reason to change.
    public class Students
    {
        public void GetStudentsList()
        {

        }
    }






}
