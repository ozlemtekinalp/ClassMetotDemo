using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add1(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + "eklendi");


        }

        public void Delete1(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + "silindi");


        }
        public void Listele(Customer customer)
        {
            Console.WriteLine();


        }

    }
}
