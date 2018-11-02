using RentACarWPFProject.ViewModels;
using System.Windows;

namespace RentACarWPFProject.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
       private LoginViewModel model;
        public LoginWindow()
        {
            InitializeComponent();
            model = new LoginViewModel();
            //DataContext = login;
            
        }
        
    }
}
