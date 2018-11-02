using Common.Models;
using System;

namespace RentACarWPFProject.Controls.ViewModels
{
    public class TreeViewItemSelectedEventArgs : EventArgs
    {
        public Manufacturer Manufacturer { get; set; }
        public CarModel Model { get; set; }
    }
}
