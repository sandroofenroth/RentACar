using Common.Models;
using RentACarService;
using RentACarWPFProject.Commands;
using RentACarWPFProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace RentACarWPFProject.Controls.ViewModels
{
    public class TreeViewViewModel : ViewModelBase
    {
        private Manufacturer selectedManufacturer;
        private CarModel selectedCarModel;
        private List<Manufacturer> manufactuterList;
        private ICommand loadData, itemClicked;
        public EventHandler SelectionChanged;

        public TreeViewViewModel()
        {
        }
        #region Fields
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
                OnPropertyChanged("SelectedCarModel");
            }
        }
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
        #endregion
        public ICommand LoadData
        {
            get
            {
                return loadData = new RelayCommand(param => OnLoadedExecute());
            }
        }

        private void OnLoadedExecute()
        {
            Service1 wcf = new Service1();
            ManufactrerList = wcf.GetManufacturers();
        }

        public ICommand ItemClicked
        {
            get
            {
                if (itemClicked == null)
                {
                    itemClicked = new RelayCommand(param => ItemClickedExecute(param));
                }
                return itemClicked;
            }
        }

        private bool CanItemClickedExecute()
        {
            return true;
        }

        private void ItemClickedExecute(Object param)
        {
            if (param is Manufacturer)
            {
                var manufacturer = (Manufacturer)param;
                SelectedCarModel = null;
                SelectedManufacturer = manufacturer;

                TreeViewItemSelectedEventArgs args = new TreeViewItemSelectedEventArgs();
                args.Manufacturer = manufacturer;
                args.Model = null;
                OnItemSelected(args);
            }
            else
            {
                var model = (CarModel)param;
                SelectedManufacturer = null;
                SelectedCarModel = model;

                TreeViewItemSelectedEventArgs args = new TreeViewItemSelectedEventArgs();
                args.Manufacturer = null;
                args.Model = model;
                OnItemSelected(args);
            }
        }

        protected virtual void OnItemSelected(TreeViewItemSelectedEventArgs e)
        {
           OnItemSelectedEventHandler handler = ItemSelected;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event OnItemSelectedEventHandler ItemSelected;
    }

    public delegate void OnItemSelectedEventHandler(Object sender, TreeViewItemSelectedEventArgs e);
}
