using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
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

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public byte[] Logo
        {
            get { return logo; }
            set { logo = value; }
        }

        public List<CarModel> Models
        {
            get { return models; }
            set { models = value; }
        }

        #endregion

        #region Methods


        #endregion

    }
}
