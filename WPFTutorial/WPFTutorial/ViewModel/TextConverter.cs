using System;
using System.Globalization;
using System.Windows.Data;

namespace WPFTutorial.ViewModel
{
    class TextConverter : IValueConverter
    {
        public TextConverter()
        {

        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // value 가져오기
            string textValue = (string)value;
            if (textValue.Contains("ok"))
                return "stop";
            else
                return textValue;
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
