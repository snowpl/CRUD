using IData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.IServices.Command
{
    public interface ICustomerCommandService
    {
        void AddNewCustomer(CustomerDTO customer);
        void EditCustomer(CustomerDTO customer);
        void DeleteCustomer(int Id);
    }
}
