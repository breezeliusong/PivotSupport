using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace PivotSupport.DataModel
{
     public class PriceVm: INotifyPropertyChanged
    {
        public string Code { get; set; }
        public string ArticleName { get; set; }


        private Brush _textcolor = new SolidColorBrush(Colors.Black);

        public event PropertyChangedEventHandler PropertyChanged;


        private void RaisedPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        public Brush textcolor
        {
            get { return _textcolor; }
            set
            {
                _textcolor = value;
                RaisedPropertyChanged("textcolor");
            }
        }

    }
}
