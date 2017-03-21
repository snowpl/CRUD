using Crud.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IData.Entities;
using IData.Interfaces.Command;

namespace Services
{
    public class CustomerQueryService : ICustomerQueryService
    {
        private readonly ICustomerQueryRepository _cusotmerQueryRepository;

        public CustomerQueryService(ICustomerQueryRepository cusotmerQueryRepository)
        {
            _cusotmerQueryRepository = cusotmerQueryRepository;
        }

        public List<CustomerDTO> GetAll()
        {
            var customerList = _cusotmerQueryRepository.GetAll();
            return customerList;
        }
    }
}
