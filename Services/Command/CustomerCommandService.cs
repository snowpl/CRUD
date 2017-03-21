using Crud.IServices.Command;
using System;
using IData.Entities;
using IData.Interfaces.Command;
using IData.Interfaces;

namespace Services.Command
{
    public class CustomerCommandService : ICustomerCommandService
    {
        private readonly ICustomerCommandRepository _customerCommandRepository;
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public CustomerCommandService(ICustomerCommandRepository customerCommandRepository, IUnitOfWorkFactory unitOfWorkFactory)
        {
            _customerCommandRepository = customerCommandRepository;
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public void AddNewCustomer(CustomerDTO customer)
        {
            _customerCommandRepository.AddNewCustomer(customer);
            _unitOfWorkFactory.SaveChanges();
        }

        public void DeleteCustomer(int Id)
        {
            _customerCommandRepository.DeleteCustomer(Id);
            _unitOfWorkFactory.SaveChanges();
        }

        public void EditCustomer(CustomerDTO customer)
        {
            _customerCommandRepository.EditCustomer(customer);
            _unitOfWorkFactory.SaveChanges();
        }
    }
}
