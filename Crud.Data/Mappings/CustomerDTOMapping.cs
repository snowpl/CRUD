using Crud.Data.Models;
using IData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Data.Mappings
{
    internal static class CustomerDTOMappings
    {
        public static CustomerDTO Map(this Customer source, CustomerDTO target)
        {
            target.Address = source.Address;
            target.Id = source.Id;
            target.Name = source.Name;
            target.Surname = source.Surname;
            target.TelephoneNumber = source.TelephoneNumber;

            return target;
        }

        public static Customer Map(this CustomerDTO source, Customer target)
        {
            target.Address = source.Address;
            target.Id = source.Id;
            target.Name = source.Name;
            target.Surname = source.Surname;
            target.TelephoneNumber = source.TelephoneNumber;

            return target;
        }

        public static CustomerDTO MapToCustomerDTO(Customer source)
        {
            var target = new CustomerDTO();

            return Map(source, target);
        }

        public static Customer MapToCustomer(CustomerDTO source)
        {
            var target = new Customer();

            return Map(source, target);
        }
    }
}
