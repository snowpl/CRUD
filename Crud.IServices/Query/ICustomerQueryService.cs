using Crud.DTO;
using System.Collections.Generic;

namespace Crud.IServices
{
    public interface ICustomerQueryService
    {
        List<CustomerDTO> GetAll();
    }
}
