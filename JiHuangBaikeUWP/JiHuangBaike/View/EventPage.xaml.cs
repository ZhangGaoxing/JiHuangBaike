using JiHuangBaike.Data;
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
    public sealed partial class EventPage : Page
    {
        private ObservableCollection<Event> HallowedNightsData = new ObservableCollection<Event>();
        private ObservableCollection<Event> WintersFeastData = new ObservableCollection<Event>();
        private ObservableCollection<Event> GobblertData = new ObservableCollection<Event>();

        Style transparent = (Style)Application.Current.Resources["TransparentDialog"];

        public EventPage()
        {
            this.InitializeComponent();

            Deserialize();
        }

        public async void Deserialize()
        {
            Uri xmlUri = new Uri("ms-appx:///XML/Events.xml");
            StorageFile xmlFile = await StorageFile.GetFileFromApplicationUriAsync(xmlUri);
            XmlDocument xml = await XmlDocument.LoadFromFileAsync(xmlFile);
            var hallowedNightsList = xml.DocumentElement.SelectNodes("HallowedNights")[0].SelectNodes("Good");
            var wintersFeastList = xml.DocumentElement.SelectNodes("WintersFeast")[0].SelectNodes("Good");
            var gobblertList = xml.DocumentElement.SelectNodes("YearOfTheGobbler")[0].SelectNodes("Good");

            foreach (var item in hallowedNightsList)
            {
                var childList = item.ChildNodes;
                HallowedNightsData.Add(
                    new Event
                    {
                        Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[7].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[9].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[11].InnerText)),
                        Introduction = childList[13].InnerText,
                        Console = $@"c_give(""{childList[15].InnerText}"",1)"
                    });
            }

            foreach (var item in wintersFeastList)
            {
                var childList = item.ChildNodes;
                WintersFeastData.Add(
                    new Event
                    {
                        Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[7].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[9].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[11].InnerText)),
                        Introduction = childList[13].InnerText,
                        Console = $@"c_give(""{childList[15].InnerText}"",1)"
                    });
            }

            foreach (var item in gobblertList)
            {
                var childList = item.ChildNodes;
                GobblertData.Add(
                    new Event
                    {
                        Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[7].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[9].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[11].InnerText)),
                        Introduction = childList[13].InnerText,
                        Console = $@"c_give(""{childList[15].InnerText}"",1)"
                    });
            }
        }

            private async void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Event ev = e.ClickedItem as Event;

            var contentDialog = new ContentDialog()
            {
                Content = new EventDialog(ev),
                PrimaryButtonText = "确定",
                FullSizeDesired = false
            };

            contentDialog.Style = transparent;

            contentDialog.Closed += async (_s, _e) =>
            {
                await EventGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };

            contentDialog.PrimaryButtonClick += async (_s, _e) =>
            {
                await EventGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };
            await EventGrid.Blur(value: 7, duration: 200, delay: 0).StartAsync();

            await contentDialog.ShowAsync();
        }
    }
}
