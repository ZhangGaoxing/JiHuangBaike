using JiHuangBaike.Data;
using JiHuangBaike.Manager;
using Microsoft.Toolkit.Uwp.UI.Animations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
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
    public sealed partial class NaturalPage : Page
    {
        private ObservableCollection<NatureArea> AreaData = new ObservableCollection<NatureArea>();

        Style transparent = (Style)Application.Current.Resources["TransparentDialog"];

        public NaturalPage()
        {
            this.InitializeComponent();
            Deserialize();
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

                TitleGrid.Background = myBrush;
                NatureGrid.Background = myBrush;

                //Style style = (Style)Application.Current.Resources["GridViewItemRevealStyle"];
            }
        }
        public async void Deserialize()
        {
            Uri xmlUri = new Uri("ms-appx:///XML/Natures.xml");
            StorageFile xmlFile = await StorageFile.GetFileFromApplicationUriAsync(xmlUri);
            XmlDocument xml = await XmlDocument.LoadFromFileAsync(xmlFile);
            var areaList = xml.DocumentElement.SelectNodes("Area")[0].SelectNodes("Nature");

            foreach (var item in areaList)
            {
                var childList = item.ChildNodes;
                AreaData.Add(
                    new NatureArea
                    {
                        Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Abundant = childList[7].InnerText.Split(','),
                        Occasional = childList[9].InnerText.Split(','),
                        Rare = childList[11].InnerText.Split(','),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[13].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[15].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[17].InnerText)),
                        Introduction = childList[19].InnerText,
                    });
            }
        }

        private async void AreaGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            NatureArea na = e.ClickedItem as NatureArea;

            var contentDialog = new ContentDialog()
            {
                Content = new NatureAreaDialog(na),
                PrimaryButtonText = "确定",
                FullSizeDesired = false
            };

            contentDialog.Style = transparent;

            contentDialog.Closed += async (_s, _e) =>
            {
                await NatureGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };

            contentDialog.PrimaryButtonClick += async (_s, _e) =>
            {
                await NatureGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };
            await NatureGrid.Blur(value: 7, duration: 100, delay: 0).StartAsync();

            await contentDialog.ShowAsync();
        }
    }
}
