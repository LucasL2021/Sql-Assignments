using System;
using System.Collections.Generic;
using System.Text;
using CustomerDb.Data.Repository;
using CustomerDb.Data.Model;

namespace CustomerDb
{
    class ManageCustomer
    {
        IRepository<Customer> customerRepository;
        public ManageCustomer() 
        {
            customerRepository = new CustomerRepository();
        }
        void AddCustomer() 
        {
            Customer c = new Customer();
            Console.Write("Enter CustomerId = ");
            c.CustomerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter FirstName = ");
            c.FirstName = Console.ReadLine();
            Console.Write("Enter LastName = ");
            c.LastName = Console.ReadLine();
            Console.Write("Enter Mobile = ");
            c.Mobile = Console.ReadLine();
            Console.Write("Enter EmailId = ");
            c.EmailId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter City = ");
            c.City = Console.ReadLine();
            Console.Write("Enter State = ");
            c.State = Console.ReadLine();
        }
        public void Run() 
        {
            AddCustomer();
        }
    }
}
