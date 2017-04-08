using JiHuangBaike.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class GoodPlantDialog : Page
    {
        private ObservableCollection<BindingImage> PlantData = new ObservableCollection<BindingImage>();

        public GoodPlantDialog(GoodPlant gp)
        {
            this.InitializeComponent();

            GetImage(gp);
            PlantImage.Source = new BitmapImage(new Uri(gp.Picture));
            PlantName.Text = gp.Name;
            PlantEnName.Text = gp.EnName;
            ROG.IsChecked = gp.IsROG;
            SW.IsChecked = gp.IsSW;
            DST.IsChecked = gp.IsDST;
            PlantIntroduction.Text = gp.Introduction;
            Console.Text = gp.Console;
        }

        public void GetImage(GoodPlant gp)
        {
            foreach (var item in gp.Creature)
            {
                PlantData.Add(
                    new BindingImage
                    {
                        ImagePath = $"ms-appx:///Assets/GameResources/{item}.png"
                    });
            }
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText(Console.Text);
            Clipboard.SetContent(dataPackage);
        }
    }
}
