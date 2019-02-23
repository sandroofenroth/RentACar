using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RentACarService.Model

{
    [DataContract]
    public class Manufacturer
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public byte[] Logo { get; set; }

        [DataMember]
        public List<CarModel> Models { get; set; }
    } 
}
