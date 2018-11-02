using Microsoft.Win32;
using RentACarWPFProject.Commands;
using RentACarWPFProject.Enums;
using RentACarWPFProject.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Common.Models;
using static RentACarWPFProject.Enums.CarTypeEnumumeration;

namespace RentACarWPFProject.ViewModels
{
    public class AddCarWindowViewModel : ViewModelBase
    {
        private ICommand loadData;
        private List<Manufacturer> manufactuterList;
        private CarModel selectedCarModel;
        private ICommand manufacturerSelected;
        private Manufacturer selectedManufacturer;
        private byte[] carImage;
        private ICommand addNewManufacturer;
        private string manufacturerName;
        private byte[] manufacturerLogoImage;
        private ICommand addNewImage;
        private int cubicCapacity;
        private string modelName;
        private int year;
        private ICommand addNewModel;
        private string fuel;
        private float fuelConsuption;
        private int power;
        private ICommand addNewCar;
        private int kilometers;
        private List<CarTypeEnum> cartypeEnumList;
        private string cartype;

        public AddCarWindowViewModel()
        {
            CarTypeEnumumeration cte = new CarTypeEnumumeration();
            cartypeEnumList = cte.CarTypeEnumList;
        }

        #region Properties

        public List<Manufacturer> ManufactrerList
        {
            get
            {
                return manufactuterList;
            }
            set
            {
                manufactuterList = value;
                OnPropertyChanged("ManufactrerList");
            }
        }

        public Manufacturer SelectedManufacturer
        {
            get
            {
                return selectedManufacturer;
            }
            set
            {
                selectedManufacturer = value;
                OnPropertyChanged("SelectedManufacturer");
            }
        }

        public CarModel SelectedCarModel
        {
            get
            {
                return selectedCarModel;
            }
            set
            {
                selectedCarModel = value;
                OnPropertyChanged("SelectedManufacturer");
            }
        }

        public byte[] CarImage
        {
            get
            {
                return carImage;
            }
            set
            {
                carImage = value;
                OnPropertyChanged("CarImage");
            }
        }

        public string ManufacturerName
        {
            get
            {
                return manufacturerName;
            }
            set
            {
                manufacturerName = value;
                OnPropertyChanged("ManufacturerName");
            }
        }
        public byte[] ManufacturerLogoImage
        {
            get
            {
                return manufacturerLogoImage;
            }
            set
            {
                manufacturerLogoImage = value;
                OnPropertyChanged("ManufacturerLogoImage");
            }
        }

        public int CubicCapacity
        {
            get
            {
                return cubicCapacity;
            }
            set
            {
                cubicCapacity = value;
                OnPropertyChanged("CubicCapacity");
            }
        }

        public string ModelName
        {
            get { return modelName; }
            set
            {
                modelName = value;
                OnPropertyChanged("ModelName");
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                year = value;
                OnPropertyChanged("Year");
            }
        }

        public string Fuel
        {
            get
            {
                return fuel;
            }
            set
            {
                fuel = value;
                OnPropertyChanged("Fuel");
            }
        }

        public float FuelConsuption
        {
            get
            {
                return fuelConsuption;
            }
            set
            {
                fuelConsuption = value;
                OnPropertyChanged("FuelConsuption");
            }
        }

        public int Power
        {
            get
            {
                return power;
            }
            set
            {
                power = value;
                OnPropertyChanged("Power");
            }
        }

        public int Kilometers
        {
            get
            {
                return kilometers;
            }
            set
            {
                kilometers = value;
                OnPropertyChanged("Kilometers");
            }
        }

        public List<CarTypeEnum> CartypeEnumList
        {
            get
            {
                return cartypeEnumList;
            }
        }
        public string Cartype
        {
            get
            {
                return cartype;
            }
            set
            {
                cartype = value;
                OnPropertyChanged("Cartype");
            }
        }
        #endregion

        #region ICommand 

        public ICommand ManufacturerSelected
        {
            get
            {
                return manufacturerSelected = new RelayCommand(param => ManufacturerSelectedExecute());
            }
        }

        public ICommand LoadData
        {
            get
            {
                return loadData = new RelayCommand(param => manufacturerSelectedExecute());
            }
        }

        public ICommand AddNewManufacturer
        {
            get
            {
                return addNewManufacturer = new RelayCommand(param => AddNewManufacturerExecute());
            }
        }

        public ICommand AddNewImage
        {
            get
            {
                return addNewImage = new RelayCommand(param => AddNewImageExecute(param));
            }

        }

        public ICommand AddNewModel
        {
            get
            {
                return addNewModel = new RelayCommand(param => AddNewModelExecute());
            }
        }

        public ICommand AddNewCar
        {
            get
            {
                return addNewCar = new RelayCommand(param => AddNewCarExecute());
            }
        }

        #endregion

        #region Methods

        private void ManufacturerSelectedExecute()
        {
            MessageBox.Show("Pusi kurac");
        }

        private void manufacturerSelectedExecute()
        {
            using (RentACarServiceReference.Service1Client wcf = new RentACarServiceReference.Service1Client())
            {
                ManufactrerList = wcf.GetManufacturers();
            };
        }


        private void AddNewManufacturerExecute()
        {
            using (RentACarServiceReference.Service1Client wcf = new RentACarServiceReference.Service1Client())
            {
                Manufacturer manufactrer = new Manufacturer();

                wcf.AddNewManufacturer(manufactrer);
                manufacturerSelectedExecute();
                AddCarWindow acw = new AddCarWindow();
                acw.grpAddManufacturer.Visibility = Visibility.Collapsed;
            }
        }

        private void AddNewImageExecute(object param)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            if (openFD.ShowDialog() == true)
            {
                using (Stream fs = openFD.OpenFile())
                {
                    if (fs != null)
                    {
                        var bt = new byte[fs.Length];
                        fs.Read(bt, 0, bt.Length);
                        string option = param as string;
                        if (option == "carImage")
                        {
                            CarImage = bt;
                        }
                        else
                        {
                            ManufacturerLogoImage = bt;
                        }
                    }

                }
            }
        }

        private void AddNewModelExecute()
        {
            using (RentACarServiceReference.Service1Client service = new RentACarServiceReference.Service1Client())
            {
                CarModel carModel = new CarModel();
                carModel.Name = ModelName;
                carModel.Year = Year;
                carModel.ManufacturerId = SelectedManufacturer.Id;
                service.AddNewModel(carModel);
                manufacturerSelectedExecute();
                AddCarWindow acw = new AddCarWindow();
                acw.grpModel.Visibility = Visibility.Collapsed;
           }
        }

        private void AddNewCarExecute()
        {
            using (RentACarServiceReference.Service1Client service = new RentACarServiceReference.Service1Client())
            {
                Car car = new Car();
                car.Available = true;
                car.Image = CarImage;
                car.TotalRentals = 0;
                car.CubicCapacity = CubicCapacity;
                car.Fuel = Fuel;
                car.FuelConsuption = FuelConsuption;
                car.Power = Power;
                car.IdModels = SelectedCarModel.Id;
                car.Type = Cartype;
                car.Kilometers = Kilometers;
                service.AddNewCar(car);
            }
        }
        #endregion









    }
}
