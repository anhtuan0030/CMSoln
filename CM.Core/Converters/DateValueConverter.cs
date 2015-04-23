using Cirrious.CrossCore.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Converters
{
    public class DateValueConverter
        : MvxValueConverter<DateTime>
    {
        protected override object Convert(DateTime date, Type targetType, object parameter, CultureInfo culture)
        {
            string dateOfBirth = date.ToString("dd-MM-yyyy");

            return dateOfBirth;
        }
    }
}
