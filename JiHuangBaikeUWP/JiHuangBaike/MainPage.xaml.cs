﻿using JiHuangBaike.Data;
using JiHuangBaike.Manager;
using JiHuangBaike.View;
using Microsoft.Toolkit.Uwp.UI.Animations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System.Profile;
using Windows.UI;
using Windows.UI.ViewManagement;
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
                },
                new NavMenuItem()
                {
                    FontFamily = new FontFamily("/Assets/segmdl2.ttf#Segoe MDL2 Assets"),
                    Icon = "\xE163",
                    Label = "节日",
                    Color = new SolidColorBrush(Colors.White),
                    Selected = Visibility.Collapsed,
                    DestPage = typeof(EventPage)
                },
                new NavMenuItem()
                {
                    FontFamily = new FontFamily("/Assets/seguisym.ttf#Segoe UI Symbol"),
                    Icon = "👔",
                    Label = "皮肤",
                    Color = new SolidColorBrush(Colors.White),
                    Selected = Visibility.Collapsed,
                    DestPage = typeof(SkinPage)
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

        double buttonX = -30, buttonY = -130;

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
                        await RootFrame.Blur(value: 5, duration: 100, delay: 0).StartAsync();
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

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {
                StatusBar statusBar = StatusBar.GetForCurrentView();
                statusBar.ForegroundColor = Colors.White;
                statusBar.BackgroundOpacity = 1;
                statusBar.BackgroundColor = brush;
                await statusBar.ShowAsync();

                BarGrid.Visibility = Visibility.Collapsed;
            }
            else
            {
                //var view = ApplicationView.GetForCurrentView();
                //// active
                //view.TitleBar.BackgroundColor = brush;
                //view.TitleBar.ForegroundColor = Colors.White;
                //// inactive
                //view.TitleBar.InactiveBackgroundColor = brush;
                //view.TitleBar.InactiveForegroundColor = Colors.Gray;
                //// button
                //view.TitleBar.ButtonBackgroundColor = brush;
                //view.TitleBar.ButtonForegroundColor = Colors.White;

                //view.TitleBar.ButtonInactiveBackgroundColor = brush;
                //view.TitleBar.ButtonInactiveForegroundColor = Colors.Gray;

                SetBarAndStyle();
            }
        }

        private void MainThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            buttonX += e.HorizontalChange;
            buttonY += e.VerticalChange;

            MainThumb.Margin = new Thickness(0, 0, -buttonX, -buttonY);
        }

        private async void MainThumb_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (Window.Current.Bounds.Width < 641)
            {
                if (RootSplitView.IsPaneOpen)
                {
                    await RootFrame.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                    RootSplitView.IsPaneOpen = false;
                }
                else
                {
                    await RootFrame.Blur(value: 5, duration: 100, delay: 0).StartAsync();
                    RootSplitView.IsPaneOpen = true;
                }
            }
            else
            {
                RootSplitView.IsPaneOpen = !RootSplitView.IsPaneOpen;
            }
        }

        public void SetBarAndStyle()
        {
            if (DeviceInfoManager.GetOsVersion() > 15063)
            {
                if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.UI.Xaml.Media.XamlCompositionBrushBase"))
                {
                    Windows.UI.Xaml.Media.AcrylicBrush myBrush = new Windows.UI.Xaml.Media.AcrylicBrush();
                    myBrush.BackgroundSource = Windows.UI.Xaml.Media.AcrylicBackgroundSource.HostBackdrop;
                    myBrush.FallbackColor = Colors.Transparent;
                    myBrush.TintColor = Color.FromArgb(255, 15, 15, 15);
                    myBrush.TintOpacity = 0.3;

                    SplitViewPane.Background = myBrush;
                    BarGrid.Background = myBrush;

                    Style buttonReveal = (Style)Application.Current.Resources["ButtonRevealStyle"];
                    Style itemReveal = (Style)Application.Current.Resources["NavMenuItemRevealStyle"];

                    PaneOpenButton.Style = buttonReveal;
                    NavMenuPrimaryListView.ItemContainerStyle = itemReveal;
                    NavMenuSecondaryListView.ItemContainerStyle = itemReveal;
                }
            }

            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
            titleBar.ButtonForegroundColor = Colors.White;
            titleBar.ButtonHoverBackgroundColor = Colors.Gray;
        }

    }
}
