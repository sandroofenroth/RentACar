using Common.Models;
using RentACarWPFProject.Commands;
using RentACarWPFProject.ViewModels;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace RentACarWPFProject.Controls.ViewModels
{
    public class CarDataGridViewModel : ViewModelBase
    {

        private Manufacturer SelectedManufacturer;
        private ICommand loadData;

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
            string message = "Prazno";
            if (e.Model != null)
                message = "Naziv selektovanog modela je " + selectedModel.Name;
            else
                message = "Naziv selektovanog proizvodjaca je " + SelectedManufacturer.Name;
            MessageBox.Show(message);
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
            using (var wcf = new RentACarServiceReference.Service1Client())
            {
                ////var rez = wcf.GetCar(SelectedModel.Id, SelectedManufacturer.Id);
                //if (SelectedModel.Id != 0 || SelectedManufacturer.Id != 0)
                //{
                Cars = wcf.GetCar(1, 1);
                // }

            }
        }
    }

}
