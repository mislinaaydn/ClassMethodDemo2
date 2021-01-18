using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public static void Add(Customer customer)
        {
            Console.WriteLine("\n" + customer.Name + "   \n" + customer.Surname + "   \n" + customer.Accountnumber + "   \n" + "   <<<EKLENDİ>>>" + "\n");
        }

        public static void Update(Customer customer)
        {
            Console.WriteLine(customer.Name + "   \n " + customer.Surname + "   \n" + customer.Accountnumber + "   \n" + "   <<<GÜNCELLENDİ>>>" + "\n");
        }

        public static void Delete(Customer customer)
        {
            Console.WriteLine("\n" + customer.Name + "   \n" + customer.Surname + "   \n" + customer.Accountnumber + "   \n" + "   <<<SİLİNDİ>>>" + "\n");
        }
    }
}