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
    public sealed partial class CreaturePage : Page
    {
        private ObservableCollection<Creature> LandData = new ObservableCollection<Creature>();
        private ObservableCollection<Creature> FlyData = new ObservableCollection<Creature>();
        private ObservableCollection<Creature> CaveData = new ObservableCollection<Creature>();
        private ObservableCollection<Creature> EvilData = new ObservableCollection<Creature>();
        private ObservableCollection<Creature> OthersData = new ObservableCollection<Creature>();
        private ObservableCollection<Creature> BossData = new ObservableCollection<Creature>();

        Style transparent = (Style)Application.Current.Resources["TransparentDialog"];

        public CreaturePage()
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
                CreatureGrid.Background = myBrush;

                //Style style = (Style)Application.Current.Resources["GridViewItemRevealStyle"];
            }
        }
        public async void Deserialize()
        {
            Uri xmlUri = new Uri("ms-appx:///XML/Creatures.xml");
            StorageFile xmlFile = await StorageFile.GetFileFromApplicationUriAsync(xmlUri);
            XmlDocument xml = await XmlDocument.LoadFromFileAsync(xmlFile);
            var landList = xml.DocumentElement.SelectNodes("Land")[0].SelectNodes("Creature");
            var flyList = xml.DocumentElement.SelectNodes("Fly")[0].SelectNodes("Creature");
            var caveList = xml.DocumentElement.SelectNodes("Cave")[0].SelectNodes("Creature");
            var evilList = xml.DocumentElement.SelectNodes("Evil")[0].SelectNodes("Creature");
            var othersList = xml.DocumentElement.SelectNodes("Others")[0].SelectNodes("Creature");
            var bossList = xml.DocumentElement.SelectNodes("BOSS")[0].SelectNodes("Creature");

            foreach (var item in landList)
            {
                var childList = item.ChildNodes;
                LandData.Add(
                    new Creature
                    {
                        Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Health = Convert.ToDouble(childList[7].InnerText),
                        HealthDST = Convert.ToDouble(childList[9].InnerText),
                        Attack = Convert.ToDouble(childList[11].InnerText),
                        AttackInterval = Convert.ToDouble(childList[13].InnerText),
                        AttackScope = Convert.ToDouble(childList[15].InnerText),
                        MoveSpeed = Convert.ToDouble(childList[17].InnerText),
                        RunSpeed = Convert.ToDouble(childList[19].InnerText),
                        Dangerous = Convert.ToInt32(childList[21].InnerText),
                        SanityEffect = Convert.ToDouble(childList[23].InnerText),
                        IsActiveAttack = Convert.ToBoolean(Convert.ToInt32(childList[25].InnerText)),
                        IsTeamWork = Convert.ToBoolean(Convert.ToInt32(childList[27].InnerText)),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[29].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[31].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[33].InnerText)),
                        Goods = childList[35].InnerText,
                        Ability = childList[37].InnerText,
                        Introduction = childList[39].InnerText,
                        Console = $@"c_give(""{childList[41].InnerText}"",1)"
                    });
            }

            foreach (var item in flyList)
            {
                var childList = item.ChildNodes;
                FlyData.Add(
                    new Creature
                    {
                        Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Health = Convert.ToDouble(childList[7].InnerText),
                        HealthDST = Convert.ToDouble(childList[9].InnerText),
                        Attack = Convert.ToDouble(childList[11].InnerText),
                        AttackInterval = Convert.ToDouble(childList[13].InnerText),
                        AttackScope = Convert.ToDouble(childList[15].InnerText),
                        MoveSpeed = Convert.ToDouble(childList[17].InnerText),
                        RunSpeed = Convert.ToDouble(childList[19].InnerText),
                        Dangerous = Convert.ToInt32(childList[21].InnerText),
                        SanityEffect = Convert.ToDouble(childList[23].InnerText),
                        IsActiveAttack = Convert.ToBoolean(Convert.ToInt32(childList[25].InnerText)),
                        IsTeamWork = Convert.ToBoolean(Convert.ToInt32(childList[27].InnerText)),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[29].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[31].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[33].InnerText)),
                        Goods = childList[35].InnerText,
                        Ability = childList[37].InnerText,
                        Introduction = childList[39].InnerText,
                        Console = $@"c_give(""{childList[41].InnerText}"",1)"
                    });
            }

            foreach (var item in caveList)
            {
                var childList = item.ChildNodes;
                CaveData.Add(
                    new Creature
                    {
                        Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Health = Convert.ToDouble(childList[7].InnerText),
                        HealthDST = Convert.ToDouble(childList[9].InnerText),
                        Attack = Convert.ToDouble(childList[11].InnerText),
                        AttackInterval = Convert.ToDouble(childList[13].InnerText),
                        AttackScope = Convert.ToDouble(childList[15].InnerText),
                        MoveSpeed = Convert.ToDouble(childList[17].InnerText),
                        RunSpeed = Convert.ToDouble(childList[19].InnerText),
                        Dangerous = Convert.ToInt32(childList[21].InnerText),
                        SanityEffect = Convert.ToDouble(childList[23].InnerText),
                        IsActiveAttack = Convert.ToBoolean(Convert.ToInt32(childList[25].InnerText)),
                        IsTeamWork = Convert.ToBoolean(Convert.ToInt32(childList[27].InnerText)),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[29].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[31].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[33].InnerText)),
                        Goods = childList[35].InnerText,
                        Ability = childList[37].InnerText,
                        Introduction = childList[39].InnerText,
                        Console = $@"c_give(""{childList[41].InnerText}"",1)"
                    });
            }

            foreach (var item in evilList)
            {
                var childList = item.ChildNodes;
                EvilData.Add(
                    new Creature
                    {
                        Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Health = Convert.ToDouble(childList[7].InnerText),
                        HealthDST = Convert.ToDouble(childList[9].InnerText),
                        Attack = Convert.ToDouble(childList[11].InnerText),
                        AttackInterval = Convert.ToDouble(childList[13].InnerText),
                        AttackScope = Convert.ToDouble(childList[15].InnerText),
                        MoveSpeed = Convert.ToDouble(childList[17].InnerText),
                        RunSpeed = Convert.ToDouble(childList[19].InnerText),
                        Dangerous = Convert.ToInt32(childList[21].InnerText),
                        SanityEffect = Convert.ToDouble(childList[23].InnerText),
                        IsActiveAttack = Convert.ToBoolean(Convert.ToInt32(childList[25].InnerText)),
                        IsTeamWork = Convert.ToBoolean(Convert.ToInt32(childList[27].InnerText)),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[29].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[31].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[33].InnerText)),
                        Goods = childList[35].InnerText,
                        Ability = childList[37].InnerText,
                        Introduction = childList[39].InnerText,
                        Console = $@"c_give(""{childList[41].InnerText}"",1)"
                    });
            }

            foreach (var item in othersList)
            {
                var childList = item.ChildNodes;
                OthersData.Add(
                    new Creature
                    {
                        Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Health = Convert.ToDouble(childList[7].InnerText),
                        HealthDST = Convert.ToDouble(childList[9].InnerText),
                        Attack = Convert.ToDouble(childList[11].InnerText),
                        AttackInterval = Convert.ToDouble(childList[13].InnerText),
                        AttackScope = Convert.ToDouble(childList[15].InnerText),
                        MoveSpeed = Convert.ToDouble(childList[17].InnerText),
                        RunSpeed = Convert.ToDouble(childList[19].InnerText),
                        Dangerous = Convert.ToInt32(childList[21].InnerText),
                        SanityEffect = Convert.ToDouble(childList[23].InnerText),
                        IsActiveAttack = Convert.ToBoolean(Convert.ToInt32(childList[25].InnerText)),
                        IsTeamWork = Convert.ToBoolean(Convert.ToInt32(childList[27].InnerText)),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[29].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[31].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[33].InnerText)),
                        Goods = childList[35].InnerText,
                        Ability = childList[37].InnerText,
                        Introduction = childList[39].InnerText,
                        Console = $@"c_give(""{childList[41].InnerText}"",1)"
                    });
            }

            foreach (var item in bossList)
            {
                var childList = item.ChildNodes;
                BossData.Add(
                    new Creature
                    {
                        Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Health = Convert.ToDouble(childList[7].InnerText),
                        HealthDST = Convert.ToDouble(childList[9].InnerText),
                        Attack = Convert.ToDouble(childList[11].InnerText),
                        AttackInterval = Convert.ToDouble(childList[13].InnerText),
                        AttackScope = Convert.ToDouble(childList[15].InnerText),
                        MoveSpeed = Convert.ToDouble(childList[17].InnerText),
                        RunSpeed = Convert.ToDouble(childList[19].InnerText),
                        Dangerous = Convert.ToInt32(childList[21].InnerText),
                        SanityEffect = Convert.ToDouble(childList[23].InnerText),
                        IsActiveAttack = Convert.ToBoolean(Convert.ToInt32(childList[25].InnerText)),
                        IsTeamWork = Convert.ToBoolean(Convert.ToInt32(childList[27].InnerText)),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[29].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[31].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[33].InnerText)),
                        Goods = childList[35].InnerText,
                        Ability = childList[37].InnerText,
                        Introduction = childList[39].InnerText,
                        Console = $@"c_give(""{childList[41].InnerText}"",1)"
                    });
            }
        }

        private async void CreatureGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Creature c = e.ClickedItem as Creature;

            var contentDialog = new ContentDialog()
            {
                Content = new CreatureDialog(c),
                PrimaryButtonText = "确定",
                FullSizeDesired = false
            };

            contentDialog.Style = transparent;

            contentDialog.Closed += async (_s, _e) =>
            {
                await CreatureGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };

            contentDialog.PrimaryButtonClick += async (_s, _e) =>
            {
                await CreatureGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };
            await CreatureGrid.Blur(value: 7, duration: 100, delay: 0).StartAsync();

            await contentDialog.ShowAsync();
        }
    }
}
