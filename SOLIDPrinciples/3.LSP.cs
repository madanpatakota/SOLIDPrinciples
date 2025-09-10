using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.LOP
{

    //If class B is a child class of A then members of Class B should be able to
    //replace teh members of Class A without breaking of program


    /// A subclass shold beahave like its parent
    /// A subclass should not change the rules and expetations of the parent(class or interface).
    /// 


    //parent class
    //public class Employee
    //{
    //    public virtual double getBonus(double salary)
    //    {
    //        return salary * 0.1;
    //    }
    //}
    ////subclass or child class
    //public class contractEmployee : Employee
    //{

    //    //abc consultancy -> campgenmin

    //    // 1 year 

    //    // Contract empo should not get the bonou
    //    public override double getBonus(double salary)
    //    {
    //        throw new NotImplementedException("i Cannot implemnet because bonus i cannot do");
    //        //return base.getBonus(salary);
    //    }
    //}
    //public class Program
    //{
    //    static void Main()
    //    {
    //        Employee employee = new contractEmployee();
    //        employee.getBonus(1000);
    //    }
    //}




    //-----------------------------------------------------------------------------


    public interface IEmployee
    {
        double GetSalary();

    }

    public class PerminentEmployee : IEmployee
    {

        private double basicSalary;

        public PerminentEmployee(double salary)
        {
            basicSalary = salary;
        }
        public double GetSalary()
        {
            //throw new NotImplementedException();
            double bonus = basicSalary * 0.1;
            return basicSalary + bonus;
        }
    }

    public class ContractEmployee : IEmployee
    {

        private double basicSalary;

        public ContractEmployee(double salary)
        {
            basicSalary = salary;
        }
        public double GetSalary()
        {
            //throw new NotImplementedException();
            //double bonus = basicSalary * 0.1;
            return basicSalary;
        }
    }

    public class Program
    {
        static void Main()
        {
            IEmployee john = new PerminentEmployee(10000);
            var p_salary = john.GetSalary();  // 


            IEmployee micharl = new ContractEmployee(10000);
            var c_salary = micharl.GetSalary();  // 



        }
    }



}
