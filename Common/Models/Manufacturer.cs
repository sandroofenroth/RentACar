using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
   [DataContract]
   public class Manufacturer
    {
        #region Fields

        private int id;
        private string name;
        private byte[] logo;
        private List<CarModel> models;

        #endregion


        public Manufacturer()
        {

        }
        #region Properties

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public byte[] Logo
        {
            get { return logo; }
            set { logo = value; }
        }

        [DataMember]
        public List<CarModel> Models
        {
            get { return models; }
            set { models = value; }
        }

        #endregion

    }
}
