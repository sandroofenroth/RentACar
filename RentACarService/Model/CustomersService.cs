using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RentACarService.Model
{
    [DataContract]
    public class CustomersService
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}
