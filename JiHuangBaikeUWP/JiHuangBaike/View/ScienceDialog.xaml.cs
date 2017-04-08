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
    public sealed partial class ScienceDialog : Page
    {
        public ScienceDialog(Science s)
        {
            this.InitializeComponent();

            ScienceImage.Source = new BitmapImage(new Uri(s.Image));
            ScienceName.Text = s.Name;
            ScienceEnName.Text = s.EnName;
            Need1.Source = new BitmapImage(new Uri(s.Need1));
            Need1Value.Text = "×" + s.Need1Value;
            if (s.Need2Value != 0)
            {
                Need2.Source = new BitmapImage(new Uri(s.Need2));
                Need2Value.Text = "×" + s.Need2Value;
            }
            if (s.Need3Value != 0)
            {
                Need3.Source = new BitmapImage(new Uri(s.Need3));
                if (s.Need3Value < 0)
                {
                    if (s.Need3Value == -20 || s.Need3Value == -35)
                    {
                        Need3Value.Text = s.Need3Value.ToString() + "%";
                    }
                    else
                    {
                        Need3Value.Text = s.Need3Value.ToString();
                    }
                }
                else
                {
                    Need3Value.Text = "×" + s.Need3Value;
                }
            }
            ROG.IsChecked = s.IsROG;
            SW.IsChecked = s.IsSW;
            DST.IsChecked = s.IsDST;
            UnLock.Source = new BitmapImage(new Uri(s.Unlock));
            ScienceIntroduction.Text = s.Introduction;
            Console.Text = s.Console;
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText(Console.Text);
            Clipboard.SetContent(dataPackage);
        }
    }
}
