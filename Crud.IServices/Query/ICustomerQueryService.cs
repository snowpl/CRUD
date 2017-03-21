using IData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.IServices
{
    public interface ICustomerQueryService
    {
        List<CustomerDTO> GetAll();

    }
}
