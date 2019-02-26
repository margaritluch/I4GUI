using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Agent_DataView
{
    public class AgentIdToColorValueConverter : IValueConverter
    /* Tilføj en color-converter således at forgrundsfarven bliver blå for agenter med Id = 007.*/
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Debug.Assert(targetType == typeof(Brush));
            string id = value as string;
            if (id == null)
                id = "";
            // 007 requires special treatment ...
            return (id == "007" ? Brushes.Blue : Brushes.Black);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
