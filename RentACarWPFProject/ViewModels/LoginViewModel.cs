using Common.Models;
using RentACarWPFProject.Commands;
using RentACarWPFProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RentACarWPFProject.ViewModels
{
    public class LoginViewModel: ViewModelBase
    {
        private string name;
        private string surname;
        private string password;
        private ICommand login;

        public LoginViewModel()
        {

        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
                OnPropertyChanged("Surname");
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }
        #region Commands

        public ICommand Login
        {
            get
            {
                if (login == null)
                {
                    login = new RelayCommand(param => LoginExecute(param), param => CanLoginExecute(param));
                }
                return login;
            }
        }

        private bool CanLoginExecute(object param)
        {
            if (Name == null || Surname == null || Password== null)
            {
                return false;
            }
            return true;
        }

        private void LoginExecute(object param)
        {
            //try
            //{
            //    Window loginWindow = (Window)param;
            //    //using (RentACarServiceReference.Service1Client service = new RentACarServiceReference.Service1Client())
            //    //{
            //    Person customer = new Person();
            //    customer.Name = Name;
            //    customer.Surname = Surname;
            //    customer.Password = Password;
            //    //int res = service.Login(customer);
            //    //if (res == 0)
            //    //{
            //    //    MessageBox.Show("Ne postoji korisnik sa unetim podacima!");
            //    //}
            //}
            //        else
            //        //{
            //        //    AdministrationWindow mainWindow = new AdministrationWindow();
            //        //    mainWindow.Show();
            //        //    loginWindow.Close();

            //        //}
            //   // }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        #endregion

    }
}
