using System;
namespace code
{
    class CustomerService
    {
        public CustomerRepository repository;
        public CustomerService(CustomerRepository repository)
        {
            this.repository = repository;
        }
    }
}