using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{

    //Software entities(classes , modules , methods) shold be open for extension but closed for modificaiton

    //1 . YOu should be able to add new features to a cass without break its existing code.
    //2. instead of ediditin the old logic , you can extend it(using inheritance or interface)
    
   public class DiscountCalculator
    {

        //bad example
        //public decimal Calculate(string customerType , decimal amount)
        //{
        //    if (customerType      == "Regular")
        //        return amount * 0.95m;    // imaine some 10 lines
        //    else if (customerType == "Premium")
        //        return amount * 0.90m; // imaine some 10 lines
        //    else if (customerType == "VIP")
        //        return amount * 0.85m; // imaine some 10 lines
        //    else 
        //        return amount; // no discount
        //}

        // tomorrow vip --> 15% discuont --> Edit 


        public abstract class Discount
        {
            public abstract decimal apply(decimal amount);
        }


        public class RegularCustomersDiscount: Discount
        {
            public override decimal apply(decimal amount)
            {
                return amount * 0.95m;
            }
        }

        public class PremiumCustomersDiscount : Discount
        {
            public override decimal apply(decimal amount)
            {
                return amount * 0.90m;
            }
        }

        public class VIPCustomersDiscount : Discount
        {
            public override decimal apply(decimal amount)
            {
                return amount * 0.85m;
            }
        }


        public class DiccountMain
        {
            public void Main()
            {

                var regualar  = new RegularCustomersDiscount();
                regualar.apply(100);

                var premiumcus = new PremiumCustomersDiscount();
                premiumcus.apply(100);

                var vipCustome = new VIPCustomersDiscount();
                vipCustome.apply(100);


            }
        }


    }
}
