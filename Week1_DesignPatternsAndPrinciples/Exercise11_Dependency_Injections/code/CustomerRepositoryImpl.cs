using System;
namespace code
{
    class CustomerRepositoryImpl : CustomerRepository
    {
        private List<Customer> repo = new List<Customer>();

        public void AddCustomer(Customer c)
        {
            repo.Add(c);
        }

        public Customer FindCustomerById(int Id)
        {
            foreach (var customer in repo)
            {
                if (customer.Id == Id)
                {
                    return customer;
                }
            }
            return null;
        }
    }
}