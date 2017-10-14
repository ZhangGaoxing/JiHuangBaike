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
    public sealed partial class SciencePage : Page
    {
        private ObservableCollection<Science> toolData = new ObservableCollection<Science>();
        private ObservableCollection<Science> lightData = new ObservableCollection<Science>();
        private ObservableCollection<Science> survivalData = new ObservableCollection<Science>();
        private ObservableCollection<Science> foodData = new ObservableCollection<Science>();
        private ObservableCollection<Science> technologyData = new ObservableCollection<Science>();
        private ObservableCollection<Science> fightData = new ObservableCollection<Science>();
        private ObservableCollection<Science> structureData = new ObservableCollection<Science>();
        private ObservableCollection<Science> refineData = new ObservableCollection<Science>();
        private ObservableCollection<Science> magicData = new ObservableCollection<Science>();
        private ObservableCollection<Science> dressData = new ObservableCollection<Science>();
        private ObservableCollection<Science> ancientData = new ObservableCollection<Science>();
        private ObservableCollection<Science> bookData = new ObservableCollection<Science>();
        private ObservableCollection<Science> shadowData = new ObservableCollection<Science>();
        private ObservableCollection<Science> crittersData = new ObservableCollection<Science>();
        private ObservableCollection<Science> sculptData = new ObservableCollection<Science>();
        private ObservableCollection<Science> cartographyData = new ObservableCollection<Science>();

        Style transparent = (Style)Application.Current.Resources["TransparentDialog"];

        public SciencePage()
        {
            this.InitializeComponent();
            Deserialize(); ;
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
                ScienceGrid.Background = myBrush;

                //Style style = (Style)Application.Current.Resources["GridViewItemRevealStyle"];
            }
        }
        public async void Deserialize()
        {
            Uri xmlUri = new Uri("ms-appx:///XML/Science.xml");
            StorageFile xmlFile = await StorageFile.GetFileFromApplicationUriAsync(xmlUri);
            XmlDocument xml = await XmlDocument.LoadFromFileAsync(xmlFile);
            var toolList = xml.DocumentElement.SelectNodes("Tool")[0].SelectNodes("Science");
            var lightingList = xml.DocumentElement.SelectNodes("Light")[0].SelectNodes("Science");
            var livingList = xml.DocumentElement.SelectNodes("Survival")[0].SelectNodes("Science");
            var foodList = xml.DocumentElement.SelectNodes("Food")[0].SelectNodes("Science");
            var technologyList = xml.DocumentElement.SelectNodes("Technology")[0].SelectNodes("Science");
            var fightList = xml.DocumentElement.SelectNodes("Fight")[0].SelectNodes("Science");
            var structureList = xml.DocumentElement.SelectNodes("Structure")[0].SelectNodes("Science");
            var refineList = xml.DocumentElement.SelectNodes("Refine")[0].SelectNodes("Science");
            var magicList = xml.DocumentElement.SelectNodes("Magic")[0].SelectNodes("Science");
            var dressList = xml.DocumentElement.SelectNodes("Dress")[0].SelectNodes("Science");
            var ancientList = xml.DocumentElement.SelectNodes("Ancient")[0].SelectNodes("Science");
            var bookList = xml.DocumentElement.SelectNodes("Book")[0].SelectNodes("Science");
            var shadowList = xml.DocumentElement.SelectNodes("Shadow")[0].SelectNodes("Science");
            var crittersList = xml.DocumentElement.SelectNodes("Critter")[0].SelectNodes("Science");
            var sculptList = xml.DocumentElement.SelectNodes("Sculpt")[0].SelectNodes("Science");
            var cartographyList = xml.DocumentElement.SelectNodes("Cartography")[0].SelectNodes("Science");

            foreach (var item in toolList)
            {
                var childList = item.ChildNodes;
                toolData.Add(
                    new Science
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Need1 = $"ms-appx:///Assets/GameResources/{childList[7].InnerText}.png",
                        Need1Value = Convert.ToInt32(childList[9].InnerText),
                        Need2 = $"ms-appx:///Assets/GameResources/{childList[11].InnerText}.png",
                        Need2Value = Convert.ToInt32(childList[13].InnerText),
                        Need3 = $"ms-appx:///Assets/GameResources/{childList[15].InnerText}.png",
                        Need3Value = Convert.ToInt32(childList[17].InnerText),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[19].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[21].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[23].InnerText)),
                        Unlock = $"ms-appx:///Assets/GameResources/{childList[25].InnerText}.png",
                        Introduction = childList[27].InnerText,
                        Console = $@"c_give(""{childList[29].InnerText}"",1)"
                    });
            }

            foreach (var item in lightingList)
            {
                var childList = item.ChildNodes;
                lightData.Add(
                    new Science
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Need1 = $"ms-appx:///Assets/GameResources/{childList[7].InnerText}.png",
                        Need1Value = Convert.ToInt32(childList[9].InnerText),
                        Need2 = $"ms-appx:///Assets/GameResources/{childList[11].InnerText}.png",
                        Need2Value = Convert.ToInt32(childList[13].InnerText),
                        Need3 = $"ms-appx:///Assets/GameResources/{childList[15].InnerText}.png",
                        Need3Value = Convert.ToInt32(childList[17].InnerText),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[19].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[21].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[23].InnerText)),
                        Unlock = $"ms-appx:///Assets/GameResources/{childList[25].InnerText}.png",
                        Introduction = childList[27].InnerText,
                        Console = $@"c_give(""{childList[29].InnerText}"",1)"
                    });
            }

            foreach (var item in livingList)
            {
                var childList = item.ChildNodes;
                survivalData.Add(
                    new Science
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Need1 = $"ms-appx:///Assets/GameResources/{childList[7].InnerText}.png",
                        Need1Value = Convert.ToInt32(childList[9].InnerText),
                        Need2 = $"ms-appx:///Assets/GameResources/{childList[11].InnerText}.png",
                        Need2Value = Convert.ToInt32(childList[13].InnerText),
                        Need3 = $"ms-appx:///Assets/GameResources/{childList[15].InnerText}.png",
                        Need3Value = Convert.ToInt32(childList[17].InnerText),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[19].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[21].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[23].InnerText)),
                        Unlock = $"ms-appx:///Assets/GameResources/{childList[25].InnerText}.png",
                        Introduction = childList[27].InnerText,
                        Console = $@"c_give(""{childList[29].InnerText}"",1)"
                    });
            }

            foreach (var item in foodList)
            {
                var childList = item.ChildNodes;
                foodData.Add(
                    new Science
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Need1 = $"ms-appx:///Assets/GameResources/{childList[7].InnerText}.png",
                        Need1Value = Convert.ToInt32(childList[9].InnerText),
                        Need2 = $"ms-appx:///Assets/GameResources/{childList[11].InnerText}.png",
                        Need2Value = Convert.ToInt32(childList[13].InnerText),
                        Need3 = $"ms-appx:///Assets/GameResources/{childList[15].InnerText}.png",
                        Need3Value = Convert.ToInt32(childList[17].InnerText),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[19].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[21].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[23].InnerText)),
                        Unlock = $"ms-appx:///Assets/GameResources/{childList[25].InnerText}.png",
                        Introduction = childList[27].InnerText,
                        Console = $@"c_give(""{childList[29].InnerText}"",1)"
                    });
            }

            foreach (var item in technologyList)
            {
                var childList = item.ChildNodes;
                technologyData.Add(
                    new Science
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Need1 = $"ms-appx:///Assets/GameResources/{childList[7].InnerText}.png",
                        Need1Value = Convert.ToInt32(childList[9].InnerText),
                        Need2 = $"ms-appx:///Assets/GameResources/{childList[11].InnerText}.png",
                        Need2Value = Convert.ToInt32(childList[13].InnerText),
                        Need3 = $"ms-appx:///Assets/GameResources/{childList[15].InnerText}.png",
                        Need3Value = Convert.ToInt32(childList[17].InnerText),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[19].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[21].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[23].InnerText)),
                        Unlock = $"ms-appx:///Assets/GameResources/{childList[25].InnerText}.png",
                        Introduction = childList[27].InnerText,
                        Console = $@"c_give(""{childList[29].InnerText}"",1)"
                    });
            }

            foreach (var item in fightList)
            {
                var childList = item.ChildNodes;
                fightData.Add(
                    new Science
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Need1 = $"ms-appx:///Assets/GameResources/{childList[7].InnerText}.png",
                        Need1Value = Convert.ToInt32(childList[9].InnerText),
                        Need2 = $"ms-appx:///Assets/GameResources/{childList[11].InnerText}.png",
                        Need2Value = Convert.ToInt32(childList[13].InnerText),
                        Need3 = $"ms-appx:///Assets/GameResources/{childList[15].InnerText}.png",
                        Need3Value = Convert.ToInt32(childList[17].InnerText),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[19].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[21].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[23].InnerText)),
                        Unlock = $"ms-appx:///Assets/GameResources/{childList[25].InnerText}.png",
                        Introduction = childList[27].InnerText,
                        Console = $@"c_give(""{childList[29].InnerText}"",1)"
                    });
            }

            foreach (var item in structureList)
            {
                var childList = item.ChildNodes;
                structureData.Add(
                    new Science
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Need1 = $"ms-appx:///Assets/GameResources/{childList[7].InnerText}.png",
                        Need1Value = Convert.ToInt32(childList[9].InnerText),
                        Need2 = $"ms-appx:///Assets/GameResources/{childList[11].InnerText}.png",
                        Need2Value = Convert.ToInt32(childList[13].InnerText),
                        Need3 = $"ms-appx:///Assets/GameResources/{childList[15].InnerText}.png",
                        Need3Value = Convert.ToInt32(childList[17].InnerText),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[19].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[21].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[23].InnerText)),
                        Unlock = $"ms-appx:///Assets/GameResources/{childList[25].InnerText}.png",
                        Introduction = childList[27].InnerText,
                        Console = $@"c_give(""{childList[29].InnerText}"",1)"
                    });
            }

            foreach (var item in refineList)
            {
                var childList = item.ChildNodes;
                refineData.Add(
                    new Science
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Need1 = $"ms-appx:///Assets/GameResources/{childList[7].InnerText}.png",
                        Need1Value = Convert.ToInt32(childList[9].InnerText),
                        Need2 = $"ms-appx:///Assets/GameResources/{childList[11].InnerText}.png",
                        Need2Value = Convert.ToInt32(childList[13].InnerText),
                        Need3 = $"ms-appx:///Assets/GameResources/{childList[15].InnerText}.png",
                        Need3Value = Convert.ToInt32(childList[17].InnerText),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[19].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[21].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[23].InnerText)),
                        Unlock = $"ms-appx:///Assets/GameResources/{childList[25].InnerText}.png",
                        Introduction = childList[27].InnerText,
                        Console = $@"c_give(""{childList[29].InnerText}"",1)"
                    });
            }

            foreach (var item in magicList)
            {
                var childList = item.ChildNodes;
                magicData.Add(
                    new Science
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Need1 = $"ms-appx:///Assets/GameResources/{childList[7].InnerText}.png",
                        Need1Value = Convert.ToInt32(childList[9].InnerText),
                        Need2 = $"ms-appx:///Assets/GameResources/{childList[11].InnerText}.png",
                        Need2Value = Convert.ToInt32(childList[13].InnerText),
                        Need3 = $"ms-appx:///Assets/GameResources/{childList[15].InnerText}.png",
                        Need3Value = Convert.ToInt32(childList[17].InnerText),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[19].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[21].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[23].InnerText)),
                        Unlock = $"ms-appx:///Assets/GameResources/{childList[25].InnerText}.png",
                        Introduction = childList[27].InnerText,
                        Console = $@"c_give(""{childList[29].InnerText}"",1)"
                    });
            }

            foreach (var item in dressList)
            {
                var childList = item.ChildNodes;
                dressData.Add(
                    new Science
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Need1 = $"ms-appx:///Assets/GameResources/{childList[7].InnerText}.png",
                        Need1Value = Convert.ToInt32(childList[9].InnerText),
                        Need2 = $"ms-appx:///Assets/GameResources/{childList[11].InnerText}.png",
                        Need2Value = Convert.ToInt32(childList[13].InnerText),
                        Need3 = $"ms-appx:///Assets/GameResources/{childList[15].InnerText}.png",
                        Need3Value = Convert.ToInt32(childList[17].InnerText),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[19].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[21].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[23].InnerText)),
                        Unlock = $"ms-appx:///Assets/GameResources/{childList[25].InnerText}.png",
                        Introduction = childList[27].InnerText,
                        Console = $@"c_give(""{childList[29].InnerText}"",1)"
                    });
            }

            foreach (var item in ancientList)
            {
                var childList = item.ChildNodes;
                ancientData.Add(
                    new Science
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Need1 = $"ms-appx:///Assets/GameResources/{childList[7].InnerText}.png",
                        Need1Value = Convert.ToInt32(childList[9].InnerText),
                        Need2 = $"ms-appx:///Assets/GameResources/{childList[11].InnerText}.png",
                        Need2Value = Convert.ToInt32(childList[13].InnerText),
                        Need3 = $"ms-appx:///Assets/GameResources/{childList[15].InnerText}.png",
                        Need3Value = Convert.ToInt32(childList[17].InnerText),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[19].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[21].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[23].InnerText)),
                        Unlock = $"ms-appx:///Assets/GameResources/{childList[25].InnerText}.png",
                        Introduction = childList[27].InnerText,
                        Console = $@"c_give(""{childList[29].InnerText}"",1)"
                    });
            }

            foreach (var item in bookList)
            {
                var childList = item.ChildNodes;
                bookData.Add(
                    new Science
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Need1 = $"ms-appx:///Assets/GameResources/{childList[7].InnerText}.png",
                        Need1Value = Convert.ToInt32(childList[9].InnerText),
                        Need2 = $"ms-appx:///Assets/GameResources/{childList[11].InnerText}.png",
                        Need2Value = Convert.ToInt32(childList[13].InnerText),
                        Need3 = $"ms-appx:///Assets/GameResources/{childList[15].InnerText}.png",
                        Need3Value = Convert.ToInt32(childList[17].InnerText),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[19].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[21].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[23].InnerText)),
                        Unlock = $"ms-appx:///Assets/GameResources/{childList[25].InnerText}.png",
                        Introduction = childList[27].InnerText,
                        Console = $@"c_give(""{childList[29].InnerText}"",1)"
                    });
            }

            foreach (var item in shadowList)
            {
                var childList = item.ChildNodes;
                shadowData.Add(
                    new Science
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Need1 = $"ms-appx:///Assets/GameResources/{childList[7].InnerText}.png",
                        Need1Value = Convert.ToInt32(childList[9].InnerText),
                        Need2 = $"ms-appx:///Assets/GameResources/{childList[11].InnerText}.png",
                        Need2Value = Convert.ToInt32(childList[13].InnerText),
                        Need3 = $"ms-appx:///Assets/GameResources/{childList[15].InnerText}.png",
                        Need3Value = Convert.ToInt32(childList[17].InnerText),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[19].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[21].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[23].InnerText)),
                        Unlock = $"ms-appx:///Assets/GameResources/{childList[25].InnerText}.png",
                        Introduction = childList[27].InnerText,
                        Console = $@"c_give(""{childList[29].InnerText}"",1)"
                    });
            }

            foreach (var item in crittersList)
            {
                var childList = item.ChildNodes;
                crittersData.Add(
                    new Science
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Need1 = $"ms-appx:///Assets/GameResources/{childList[7].InnerText}.png",
                        Need1Value = Convert.ToInt32(childList[9].InnerText),
                        Need2 = $"ms-appx:///Assets/GameResources/{childList[11].InnerText}.png",
                        Need2Value = Convert.ToInt32(childList[13].InnerText),
                        Need3 = $"ms-appx:///Assets/GameResources/{childList[15].InnerText}.png",
                        Need3Value = Convert.ToInt32(childList[17].InnerText),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[19].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[21].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[23].InnerText)),
                        Unlock = $"ms-appx:///Assets/GameResources/{childList[25].InnerText}.png",
                        Introduction = childList[27].InnerText,
                        Console = $@"c_give(""{childList[29].InnerText}"",1)"
                    });
            }

            foreach (var item in sculptList)
            {
                var childList = item.ChildNodes;
                sculptData.Add(
                    new Science
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Need1 = $"ms-appx:///Assets/GameResources/{childList[7].InnerText}.png",
                        Need1Value = Convert.ToInt32(childList[9].InnerText),
                        Need2 = $"ms-appx:///Assets/GameResources/{childList[11].InnerText}.png",
                        Need2Value = Convert.ToInt32(childList[13].InnerText),
                        Need3 = $"ms-appx:///Assets/GameResources/{childList[15].InnerText}.png",
                        Need3Value = Convert.ToInt32(childList[17].InnerText),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[19].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[21].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[23].InnerText)),
                        Unlock = $"ms-appx:///Assets/GameResources/{childList[25].InnerText}.png",
                        Introduction = childList[27].InnerText,
                        Console = $@"c_give(""{childList[29].InnerText}"",1)"
                    });
            }

            foreach (var item in cartographyList)
            {
                var childList = item.ChildNodes;
                cartographyData.Add(
                    new Science
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Need1 = $"ms-appx:///Assets/GameResources/{childList[7].InnerText}.png",
                        Need1Value = Convert.ToInt32(childList[9].InnerText),
                        Need2 = $"ms-appx:///Assets/GameResources/{childList[11].InnerText}.png",
                        Need2Value = Convert.ToInt32(childList[13].InnerText),
                        Need3 = $"ms-appx:///Assets/GameResources/{childList[15].InnerText}.png",
                        Need3Value = Convert.ToInt32(childList[17].InnerText),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[19].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[21].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[23].InnerText)),
                        Unlock = $"ms-appx:///Assets/GameResources/{childList[25].InnerText}.png",
                        Introduction = childList[27].InnerText,
                        Console = $@"c_give(""{childList[29].InnerText}"",1)"
                    });
            }
        }

        private async void ScienceGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Science s = e.ClickedItem as Science;

            var contentDialog = new ContentDialog()
            {
                Content = new ScienceDialog(s),
                PrimaryButtonText = "确定",
                FullSizeDesired = false
            };

            contentDialog.Style = transparent;

            contentDialog.Closed += async (_s, _e) =>
            {
                await ScienceGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };

            contentDialog.PrimaryButtonClick += async (_s, _e) =>
            {
                await ScienceGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };
            await ScienceGrid.Blur(value: 7, duration: 100, delay: 0).StartAsync();

            await contentDialog.ShowAsync();
        }
    }
}
