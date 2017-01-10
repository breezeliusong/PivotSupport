using GalaSoft.MvvmLight;
using PivotSupport.DataModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PivotSupport
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        public ObservableCollection<PriceVm> recordingList { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisedPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        private object _PivotSelectedItem;
        public object PivotSelectedItem
        {
            get { return _PivotSelectedItem; }
            set
            {
                if (_PivotSelectedItem != null)
                {
                    var temp = _PivotSelectedItem as PriceVm;
                    if (temp != null)
                    {
                        temp.textcolor = new SolidColorBrush(Colors.Black);
                    }
                }
                _PivotSelectedItem = value;
                var temp2 = _PivotSelectedItem as PriceVm;
                if (temp2 != null)
                {
                    temp2.textcolor = new SolidColorBrush(Colors.Red);
                }
                _PivotSelectedItem = temp2 as PriceVm;

                RaisedPropertyChanged("PivotSelectedItem");
            }
        }
        public MainPage()
        {
            this.InitializeComponent();
            PriceVm item1 = new PriceVm() { Code = "hello", ArticleName = "world"};
            PriceVm item2 = new PriceVm() { Code = "hi", ArticleName = "boy"};
            recordingList = new ObservableCollection<PriceVm>();
            recordingList.Add(item1);
            recordingList.Add(item2);
        }
    }
}
