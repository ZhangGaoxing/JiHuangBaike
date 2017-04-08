using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace JiHuangBaike.Data
{
    class NavMenuItem : INotifyPropertyChanged
    {
        public FontFamily FontFamily { get; set; }

        public string Icon { get; set; }

        public string Label { get; set; }

        public Type DestPage { get; set; }

        private SolidColorBrush color = new SolidColorBrush(Colors.White);
        public SolidColorBrush Color
        {
            get { return color; }
            set
            {
                color = value;
                this.OnPropertyChanged("Color");
            }
        }

        private Visibility selected = Visibility.Collapsed;
        public Visibility Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                this.OnPropertyChanged("Selected");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
