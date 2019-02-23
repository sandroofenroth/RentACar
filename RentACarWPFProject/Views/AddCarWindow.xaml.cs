using Common.Models;
using MahApps.Metro.Controls;
using Microsoft.Win32;
using RentACarWPFProject.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RentACarWPFProject.Views
{
    /// <summary>
    /// Interaction logic for AddCarWindow.xaml
    /// </summary>
    public partial class AddCarWindow : MetroWindow
    {    
        public AddCarWindow()
        {
            InitializeComponent();
        }

        public AddCarWindow(Car car)
        {
            InitializeComponent();
            ((AddCarWindowViewModel)DataContext).Editing = true;
            ((AddCarWindowViewModel)DataContext).Car = car;
        }

        public AddCarWindowViewModel AddCarWindowViewModel
        {
            get { return default(AddCarWindowViewModel); }

        }

        private void Button_Click_AddNewManufacturer(object sender, RoutedEventArgs e)
        {
            if (sender as Button != null)
            {
                grpAddManufacturer.Visibility = Visibility.Collapsed;
            }
        }

        private void Button_Click_AddNewCar(object sender, RoutedEventArgs e)
        {
            if (sender as Button != null)
            {
                if (grpAddManufacturer.Visibility == Visibility.Collapsed)
                {
                    grpAddManufacturer.Visibility = Visibility.Visible;
                }
                else
                {
                    grpAddManufacturer.Visibility = Visibility.Collapsed;
                }
               
            }
        }

        private void Button_Click_AddNewModel(object sender, RoutedEventArgs e)
        {
            if (sender as Button != null)
            {
                if (grpModel.Visibility == Visibility.Visible)
                {
                    grpModel.Visibility = Visibility.Collapsed;
                }
                else
                {
                    grpModel.Visibility = Visibility.Visible;
                }
                
            }
        }
    }
}
