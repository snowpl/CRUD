using Crud.IServices;
using System.Collections.Generic;
using IData.Interfaces.Command;
using Crud.DTO;

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
            return _cusotmerQueryRepository.GetAll();
        }
    }
}
