using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            customer1.Name = " Mislina";
            customer1.Surname = " AYDIN";
            customer1.Accountnumber = 12345;


            Customer customer2 = new Customer();

            customer2.Name = " Ayşe";
            customer2.Surname = " GÜNEŞ";
            customer2.Accountnumber = 56789;


            Customer customer3 = new Customer();

            customer3.Name = " MEHMET";
            customer3.Surname = " AY";
            customer3.Accountnumber = 45677;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("\nName : " + customer.Name + "\nSurname : " + customer.Surname + "\nAccountnumber : " + customer.Accountnumber);


            }

            Console.WriteLine("\n**********\n");

            CustomerManager.Add(customer1);

            CustomerManager.Add(customer2);

            CustomerManager.Add(customer3);


            Console.WriteLine("\n**********\n");

            CustomerManager.Update(customer1);

            CustomerManager.Update(customer2);

            CustomerManager.Update(customer3);


            Console.WriteLine("\n**********\n");


            CustomerManager.Delete(customer1);

            CustomerManager.Delete(customer2);

            CustomerManager.Delete(customer3);

        }
    }
}