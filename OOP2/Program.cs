using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //gerçek - Tüzel ikiside müşteri ama farklı müşteri tipleri
            // ikisi bir classta kullanılmaz
            RealCustomer customer1 = new RealCustomer();
            customer1.CustomerNumber = "123123";
            customer1.FirstName = "yigithan";
            customer1.LastName = "taşkıran";
            customer1.CustomerSSNumber = "1212311212";


            ///////

            LegalCustomer customer2 = new LegalCustomer();
            customer2.Id = 1;
            customer2.CustomerNumber = "123123333";
            customer2.CompanyName = "Unlucky";
            customer2.TaxNumber = "123123";

            Customer customer3 = new RealCustomer();
            Customer customer4 = new LegalCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            

        } 
    }
}
