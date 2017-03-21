using IData.Entities;

namespace IData.Interfaces.Command
{
    public interface ICustomerCommandRepository
    {
        void AddNewCustomer(CustomerDTO customer);
        void EditCustomer(CustomerDTO customer);
        void DeleteCustomer(int Id);
    }
}
