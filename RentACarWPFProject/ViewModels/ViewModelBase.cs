using System.ComponentModel;

namespace RentACarWPFProject.ViewModels
{
   public class ViewModelBase : INotifyPropertyChanged
    {
        public delegate void ParameterChange(object parameter); 
        public ParameterChange OnParameterChange { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }
    
}
