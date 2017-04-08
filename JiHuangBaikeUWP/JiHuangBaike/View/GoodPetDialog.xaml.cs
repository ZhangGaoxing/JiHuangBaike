using JiHuangBaike.Data;
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
    public sealed partial class GoodPetDialog : Page
    {
        public GoodPetDialog(GoodPet gp)
        {
            this.InitializeComponent();

            PetImage.Source = new BitmapImage(new Uri(gp.Picture));
            PetName.Text = gp.Name;
            PetEnName.Text = gp.EnName;
            ROG.IsChecked = gp.IsROG;
            SW.IsChecked = gp.IsSW;
            DST.IsChecked = gp.IsDST;
            Dead.Source = new BitmapImage(new Uri(gp.Dead));
            Follow.Source = new BitmapImage(new Uri(gp.Follow));
            PetIntroduction.Text = gp.Introduction;
            Console.Text = gp.Console;
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText(Console.Text);
            Clipboard.SetContent(dataPackage);
        }
    }
}
