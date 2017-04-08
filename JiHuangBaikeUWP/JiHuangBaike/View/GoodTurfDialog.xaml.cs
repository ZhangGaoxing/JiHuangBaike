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
    public sealed partial class GoodTurfDialog : Page
    {
        public GoodTurfDialog(GoodTurf gt)
        {
            this.InitializeComponent();

            TurfImage.Source = new BitmapImage(new Uri(gt.Picture));
            TurfName.Text = gt.Name;
            TurfEnName.Text = gt.EnName;
            ROG.IsChecked = gt.IsROG;
            SW.IsChecked = gt.IsSW;
            DST.IsChecked = gt.IsDST;
            Texture.Source = new BitmapImage(new Uri(gt.Texture));
            TurfIntroduction.Text = gt.Introduction;
            Console.Text = gt.Console;
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText(Console.Text);
            Clipboard.SetContent(dataPackage);
        }
    }
}
