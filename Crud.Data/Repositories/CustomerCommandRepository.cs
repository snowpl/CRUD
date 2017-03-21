using Crud.Data.Models;
using IData.Entities;
using IData.Interfaces.Command;
using System.Data.Entity.Migrations;

namespace Crud.Data.Repositories
{
    public class CustomerCommandRepository : ICustomerCommandRepository
    {
        private readonly CrudDBContext _context;

        public CustomerCommandRepository(CrudDBContext context)
        {
            _context = context;
        }

        public void AddNewCustomer(CustomerDTO customer)
        {
            var customerDb = new Customer()
            {
                Id = customer.Id,
                Address = customer.Address,
                Name = customer.Name,
                Surname = customer.Surname,
                TelephoneNumber = customer.TelephoneNumber
            };
            _context.Set<Customer>().Add(customerDb);
        }

        public void EditCustomer(CustomerDTO customer)
        {
            var customerDb = new Customer()
            {
                Id = customer.Id,
                Address = customer.Address,
                Name = customer.Name,
                Surname = customer.Surname,
                TelephoneNumber = customer.TelephoneNumber
            };
            _context.Set<Customer>().AddOrUpdate(customerDb);
        }

        public void DeleteCustomer(int Id)
        {
            var customerDb = new Customer()
            {
                Id = Id
            };
            _context.Set<Customer>().Attach(customerDb);
            _context.Set<Customer>().Remove(customerDb);
        }
    }
}
