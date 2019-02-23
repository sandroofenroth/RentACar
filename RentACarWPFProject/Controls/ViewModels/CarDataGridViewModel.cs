using Common.Models;
using RentACarWPFProject.Commands;
using RentACarWPFProject.Controls.Views;
using RentACarWPFProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace RentACarWPFProject.Controls.ViewModels
{
    public class CarDataGridViewModel : ViewModelBase
    {

        private Manufacturer SelectedManufacturer;
        private Car selectedCar;
        private ICommand loadData;

        public Car SelectedCar
        {
            get { return selectedCar; }
            set { selectedCar = value; OnPropertyChanged("SelectedCar"); }
        }

        public Manufacturer MyProperty
        {
            get { return SelectedManufacturer; }
            set { SelectedManufacturer = value; }
        }

        private CarModel selectedModel;

        public CarModel SelectedModel
        {
            get { return selectedModel; }
            set { selectedModel = value; }
        }

        public CarDataGridViewModel()
        {
        }

        private List<Car> cars;

        public List<Car> Cars
        {
            get { return cars; }
            set { cars = value; OnPropertyChanged("Cars"); }
        }


        public void c_ItemSelected(object sender, TreeViewItemSelectedEventArgs e)
        {
            SelectedModel = e.Model;
            SelectedManufacturer = e.Manufacturer;
            //using (var service = new RentACarService.)
            //{
            //    if (SelectedModel != null)
            //    {
            //        Cars = service.GetCarByModel(SelectedModel);
            //    }
            //    else if (SelectedManufacturer != null)
            //    {
            //        Cars = service.GetCarByManufacturer(SelectedManufacturer);
            //    }
            //}
        }

        public ICommand LoadData
        {
            get
            {
                return loadData = new RelayCommand(param => OnLoadedExecute());
            }
        }

        private void OnLoadedExecute()
        {
            //using (var wcf = new CarCrudServiceReference.CarCrudServiceClient())
            //{
            //    Cars = wcf.GetCars();
            //}
        }

 

        public CarDataGrid CarDataGrid
        {
            get { return default(CarDataGrid); }
           
        }

        protected virtual void OnCarSelected(DataGridItemSelectedEventArgs e)
        {
            OnCarSelectedEventHandler handler = CarSelected;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event OnCarSelectedEventHandler CarSelected;
    }

    public delegate void OnCarSelectedEventHandler(Object sender, DataGridItemSelectedEventArgs e);
}
