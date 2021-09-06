using BattleShipBoardGame.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace BattleShipBoardGame.Converters
{
    public class StatusToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Status && value != null)
            {
                switch (value)
                {
                    case Status.Hit:
                        return new SolidColorBrush(Colors.Red);
                    case Status.Miss:
                        return new SolidColorBrush(Colors.Yellow);
                    case Status.Sunk:
                        return new SolidColorBrush(Colors.Gray);
                    case Status.Untested:
                        return new SolidColorBrush(Colors.Blue);
                }
            }
            return new SolidColorBrush(Colors.Blue);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
