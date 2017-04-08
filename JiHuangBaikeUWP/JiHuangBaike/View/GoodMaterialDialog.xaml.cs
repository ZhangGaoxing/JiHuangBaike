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
    public sealed partial class GoodMaterialDialog : Page
    {
        private ObservableCollection<BindingImage> scienceData = new ObservableCollection<BindingImage>();
        private ObservableCollection<BindingImage> creatureData = new ObservableCollection<BindingImage>();

        public GoodMaterialDialog(GoodMaterial gm)
        {
            this.InitializeComponent();

            GetImage(gm);
            MaterialImage.Source = new BitmapImage(new Uri(gm.Picture));
            MaterialName.Text = gm.Name;
            MaterialEnName.Text = gm.EnName;
            ROG.IsChecked = gm.IsROG;
            SW.IsChecked = gm.IsSW;
            DST.IsChecked = gm.IsDST;
            MaterialIntroduction.Text = gm.Introduction;
            Console.Text = gm.Console;
        }

        public void GetImage(GoodMaterial gm)
        {
            foreach (var item in gm.Science)
            {
                scienceData.Add(
                    new BindingImage
                    {
                        ImagePath = $"ms-appx:///Assets/GameResources/{item}.png"
                    });
            }

            foreach (var item in gm.Creature)
            {
                creatureData.Add(
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
