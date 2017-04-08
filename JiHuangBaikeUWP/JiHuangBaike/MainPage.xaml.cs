using JiHuangBaike.Data;
using JiHuangBaike.View;
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

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace JiHuangBaike
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        static Color brush = (Color)Application.Current.Resources["SystemAccentColor"];

        private List<NavMenuItem> navMenuPrimaryItem = new List<NavMenuItem>(
            new[]
            {
                new NavMenuItem()
                {
                    FontFamily = new FontFamily("/Assets/segmdl2.ttf#Segoe MDL2 Assets"),
                    Icon = "\xED53",
                    Label = "人物",
                    Color = new SolidColorBrush(brush),
                    Selected = Visibility.Visible,
                    DestPage = typeof(CharacterPage)
                },
                new NavMenuItem()
                {
                    FontFamily = new FontFamily("/Assets/segmdl2.ttf#Segoe MDL2 Assets"),
                    Icon = "\xED56",
                    Label = "食物",
                    Color = new SolidColorBrush(Colors.White),
                    Selected = Visibility.Collapsed,
                    DestPage = typeof(FoodPage)
                },
                new NavMenuItem()
                {
                    FontFamily = new FontFamily("/Assets/holomdl2.ttf#HoloLens MDL2 Assets"),
                    Icon = "\xE736",
                    Label = "科技",
                    Color = new SolidColorBrush(Colors.White),
                    Selected = Visibility.Collapsed,
                    DestPage = typeof(SciencePage)
                },
                new NavMenuItem()
                {
                    FontFamily = new FontFamily("/Assets/holomdl2.ttf#HoloLens MDL2 Assets"),
                    Icon = "\xECEA",
                    Label = "生物",
                    Color = new SolidColorBrush(Colors.White),
                    Selected = Visibility.Collapsed,
                    DestPage = typeof(CreaturePage)
                },
                new NavMenuItem()
                {
                    FontFamily = new FontFamily("/Assets/segmdl2.ttf#Segoe MDL2 Assets"),
                    Icon = "\xE909",
                    Label = "自然",
                    Color = new SolidColorBrush(Colors.White),
                    Selected = Visibility.Collapsed,
                    DestPage = typeof(NaturalPage)
                },
                new NavMenuItem()
                {
                    FontFamily = new FontFamily("/Assets/segmdl2.ttf#Segoe MDL2 Assets"),
                    Icon = "\xF158",
                    Label = "物品",
                    Color = new SolidColorBrush(Colors.White),
                    Selected = Visibility.Collapsed,
                    DestPage = typeof(GoodsPage)
                }
            });

        private List<NavMenuItem> navMenuSecondaryItem = new List<NavMenuItem>(
            new[]
            {
                new NavMenuItem()
                {
                    FontFamily = new FontFamily("/Assets/segmdl2.ttf#Segoe MDL2 Assets"),
                    Icon = "\xE713",
                    Label = "设置",
                    Color = new SolidColorBrush(Colors.White),
                    Selected = Visibility.Collapsed,
                    DestPage = typeof(SettingPage)
                },
                new NavMenuItem()
                {
                    FontFamily = new FontFamily("/Assets/segmdl2.ttf#Segoe MDL2 Assets"),
                    Icon = "\xE783",
                    Label = "关于",
                    Color = new SolidColorBrush(Colors.White),
                    Selected = Visibility.Collapsed,
                    DestPage = typeof(AboutPage)
                }
            });

        public MainPage()
        {
            this.InitializeComponent();

            // 绑定导航菜单
            NavMenuPrimaryListView.ItemsSource = navMenuPrimaryItem;
            NavMenuSecondaryListView.ItemsSource = navMenuSecondaryItem;
            // SplitView 开关
            PaneOpenButton.Click += async (sender, args) =>
            {
                if (Window.Current.Bounds.Width < 1008)
                {
                    if (RootSplitView.IsPaneOpen)
                    {
                        await RootFrame.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                        RootSplitView.IsPaneOpen = false;
                    }
                    else
                    {
                        await RootFrame.Blur(value: 5, duration: 200, delay: 0).StartAsync();
                        RootSplitView.IsPaneOpen = true;
                    }
                }
                else
                {
                    RootSplitView.IsPaneOpen = !RootSplitView.IsPaneOpen;
                }
            };
            // 导航事件
            NavMenuPrimaryListView.ItemClick += NavMenuListView_ItemClick;
            NavMenuSecondaryListView.ItemClick += NavMenuListView_ItemClick;
            // 默认页
            RootFrame.SourcePageType = typeof(CharacterPage);
        }

        private void NavMenuListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            // 遍历，将选中Rectangle隐藏
            foreach (var np in navMenuPrimaryItem)
            {
                np.Color = new SolidColorBrush(Colors.White);
                np.Selected = Visibility.Collapsed;
            }
            foreach (var ns in navMenuSecondaryItem)
            {
                ns.Color = new SolidColorBrush(Colors.White);
                ns.Selected = Visibility.Collapsed;
            }

            NavMenuItem item = e.ClickedItem as NavMenuItem;
            // Rectangle显示并导航
            item.Selected = Visibility.Visible;
            item.Color = new SolidColorBrush(brush);

            if (item.DestPage != null)
            {
                RootFrame.Navigate(item.DestPage);
            }

            if (Window.Current.Bounds.Width < 1008)
            {
                RootSplitView.IsPaneOpen = false;
            }
        }

        private async void RootSplitView_PaneClosed(SplitView sender, object args)
        {
            await RootFrame.Blur(value: 0, duration: 0, delay: 0).StartAsync();
        }
    }
}
