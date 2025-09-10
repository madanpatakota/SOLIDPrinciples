using System;


namespace SOLIDPrinciples.ISP
{

    //do't force a class to implement methods it does't need

    //Instead of create the one big interfae , we can create many small and specific interfaces.



    //Dummy code 
    // keep classes very clean


    //public interface IEmployee
    //{
    //    void Work();
    //    void GetSalary();
    //    void AttendTraining();
    //}
    ////contract employee , woul't give all trainning

    //public class ContractEmployee : IEmployee
    //{

    //    // ❌ Not applicable for contract employees, but forced to implement
    //    public void AttendTraining()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void GetSalary()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Work()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}



    //--------------------------------------------------------------------------------

    //working relatd
    public interface IWorkable
    {
        void Work();
    }

    //payment deparentn
    public interface IPayable
    {
        void GetSalary();
    }

    //training 
    public interface ITrainable
    {
        void AttendTraining();
    }

    public class ContractEmployee : IPayable, IWorkable
    {

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    public class PerminnetEmployee : IPayable , IWorkable , ITrainable
    {

        public void AttendTraining()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }


}
