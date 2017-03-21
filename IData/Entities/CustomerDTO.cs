using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IData.Entities
{
    public class CustomerDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int TelephoneNumber { get; set; }

        public string Address { get; set; }

    }
}
