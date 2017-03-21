using System.Linq;
using System.Collections.Generic;
using IData.Entities;
using IData.Interfaces.Command;
using Crud.Data.Models;

namespace Crud.Data.Repositories
{
    public class CustomerQueryRepository : ICustomerQueryRepository
    {
        private readonly CrudDBContext _dbContext;
        public CustomerQueryRepository(CrudDBContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public List<CustomerDTO> GetAll()
        {
            var result = from cust in _dbContext.Set<Customer>()
                         select new CustomerDTO
                         {
                             Id = cust.Id,
                             Name = cust.Name,
                             Address = cust.Address,
                             Surname = cust.Surname,
                             TelephoneNumber = cust.TelephoneNumber
                         };
            return result.ToList();
        }

        public CustomerDTO GetOneCustomer(int Id)
        {
            var entity = _dbContext.Customer.FirstOrDefault(x => x.Id == Id);
            entity.Map(new CustomerDTO());
            return entity;
        }
    }
}
