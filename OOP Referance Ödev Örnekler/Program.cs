using System;

namespace OOP_Referance_Ödev_Örnekler
{
    class Program
    {

        static void Main(string[] args)
        {

       
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "yigit";
            person2 = person1;
            person1.FirstName = "suheyla";
            

            Customer customer = new Customer();
            customer.FirstName = "gülsena";
            customer.CrediCartNumber = 123123123;
            Employee employee = new Employee();
            employee.FirstName = "tolunay";

            Person person3 = customer;
            customer.FirstName = "ahmet";

            // boxing yapma olayı bu sekılde kutucuklara alıp customer classına ulasıyorsunuz
            /*onsole.WriteLine(((Customer)person3).CrediCartNumber); ;*/
            PersonManager personManager = new PersonManager();
            // person customerınde employee nınde adreslerını tutabılıyor
            personManager.Add(customer);
        }
    }
    //base class temel sınıf =ebeveyn gibi düşünün
   // person customerınde employee nınde adreslerını tutabılıyor
    class Person
    {
        public int Id   { get ; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    // anne person cocuk customer   customer ana sınıfa baglana bılıyor 
    class Customer:Person
    {
        public int CrediCartNumber { get; set; }

    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }

    }

    class PersonManager
    {
        //// person customerınde employee nınde adreslerını tutabılıyor
        public void Add(Person person)// burada persona yukarıda gönderdiğimiz employeenın adresini vyerlestırıyor ve o adresin firstnamesi çalışıyor.
        {
            Console.WriteLine(person.FirstName);

        }
            }
}

