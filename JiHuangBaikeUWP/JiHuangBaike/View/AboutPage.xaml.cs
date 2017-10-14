using JiHuangBaike.Manager;
using Microsoft.Toolkit.Uwp.UI.Animations;
using System;
using System.Collections.Generic;
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

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace JiHuangBaike.View
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class AboutPage : Page
    {
        Style transparent = (Style)Application.Current.Resources["TransparentDialog"];

        public AboutPage()
        {
            this.InitializeComponent();
            var v = Windows.ApplicationModel.Package.Current.Id.Version;
            Version.Text = $"{v.Major}.{v.Minor}.{v.Build}.{v.Revision}";
            Publisher.Text = Windows.ApplicationModel.Package.Current.PublisherDisplayName;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (DeviceInfoManager.GetOsVersion() > 15063)
            {
                Windows.UI.Xaml.Media.AcrylicBrush myBrush = new Windows.UI.Xaml.Media.AcrylicBrush();
                myBrush.BackgroundSource = Windows.UI.Xaml.Media.AcrylicBackgroundSource.HostBackdrop;
                myBrush.FallbackColor = Colors.Transparent;
                myBrush.TintColor = Color.FromArgb(255, 15, 15, 15);
                myBrush.TintOpacity = 0.3;

                AboutGrid.Background = myBrush;

                Color brush = (Color)Application.Current.Resources["SystemAccentColor"];
                Windows.UI.Xaml.Media.AcrylicBrush appInfoBrush = new Windows.UI.Xaml.Media.AcrylicBrush();
                appInfoBrush.BackgroundSource = Windows.UI.Xaml.Media.AcrylicBackgroundSource.HostBackdrop;
                appInfoBrush.FallbackColor = Colors.Transparent;
                appInfoBrush.TintColor = brush;
                appInfoBrush.TintOpacity = 0.6;

                AppInfoGrid.Background = appInfoBrush;
                TitleGrid.Background = appInfoBrush;
            }
        }

        private async void AboutMe_Click(object sender, RoutedEventArgs e)
        {
            var contentDialog = new ContentDialog()
            {
                Content = new AboutMePage(),
                PrimaryButtonText = "确定",
                FullSizeDesired = true
            };

            contentDialog.Style = transparent;

            contentDialog.Closing += async (_s, _e) =>
            {
                await AboutGrid.Blur(0, 0, 0).StartAsync();
            };

            contentDialog.PrimaryButtonClick += async (_s, _e) =>
            {
                await AboutGrid.Blur(0, 0, 0).StartAsync();
                contentDialog.Hide();
            };

            await AboutGrid.Blur(10, 100, 0).StartAsync();

            await contentDialog.ShowAsync();
        }
    }
}
