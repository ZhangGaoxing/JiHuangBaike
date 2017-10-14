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
    public sealed partial class SkinPage : Page
    {
        private ObservableCollection<Skin> BodyData = new ObservableCollection<Skin>();
        private ObservableCollection<Skin> GloveData = new ObservableCollection<Skin>();
        private ObservableCollection<Skin> LegsData = new ObservableCollection<Skin>();
        private ObservableCollection<Skin> ShoeData = new ObservableCollection<Skin>();
        private ObservableCollection<Skin> CharacterSpecificData = new ObservableCollection<Skin>();
        private ObservableCollection<Skin> ItemData = new ObservableCollection<Skin>();
        private ObservableCollection<Skin> StructureData = new ObservableCollection<Skin>();
        private ObservableCollection<Skin> CritterData = new ObservableCollection<Skin>();

        Style transparent = (Style)Application.Current.Resources["TransparentDialog"];

        public SkinPage()
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
                SkinGrid.Background = myBrush;

                //Style style = (Style)Application.Current.Resources["GridViewItemRevealStyle"];
            }
        }
        public async void Deserialize()
        {
            Uri xmlUri = new Uri("ms-appx:///XML/Skin.xml");
            StorageFile xmlFile = await StorageFile.GetFileFromApplicationUriAsync(xmlUri);
            XmlDocument xml = await XmlDocument.LoadFromFileAsync(xmlFile);
            var bodyList = xml.DocumentElement.SelectNodes("Body")[0].SelectNodes("Skin");
            var gloveList = xml.DocumentElement.SelectNodes("Glove")[0].SelectNodes("Skin");
            var legsList = xml.DocumentElement.SelectNodes("Legs")[0].SelectNodes("Skin");
            var shoeList = xml.DocumentElement.SelectNodes("Shoe")[0].SelectNodes("Skin");
            var characterSpecificList = xml.DocumentElement.SelectNodes("CharacterSpecific")[0].SelectNodes("Skin");
            var itemList = xml.DocumentElement.SelectNodes("Item")[0].SelectNodes("Skin");
            var structureList = xml.DocumentElement.SelectNodes("Structure")[0].SelectNodes("Skin");
            var critterList = xml.DocumentElement.SelectNodes("Critter")[0].SelectNodes("Skin");

            foreach (var item in bodyList)
            {
                var childList = item.ChildNodes;

                Skin body = new Skin
                {
                    Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                    Name = childList[3].InnerText,
                    EnName = childList[5].InnerText,
                    Introduction = childList[9].InnerText
                };

                switch (childList[7].InnerText)
                {
                    case "Common":
                        {
                            body.Rarity = "普通的 Common";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x97, 0xB2, 0xB9));
                        }
                        break;

                    case "Classy":
                        {
                            body.Rarity = "上等的 Classy";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x41, 0x50, 0x78));
                        }
                        break;

                    case "Spiffy":
                        {
                            body.Rarity = "漂亮的 Spiffy";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x68, 0x45, 0x7C));
                        }
                        break;

                    case "Distinguished":
                        {
                            body.Rarity = "卓越的 Distinguished";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xBA, 0x74, 0xA5));
                        }
                        break;

                    case "Elegant":
                        {
                            body.Rarity = "优雅的 Elegant";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xBD, 0x46, 0x46));
                        }
                        break;

                    case "Loyal":
                        {
                            body.Rarity = "忠诚的 Loyal";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x92, 0xB4, 0x5F));
                        }
                        break;

                    case "Timeless":
                        {
                            body.Rarity = "永恒的 Timeless";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x6C, 0xC1, 0x7E));
                        }
                        break;

                    case "Event":
                        {
                            body.Rarity = "事件 Event";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xB4, 0x94, 0x00));
                        }
                        break;
                }

                BodyData.Add(body);
            }

            foreach (var item in gloveList)
            {
                var childList = item.ChildNodes;

                Skin body = new Skin
                {
                    Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                    Name = childList[3].InnerText,
                    EnName = childList[5].InnerText,
                    Introduction = childList[9].InnerText
                };

                switch (childList[7].InnerText)
                {
                    case "Common":
                        {
                            body.Rarity = "普通的 Common";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x97, 0xB2, 0xB9));
                        }
                        break;

                    case "Classy":
                        {
                            body.Rarity = "上等的 Classy";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x41, 0x50, 0x78));
                        }
                        break;

                    case "Spiffy":
                        {
                            body.Rarity = "漂亮的 Spiffy";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x68, 0x45, 0x7C));
                        }
                        break;

                    case "Distinguished":
                        {
                            body.Rarity = "卓越的 Distinguished";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xBA, 0x74, 0xA5));
                        }
                        break;

                    case "Elegant":
                        {
                            body.Rarity = "优雅的 Elegant";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xBD, 0x46, 0x46));
                        }
                        break;

                    case "Loyal":
                        {
                            body.Rarity = "忠诚的 Loyal";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x92, 0xB4, 0x5F));
                        }
                        break;

                    case "Timeless":
                        {
                            body.Rarity = "永恒的 Timeless";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x6C, 0xC1, 0x7E));
                        }
                        break;

                    case "Event":
                        {
                            body.Rarity = "事件 Event";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xB4, 0x94, 0x00));
                        }
                        break;
                }

                GloveData.Add(body);
            }

            foreach (var item in legsList)
            {
                var childList = item.ChildNodes;

                Skin body = new Skin
                {
                    Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                    Name = childList[3].InnerText,
                    EnName = childList[5].InnerText,
                    Introduction = childList[9].InnerText
                };

                switch (childList[7].InnerText)
                {
                    case "Common":
                        {
                            body.Rarity = "普通的 Common";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x97, 0xB2, 0xB9));
                        }
                        break;

                    case "Classy":
                        {
                            body.Rarity = "上等的 Classy";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x41, 0x50, 0x78));
                        }
                        break;

                    case "Spiffy":
                        {
                            body.Rarity = "漂亮的 Spiffy";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x68, 0x45, 0x7C));
                        }
                        break;

                    case "Distinguished":
                        {
                            body.Rarity = "卓越的 Distinguished";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xBA, 0x74, 0xA5));
                        }
                        break;

                    case "Elegant":
                        {
                            body.Rarity = "优雅的 Elegant";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xBD, 0x46, 0x46));
                        }
                        break;

                    case "Loyal":
                        {
                            body.Rarity = "忠诚的 Loyal";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x92, 0xB4, 0x5F));
                        }
                        break;

                    case "Timeless":
                        {
                            body.Rarity = "永恒的 Timeless";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x6C, 0xC1, 0x7E));
                        }
                        break;

                    case "Event":
                        {
                            body.Rarity = "事件 Event";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xB4, 0x94, 0x00));
                        }
                        break;
                }

                LegsData.Add(body);
            }

            foreach (var item in shoeList)
            {
                var childList = item.ChildNodes;

                Skin body = new Skin
                {
                    Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                    Name = childList[3].InnerText,
                    EnName = childList[5].InnerText,
                    Introduction = childList[9].InnerText
                };

                switch (childList[7].InnerText)
                {
                    case "Common":
                        {
                            body.Rarity = "普通的 Common";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x97, 0xB2, 0xB9));
                        }
                        break;

                    case "Classy":
                        {
                            body.Rarity = "上等的 Classy";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x41, 0x50, 0x78));
                        }
                        break;

                    case "Spiffy":
                        {
                            body.Rarity = "漂亮的 Spiffy";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x68, 0x45, 0x7C));
                        }
                        break;

                    case "Distinguished":
                        {
                            body.Rarity = "卓越的 Distinguished";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xBA, 0x74, 0xA5));
                        }
                        break;

                    case "Elegant":
                        {
                            body.Rarity = "优雅的 Elegant";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xBD, 0x46, 0x46));
                        }
                        break;

                    case "Loyal":
                        {
                            body.Rarity = "忠诚的 Loyal";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x92, 0xB4, 0x5F));
                        }
                        break;

                    case "Timeless":
                        {
                            body.Rarity = "永恒的 Timeless";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x6C, 0xC1, 0x7E));
                        }
                        break;

                    case "Event":
                        {
                            body.Rarity = "事件 Event";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xB4, 0x94, 0x00));
                        }
                        break;
                }

                ShoeData.Add(body);
            }

            foreach (var item in characterSpecificList)
            {
                var childList = item.ChildNodes;

                Skin body = new Skin
                {
                    Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                    Name = childList[3].InnerText,
                    EnName = childList[5].InnerText,
                    Introduction = childList[9].InnerText
                };

                switch (childList[7].InnerText)
                {
                    case "Common":
                        {
                            body.Rarity = "普通的 Common";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x97, 0xB2, 0xB9));
                        }
                        break;

                    case "Classy":
                        {
                            body.Rarity = "上等的 Classy";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x41, 0x50, 0x78));
                        }
                        break;

                    case "Spiffy":
                        {
                            body.Rarity = "漂亮的 Spiffy";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x68, 0x45, 0x7C));
                        }
                        break;

                    case "Distinguished":
                        {
                            body.Rarity = "卓越的 Distinguished";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xBA, 0x74, 0xA5));
                        }
                        break;

                    case "Elegant":
                        {
                            body.Rarity = "优雅的 Elegant";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xBD, 0x46, 0x46));
                        }
                        break;

                    case "Loyal":
                        {
                            body.Rarity = "忠诚的 Loyal";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x92, 0xB4, 0x5F));
                        }
                        break;

                    case "Timeless":
                        {
                            body.Rarity = "永恒的 Timeless";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x6C, 0xC1, 0x7E));
                        }
                        break;

                    case "Event":
                        {
                            body.Rarity = "事件 Event";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xB4, 0x94, 0x00));
                        }
                        break;
                }

                CharacterSpecificData.Add(body);
            }

            foreach (var item in itemList)
            {
                var childList = item.ChildNodes;

                Skin body = new Skin
                {
                    Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                    Name = childList[3].InnerText,
                    EnName = childList[5].InnerText,
                    Introduction = childList[9].InnerText
                };

                switch (childList[7].InnerText)
                {
                    case "Common":
                        {
                            body.Rarity = "普通的 Common";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x97, 0xB2, 0xB9));
                        }
                        break;

                    case "Classy":
                        {
                            body.Rarity = "上等的 Classy";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x41, 0x50, 0x78));
                        }
                        break;

                    case "Spiffy":
                        {
                            body.Rarity = "漂亮的 Spiffy";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x68, 0x45, 0x7C));
                        }
                        break;

                    case "Distinguished":
                        {
                            body.Rarity = "卓越的 Distinguished";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xBA, 0x74, 0xA5));
                        }
                        break;

                    case "Elegant":
                        {
                            body.Rarity = "优雅的 Elegant";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xBD, 0x46, 0x46));
                        }
                        break;

                    case "Loyal":
                        {
                            body.Rarity = "忠诚的 Loyal";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x92, 0xB4, 0x5F));
                        }
                        break;

                    case "Timeless":
                        {
                            body.Rarity = "永恒的 Timeless";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x6C, 0xC1, 0x7E));
                        }
                        break;

                    case "Event":
                        {
                            body.Rarity = "事件 Event";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xB4, 0x94, 0x00));
                        }
                        break;
                }

                ItemData.Add(body);
            }

            foreach (var item in structureList)
            {
                var childList = item.ChildNodes;

                Skin body = new Skin
                {
                    Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                    Name = childList[3].InnerText,
                    EnName = childList[5].InnerText,
                    Introduction = childList[9].InnerText
                };

                switch (childList[7].InnerText)
                {
                    case "Common":
                        {
                            body.Rarity = "普通的 Common";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x97, 0xB2, 0xB9));
                        }
                        break;

                    case "Classy":
                        {
                            body.Rarity = "上等的 Classy";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x41, 0x50, 0x78));
                        }
                        break;

                    case "Spiffy":
                        {
                            body.Rarity = "漂亮的 Spiffy";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x68, 0x45, 0x7C));
                        }
                        break;

                    case "Distinguished":
                        {
                            body.Rarity = "卓越的 Distinguished";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xBA, 0x74, 0xA5));
                        }
                        break;

                    case "Elegant":
                        {
                            body.Rarity = "优雅的 Elegant";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xBD, 0x46, 0x46));
                        }
                        break;

                    case "Loyal":
                        {
                            body.Rarity = "忠诚的 Loyal";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x92, 0xB4, 0x5F));
                        }
                        break;

                    case "Timeless":
                        {
                            body.Rarity = "永恒的 Timeless";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x6C, 0xC1, 0x7E));
                        }
                        break;

                    case "Event":
                        {
                            body.Rarity = "事件 Event";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xB4, 0x94, 0x00));
                        }
                        break;
                }

                StructureData.Add(body);
            }

            foreach (var item in critterList)
            {
                var childList = item.ChildNodes;

                Skin body = new Skin
                {
                    Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                    Name = childList[3].InnerText,
                    EnName = childList[5].InnerText,
                    Introduction = childList[9].InnerText
                };

                switch (childList[7].InnerText)
                {
                    case "Common":
                        {
                            body.Rarity = "普通的 Common";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x97, 0xB2, 0xB9));
                        }
                        break;

                    case "Classy":
                        {
                            body.Rarity = "上等的 Classy";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x41, 0x50, 0x78));
                        }
                        break;

                    case "Spiffy":
                        {
                            body.Rarity = "漂亮的 Spiffy";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x68, 0x45, 0x7C));
                        }
                        break;

                    case "Distinguished":
                        {
                            body.Rarity = "卓越的 Distinguished";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xBA, 0x74, 0xA5));
                        }
                        break;

                    case "Elegant":
                        {
                            body.Rarity = "优雅的 Elegant";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xBD, 0x46, 0x46));
                        }
                        break;

                    case "Loyal":
                        {
                            body.Rarity = "忠诚的 Loyal";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x92, 0xB4, 0x5F));
                        }
                        break;

                    case "Timeless":
                        {
                            body.Rarity = "永恒的 Timeless";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0x6C, 0xC1, 0x7E));
                        }
                        break;

                    case "Event":
                        {
                            body.Rarity = "事件 Event";
                            body.Color = new SolidColorBrush(Color.FromArgb(255, 0xB4, 0x94, 0x00));
                        }
                        break;
                }

                CritterData.Add(body);
            }
        }

        private async void SkinGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Skin s = e.ClickedItem as Skin;

            var contentDialog = new ContentDialog()
            {
                Content = new SkinDialog(s),
                PrimaryButtonText = "确定",
                FullSizeDesired = false
            };

            contentDialog.Style = transparent;

            contentDialog.Closed += async (_s, _e) =>
            {
                await SkinGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };

            contentDialog.PrimaryButtonClick += async (_s, _e) =>
            {
                await SkinGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };
            await SkinGrid.Blur(value: 7, duration: 100, delay: 0).StartAsync();

            await contentDialog.ShowAsync();
        }
    }
}
