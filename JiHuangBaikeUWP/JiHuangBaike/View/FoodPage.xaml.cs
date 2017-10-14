using JiHuangBaike.Data;
using JiHuangBaike.Manager;
using Microsoft.Toolkit.Uwp.UI.Animations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
    public sealed partial class FoodPage : Page
    {
        private ObservableCollection<FoodRecipe> foodRecipeData = new ObservableCollection<FoodRecipe>();
        private ObservableCollection<Food> foodMeatData = new ObservableCollection<Food>();
        private ObservableCollection<Food> foodVegetableData = new ObservableCollection<Food>();
        private ObservableCollection<Food> foodFruitData = new ObservableCollection<Food>();
        private ObservableCollection<Food> foodEggData = new ObservableCollection<Food>();
        private ObservableCollection<Food> foodOthersData = new ObservableCollection<Food>();
        private ObservableCollection<Food> foodNoFCData = new ObservableCollection<Food>();

        Style transparent = (Style)Application.Current.Resources["TransparentDialog"];

        public FoodPage()
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
                FoodGrid.Background = myBrush;

                //Style style = (Style)Application.Current.Resources["GridViewItemRevealStyle"];
            }
        }
        public async void Deserialize()
        {
            Uri xmlUri = new Uri("ms-appx:///XML/Foods.xml");
            StorageFile xmlFile = await StorageFile.GetFileFromApplicationUriAsync(xmlUri);
            XmlDocument xml = await XmlDocument.LoadFromFileAsync(xmlFile);
            var recipeList = xml.DocumentElement.SelectNodes("FoodRecipe")[0].SelectNodes("Food");
            var meatList = xml.DocumentElement.SelectNodes("FoodMeats")[0].SelectNodes("Food");
            var vegetableList = xml.DocumentElement.SelectNodes("FoodVegetables")[0].SelectNodes("Food");
            var fruitList = xml.DocumentElement.SelectNodes("FoodFruit")[0].SelectNodes("Food");
            var eggList = xml.DocumentElement.SelectNodes("FoodEggs")[0].SelectNodes("Food");
            var othersList = xml.DocumentElement.SelectNodes("FoodOthers")[0].SelectNodes("Food");
            var noFCList = xml.DocumentElement.SelectNodes("FoodNoFC")[0].SelectNodes("Food");

            foreach (var item in recipeList)
            {
                var childList = item.ChildNodes;
                foodRecipeData.Add(
                    new FoodRecipe
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Health = Convert.ToDouble(childList[7].InnerText),
                        Hunger = Convert.ToDouble(childList[9].InnerText),
                        Sanity = Convert.ToDouble(childList[11].InnerText),
                        Perish = Convert.ToDouble(childList[13].InnerText),
                        Cooktime = Convert.ToDouble(childList[15].InnerText),
                        Priority = Convert.ToInt32(childList[17].InnerText),
                        Need = childList[19].InnerText,
                        Recommend1 = $"ms-appx:///Assets/GameResources/{childList[21].InnerText}.png",
                        Recommend2 = $"ms-appx:///Assets/GameResources/{childList[23].InnerText}.png",
                        Recommend3 = $"ms-appx:///Assets/GameResources/{childList[25].InnerText}.png",
                        Recommend4 = $"ms-appx:///Assets/GameResources/{childList[27].InnerText}.png",
                        Introduction = childList[29].InnerText,
                        Console = $@"c_give(""{childList[31].InnerText}"",1)"
                    });
            }

            foreach (var item in meatList)
            {
                var childList = item.ChildNodes;
                foodMeatData.Add(
                    new Food
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Health = Convert.ToDouble(childList[7].InnerText),
                        Hunger = Convert.ToDouble(childList[9].InnerText),
                        Sanity = Convert.ToDouble(childList[11].InnerText),
                        Perish = Convert.ToDouble(childList[13].InnerText),
                        Attribute = $"ms-appx:///Assets/GameResources/{childList[15].InnerText}.png",
                        AttributeValue = childList[17].InnerText,
                        Introduction = childList[19].InnerText,
                        Console = $@"c_give(""{childList[21].InnerText}"",1)"
                    });
            }

            foreach (var item in vegetableList)
            {
                var childList = item.ChildNodes;
                foodVegetableData.Add(
                    new Food
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Health = Convert.ToDouble(childList[7].InnerText),
                        Hunger = Convert.ToDouble(childList[9].InnerText),
                        Sanity = Convert.ToDouble(childList[11].InnerText),
                        Perish = Convert.ToDouble(childList[13].InnerText),
                        Attribute = $"ms-appx:///Assets/GameResources/{childList[15].InnerText}.png",
                        AttributeValue = childList[17].InnerText,
                        Introduction = childList[19].InnerText,
                        Console = $@"c_give(""{childList[21].InnerText}"",1)"
                    });
            }

            foreach (var item in fruitList)
            {
                var childList = item.ChildNodes;
                foodFruitData.Add(
                    new Food
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Health = Convert.ToDouble(childList[7].InnerText),
                        Hunger = Convert.ToDouble(childList[9].InnerText),
                        Sanity = Convert.ToDouble(childList[11].InnerText),
                        Perish = Convert.ToDouble(childList[13].InnerText),
                        Attribute = $"ms-appx:///Assets/GameResources/{childList[15].InnerText}.png",
                        AttributeValue = childList[17].InnerText,
                        Introduction = childList[19].InnerText,
                        Console = $@"c_give(""{childList[21].InnerText}"",1)"
                    });
            }

            foreach (var item in eggList)
            {
                var childList = item.ChildNodes;
                foodEggData.Add(
                    new Food
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Health = Convert.ToDouble(childList[7].InnerText),
                        Hunger = Convert.ToDouble(childList[9].InnerText),
                        Sanity = Convert.ToDouble(childList[11].InnerText),
                        Perish = Convert.ToDouble(childList[13].InnerText),
                        Attribute = $"ms-appx:///Assets/GameResources/{childList[15].InnerText}.png",
                        AttributeValue = childList[17].InnerText,
                        Introduction = childList[19].InnerText,
                        Console = $@"c_give(""{childList[21].InnerText}"",1)"
                    });
            }

            foreach (var item in othersList)
            {
                var childList = item.ChildNodes;
                foodOthersData.Add(
                    new Food
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Health = Convert.ToDouble(childList[7].InnerText),
                        Hunger = Convert.ToDouble(childList[9].InnerText),
                        Sanity = Convert.ToDouble(childList[11].InnerText),
                        Perish = Convert.ToDouble(childList[13].InnerText),
                        Attribute = $"ms-appx:///Assets/GameResources/{childList[15].InnerText}.png",
                        AttributeValue = childList[17].InnerText,
                        Introduction = childList[19].InnerText,
                        Console = $@"c_give(""{childList[21].InnerText}"",1)"
                    });
            }

            foreach (var item in noFCList)
            {
                var childList = item.ChildNodes;
                foodNoFCData.Add(
                    new Food
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Health = Convert.ToDouble(childList[7].InnerText),
                        Hunger = Convert.ToDouble(childList[9].InnerText),
                        Sanity = Convert.ToDouble(childList[11].InnerText),
                        Perish = Convert.ToDouble(childList[13].InnerText),
                        Attribute = childList[15].InnerText,
                        AttributeValue = childList[17].InnerText,
                        Introduction = childList[19].InnerText,
                        Console = $@"c_give(""{childList[21].InnerText}"",1)"
                    });
            }
        }

        private async void RecipeGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            FoodRecipe fr = e.ClickedItem as FoodRecipe;

            var contentDialog = new ContentDialog()
            {
                Content = new FoodRecipeDialog(fr),
                PrimaryButtonText = "确定",
                FullSizeDesired = false
            };

            contentDialog.Style = transparent;

            contentDialog.Closed += async (_s, _e) =>
            {
                await FoodGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };

            contentDialog.PrimaryButtonClick += async (_s, _e) =>
            {
                await FoodGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };
            await FoodGrid.Blur(value: 7, duration: 100, delay: 0).StartAsync();

            await contentDialog.ShowAsync();
        }

        private async void FoodGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Food f = e.ClickedItem as Food;

            var contentDialog = new ContentDialog()
            {
                Content = new FoodDialog(f),
                PrimaryButtonText = "确定",
                FullSizeDesired = false
            };

            contentDialog.Style = transparent;

            contentDialog.Closed += async (_s, _e) =>
            {
                await FoodGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };

            contentDialog.PrimaryButtonClick += async (_s, _e) =>
            {
                await FoodGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };
            await FoodGrid.Blur(value: 7, duration: 100, delay: 0).StartAsync();

            await contentDialog.ShowAsync();
        }
    }
}
