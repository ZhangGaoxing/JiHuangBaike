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
    public sealed partial class GoodCreatureDialog : Page
    {
        public GoodCreatureDialog(GoodCreature gc)
        {
            this.InitializeComponent();

            CreatureImage.Source = new BitmapImage(new Uri(gc.Picture));
            CreatureName.Text = gc.Name;
            CreatureEnName.Text = gc.EnName;
            ROG.IsChecked = gc.IsROG;
            SW.IsChecked = gc.IsSW;
            DST.IsChecked = gc.IsDST;
            CreatureFresh.Text = gc.Fresh;
            Console.Text = gc.Console;
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText(Console.Text);
            Clipboard.SetContent(dataPackage);
        }
    }
}
