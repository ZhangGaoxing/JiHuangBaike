using JiHuangBaike.Data;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace JiHuangBaike.View
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class FoodDialog : Page
    {
        public FoodDialog(Food f)
        {
            this.InitializeComponent();

            FoodImage.Source = new BitmapImage(new Uri(f.Image));
            FoodName.Text = f.Name;
            FoodEnName.Text = f.EnName;
            Hunger.Values = new ChartValues<double>(new double[] { f.Hunger });
            Health.Values = new ChartValues<double>(new double[] { f.Health });
            Sanity.Values = new ChartValues<double>(new double[] { f.Sanity });
            Perish.Values = new ChartValues<double>(new double[] { f.Perish });
            try
            {
                Attribute.Source = new BitmapImage(new Uri(f.Attribute));
                AttributeValue.Text = f.AttributeValue;
            }
            catch (Exception)
            {
                AttributeValue.Text = f.Attribute;
            }
            FoodIntroduction.Text = f.Introduction;
            Console.Text = f.Console;
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText(Console.Text);
            Clipboard.SetContent(dataPackage);
        }
    }
}
