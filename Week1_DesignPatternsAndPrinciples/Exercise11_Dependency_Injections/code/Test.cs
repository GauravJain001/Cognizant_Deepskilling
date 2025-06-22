using System;
namespace code
{
    class Test
    {
        public static void Main(String[] args)
        {
            //Dependency Injection
            //Injecting Repository in Service
            CustomerService service = new CustomerService(new CustomerRepositoryImpl());
            //Adding Customers into Repository
            service.repository.AddCustomer(new Customer(1, "Gaurav"));
            service.repository.AddCustomer(new Customer(2, "Ram"));
            service.repository.AddCustomer(new Customer(3, "Sam"));
            service.repository.AddCustomer(new Customer(4, "Monu"));
            service.repository.AddCustomer(new Customer(5, "Golu"));
            //Finding CustomerById in The Repository By using Service
            var customer1 = service.repository.FindCustomerById(1);
            if (customer1 != null)
            {
                Console.WriteLine(customer1);
            }
            else
            {
                Console.WriteLine("Customer not found");
            }
            var customer2 = service.repository.FindCustomerById(6);
            if (customer2 != null)
            {
                Console.WriteLine(customer2);
            }
            else
            {
                Console.WriteLine("Customer not found");
            }





            
            
        }
    }
}