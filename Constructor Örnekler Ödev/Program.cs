using System;

namespace Constructor_Örnekler_Ödev
{
    class Program
    {
        static void Main(string[] args)
        {


            Customer customer = new Customer { Id=1,FirstName="yigit",LastName="taskiran",City="Adana"};
            Customer customer1 = new Customer(2, "suheyla", "taskiran", "Adana");

            Console.WriteLine(customer1.FirstName);
        }
        
    }
    class Customer
    {
        public Customer()
        {

        }
        //costructor
        // yukarıda new customer dedıgımızde arka planda asağıdaki kod çalışıyor
        // public customer()
        // biz yazsakda yazmasakta calısıyor sadece nasıl
        //işlediğini görelim diye arka planda ne çalışıyor ona bakıyoruz.
        public Customer(int id,string firtsname,string lastname,string city)
        {
            Id = id;
            FirstName = firtsname;
            LastName = lastname;
            City = city;
        
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
