using System;
namespace code
{
    interface CustomerRepository
    {
        public Customer FindCustomerById(int Id);
        public void AddCustomer(Customer c);

        
        
    }
}