using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarWPFProject.Controls.ViewModels
{
    public class DataGridItemSelectedEventArgs : EventArgs
    {
        public Car Car { get; set; }
    }
}
