using RentACarWPFProject.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using static RentACarWPFProject.Enums.CarTypeEnumumeration;

namespace RentACarWPFProject.Converters
{
    public class CarTypeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            List<string> enumString = new List<string>();
            if (value is List<CarTypeEnum>)
            {
                foreach (var item in (value as List<CarTypeEnum>))
                {
                    if (item.ToString() == "StationWagon")
                    {
                        string mi = item.ToString();
                        mi = "Station wagon";
                        enumString.Add(mi);
                    }
                    else
                    {
                        enumString.Add(item.ToString());
                    }
                }
            }

            return enumString;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
