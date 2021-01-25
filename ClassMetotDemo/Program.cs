using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Customer customer1 = new Customer();
            customer1.CustomerName = "ali";
            customer1.CustomerSurname = "kaya";
            customer1.Id = "1";
            customer1.AdressCity = "izmir";

            Customer customer2 = new Customer();
            customer2.CustomerName = "ayşe";
            customer2.CustomerSurname = "nil";
            customer2.Id = "2";
            customer2.AdressCity = "ankara";

            Customer customer3 = new Customer();
            customer3.CustomerName = "irem";
            customer3.CustomerSurname = "aras";
            customer3.Id = "3";
            customer3.AdressCity = "adana";
            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            


            foreach(Customer customer in customers)
            {
                Console.WriteLine(customer.CustomerName + " : " + customer.CustomerSurname);
            }

            CustomerManager customerManager = new CustomerManager();
           
            customerManager.Add1(customer1);
            customerManager.Delete1(customer2);




        }

        










        }


        }
    

