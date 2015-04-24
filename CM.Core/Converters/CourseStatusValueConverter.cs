using Cirrious.CrossCore.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Converters
{
    public class CourseStatusValueConverter
        : MvxValueConverter<int>
    {
        protected override object Convert(int status, Type targetType, object parameter, CultureInfo culture)
        {
            string output = string.Empty;

            switch (status)
            {
                case 1:
                    output = "Chờ phản hồi";
                    break;
                case 2:
                    output = "Đã xác nhận";
                    break;
                case 3:
                    output = "Không chấp nhận";
                    break;
                default:
                    output = "Trạng thái Không hợp lệ";
                    break;
            }

            return output;
        }
    }
}
