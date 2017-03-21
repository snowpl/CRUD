using IData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IData.Interfaces.Command
{
    public interface ICustomerQueryRepository
    {
        List<CustomerDTO> GetAll();
    }
}
