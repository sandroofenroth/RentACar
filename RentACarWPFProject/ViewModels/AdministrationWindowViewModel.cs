
using RentACarWPFProject.Commands;
using RentACarWPFProject.Controls.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RentACarWPFProject.ViewModels
{
    public class AdministrationWindowViewModel : ViewModelBase
    {
        public TreeViewViewModel TreeViewViewModel { get; set; }
        public CarDataGridViewModel CarDataGridViewModel { get; set; }
        ICommand loadData;

        public AdministrationWindowViewModel()
        {
            TreeViewViewModel = new TreeViewViewModel();
            CarDataGridViewModel = new CarDataGridViewModel();
            TreeViewViewModel.ItemSelected += CarDataGridViewModel.c_ItemSelected;
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
                wcf.GetCar(1, 1);
            }
        }

    }
}
