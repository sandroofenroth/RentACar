using RentACarWPFProject.Controls.ViewModels;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RentACarWPFProject.Controls.Views
{
    /// <summary>
    /// Interaction logic for CarDataGrid.xaml
    /// </summary>
    public partial class CarDataGrid : UserControl
    {
        public CarDataGrid()
        {
            InitializeComponent();
        }

        private void OpenRentWindow_Click(object sender, RoutedEventArgs e)
        {
            RentACarWindow rentACarWindow = new RentACarWindow();
            rentACarWindow.Show();
        }
    }
}
