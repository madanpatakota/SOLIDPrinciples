using System;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;

namespace SOLIDPrinciples.DSP_Bad
{
    //High Level Modules should depend on the abstrations or interfaces not on concrete classes

    //concrete class - the class which provide implementation details 

    //it makes the code very flexiable
    //Reduce tight coupling and provide loosly coupling 

    public class EmailService     //concrete class
    {
        public void Send(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }
    }


    public class SMSService     //concrete class
    {
        public void Send(string message)
        {
            Console.WriteLine("SMS sent: " + message);
        }
    }


    public class FAXservice
    {
        public void Send(string message)
        {
            Console.WriteLine("FAX sent: " + message);
        }
    }

    //Lets depend on the concrete class
    public class EmployeeManager  //business logic
    {
        private EmailService email = new EmailService(); //tighlty coupling

        //depending 
        private SMSService sms = new SMSService(); //tighlty coupling

        //fax
        private FAXservice fax = new FAXservice(); //tighlty coupling

        public void EmailNotifify(string message)
        {
            email.Send(message);
        }

        public void SMSNotifify(string message)
        {
            sms.Send(message);
        }

        public void FaxNotifify(string message)
        {
            fax.Send(message);
        }
        //Problem : Tomorrow send the message from xyz.... we must edit the class
        //Business Logic managing employees , rating , mailssend , hike , Manage the project
    }





}



namespace SOLIDPrinciples.DSP_Good
{

    public interface INotifierService
    {
        void Send(string message);
    }

    public class EmailNotifier : INotifierService
    {
        public void Send(string message)
        {
            Console.WriteLine("Email: " + message);
        }
    }

    public class SMSNotifier : INotifierService
    {
        public void Send(string message)
        {
            Console.WriteLine("SMS: " + message);
        }
    }

    public class FAXNotifier : INotifierService
    {
        public void Send(string message)
        {
            Console.WriteLine("SMS: " + message);
        }
    }

    public class EmployeeManager  //business logic
    {
        private INotifierService notifier;

        //Dependency injection   // service , routing 
        public EmployeeManager(INotifierService service)
        {
            this.notifier = service;
        }

        public void Notify(string message)
        {
            notifier.Send(message);
        }
    }

    public class Program
    {
        static void Main()
        {
            //interface int1 = new child1();
            //InterfaceImplementedInVersionAttribute

            EmployeeManager JOHNEMIl = new EmployeeManager(new EmailNotifier());
            JOHNEMIl.Notify("HI");

            EmployeeManager RobertSMS = new EmployeeManager(new SMSNotifier());
            RobertSMS.Notify("Hello..");

            EmployeeManager ClarkFAx = new EmployeeManager(new FAXNotifier());
            ClarkFAx.Notify("Hello..");

        }
    }

}