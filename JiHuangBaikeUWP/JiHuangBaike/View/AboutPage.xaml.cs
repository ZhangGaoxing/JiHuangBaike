using Microsoft.Toolkit.Uwp.UI.Animations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
