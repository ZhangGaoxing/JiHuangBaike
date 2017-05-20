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
    public sealed partial class GoodsPage : Page
    {
        private ObservableCollection<GoodMaterial> MaterialData = new ObservableCollection<GoodMaterial>();
        private ObservableCollection<GoodEquipment> EquipmentData = new ObservableCollection<GoodEquipment>();
        private ObservableCollection<GoodPlant> PlantData = new ObservableCollection<GoodPlant>();
        private ObservableCollection<GoodCreature> CreatureData = new ObservableCollection<GoodCreature>();
        private ObservableCollection<GoodToy> ToyData = new ObservableCollection<GoodToy>();
        private ObservableCollection<GoodTurf> TurfData = new ObservableCollection<GoodTurf>();
        private ObservableCollection<GoodPet> PetData = new ObservableCollection<GoodPet>();
        //private ObservableCollection<GoodMaterial> OthersData = new ObservableCollection<GoodMaterial>();

        Style transparent = (Style)Application.Current.Resources["TransparentDialog"];

        public GoodsPage()
        {
            this.InitializeComponent();

            Deserialize();
        }

        public async void Deserialize()
        {
            Uri xmlUri = new Uri("ms-appx:///XML/Goods.xml");
            StorageFile xmlFile = await StorageFile.GetFileFromApplicationUriAsync(xmlUri);
            XmlDocument xml = await XmlDocument.LoadFromFileAsync(xmlFile);
            var materialList = xml.DocumentElement.SelectNodes("Material")[0].SelectNodes("Good");
            var equipmentList = xml.DocumentElement.SelectNodes("Equipment")[0].SelectNodes("Good");
            var plantList = xml.DocumentElement.SelectNodes("Plant")[0].SelectNodes("Good");
            var creatureList = xml.DocumentElement.SelectNodes("Creature")[0].SelectNodes("Good");
            var toyList = xml.DocumentElement.SelectNodes("Toy")[0].SelectNodes("Good");
            var turfList = xml.DocumentElement.SelectNodes("Turf")[0].SelectNodes("Good");
            var petList = xml.DocumentElement.SelectNodes("Pet")[0].SelectNodes("Good");

            foreach (var item in materialList)
            {
                var childList = item.ChildNodes;
                MaterialData.Add(
                    new GoodMaterial
                    {
                        Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Science = childList[7].InnerText.Split(','),
                        Creature = childList[9].InnerText.Split(','),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[11].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[13].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[15].InnerText)),
                        Introduction = childList[17].InnerText,
                        Console = $@"c_give(""{childList[19].InnerText}"",1)"
                    });
            }

            foreach (var item in equipmentList)
            {
                var childList = item.ChildNodes;
                EquipmentData.Add(
                    new GoodEquipment
                    {
                        Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Attack = Convert.ToDouble(childList[7].InnerText),
                        Durability = childList[9].InnerText,
                        Wet = Convert.ToDouble(childList[11].InnerText),
                        Heat = Convert.ToDouble(childList[13].InnerText),
                        Sanity = Convert.ToDouble(childList[15].InnerText),
                        Defense = Convert.ToDouble(childList[17].InnerText),
                        Hunger = Convert.ToDouble(childList[19].InnerText),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[21].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[23].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[25].InnerText)),
                        Introduction = childList[27].InnerText,
                        Console = $@"c_give(""{childList[29].InnerText}"",1)"
                    });
            }

            foreach (var item in plantList)
            {
                var childList = item.ChildNodes;
                PlantData.Add(
                    new GoodPlant
                    {
                        Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Creature = childList[7].InnerText.Split(','),
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[9].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[11].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[13].InnerText)),
                        Introduction = childList[15].InnerText,
                        Console = $@"c_give(""{childList[17].InnerText}"",1)"
                    });
            }

            foreach (var item in creatureList)
            {
                var childList = item.ChildNodes;
                CreatureData.Add(
                    new GoodCreature
                    {
                        Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Fresh = childList[7].InnerText,
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[9].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[11].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[13].InnerText)),
                        Console = $@"c_give(""{childList[15].InnerText}"",1)"
                    });
            }

            foreach (var item in toyList)
            {
                var childList = item.ChildNodes;
                ToyData.Add(
                    new GoodToy
                    {
                        Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[7].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[9].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[11].InnerText)),
                        Console = $@"c_give(""{childList[13].InnerText}"",1)"
                    });
            }

            foreach (var item in turfList)
            {
                var childList = item.ChildNodes;
                TurfData.Add(
                    new GoodTurf
                    {
                        Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Texture = $"ms-appx:///Assets/GameResources/{childList[7].InnerText}.png",
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[9].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[11].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[13].InnerText)),
                        Introduction = childList[15].InnerText,
                        Console = $@"c_give(""{childList[17].InnerText}"",1)"
                    });
            }

            foreach (var item in petList)
            {
                var childList = item.ChildNodes;
                PetData.Add(
                    new GoodPet
                    {
                        Picture = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Dead = $"ms-appx:///Assets/GameResources/{childList[7].InnerText}.png",
                        Follow = $"ms-appx:///Assets/GameResources/{childList[9].InnerText}.png",
                        IsROG = Convert.ToBoolean(Convert.ToInt32(childList[11].InnerText)),
                        IsSW = Convert.ToBoolean(Convert.ToInt32(childList[13].InnerText)),
                        IsDST = Convert.ToBoolean(Convert.ToInt32(childList[15].InnerText)),
                        Introduction = childList[17].InnerText,
                        Console = $@"c_give(""{childList[19].InnerText}"",1)"
                    });
            }
        }

        private async void MaterialGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            GoodMaterial gm = e.ClickedItem as GoodMaterial;

            var contentDialog = new ContentDialog()
            {
                Content = new GoodMaterialDialog(gm),
                PrimaryButtonText = "确定",
                FullSizeDesired = false
            };

            contentDialog.Style = transparent;

            contentDialog.Closed += async (_s, _e) =>
            {
                await GoodsGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };

            contentDialog.PrimaryButtonClick += async (_s, _e) =>
            {
                await GoodsGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };
            await GoodsGrid.Blur(value: 7, duration: 200, delay: 0).StartAsync();

            await contentDialog.ShowAsync();
        }

        private async void PlantGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            GoodPlant gp = e.ClickedItem as GoodPlant;

            var contentDialog = new ContentDialog()
            {
                Content = new GoodPlantDialog(gp),
                PrimaryButtonText = "确定",
                FullSizeDesired = false
            };

            contentDialog.Style = transparent;

            contentDialog.Closed += async (_s, _e) =>
            {
                await GoodsGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };

            contentDialog.PrimaryButtonClick += async (_s, _e) =>
            {
                await GoodsGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };
            await GoodsGrid.Blur(value: 7, duration: 200, delay: 0).StartAsync();

            await contentDialog.ShowAsync();
        }

        private async void CreatureGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            GoodCreature gc = e.ClickedItem as GoodCreature;

            var contentDialog = new ContentDialog()
            {
                Content = new GoodCreatureDialog(gc),
                PrimaryButtonText = "确定",
                FullSizeDesired = false
            };

            contentDialog.Style = transparent;

            contentDialog.Closed += async (_s, _e) =>
            {
                await GoodsGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };

            contentDialog.PrimaryButtonClick += async (_s, _e) =>
            {
                await GoodsGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };
            await GoodsGrid.Blur(value: 7, duration: 200, delay: 0).StartAsync();

            await contentDialog.ShowAsync();
        }

        private async void ToyGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            GoodToy gt = e.ClickedItem as GoodToy;

            var contentDialog = new ContentDialog()
            {
                Content = new GoodToyDialog(gt),
                PrimaryButtonText = "确定",
                FullSizeDesired = false
            };

            contentDialog.Style = transparent;

            contentDialog.Closed += async (_s, _e) =>
            {
                await GoodsGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };

            contentDialog.PrimaryButtonClick += async (_s, _e) =>
            {
                await GoodsGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };
            await GoodsGrid.Blur(value: 7, duration: 200, delay: 0).StartAsync();

            await contentDialog.ShowAsync();
        }

        private async void TurfGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            GoodTurf gt = e.ClickedItem as GoodTurf;

            var contentDialog = new ContentDialog()
            {
                Content = new GoodTurfDialog(gt),
                PrimaryButtonText = "确定",
                FullSizeDesired = false
            };

            contentDialog.Style = transparent;

            contentDialog.Closed += async (_s, _e) =>
            {
                await GoodsGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };

            contentDialog.PrimaryButtonClick += async (_s, _e) =>
            {
                await GoodsGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };
            await GoodsGrid.Blur(value: 7, duration: 200, delay: 0).StartAsync();

            await contentDialog.ShowAsync();
        }

        private async void PetGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            GoodPet gp = e.ClickedItem as GoodPet;

            var contentDialog = new ContentDialog()
            {
                Content = new GoodPetDialog(gp),
                PrimaryButtonText = "确定",
                FullSizeDesired = false
            };

            contentDialog.Style = transparent;

            contentDialog.Closed += async (_s, _e) =>
            {
                await GoodsGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };

            contentDialog.PrimaryButtonClick += async (_s, _e) =>
            {
                await GoodsGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };
            await GoodsGrid.Blur(value: 7, duration: 200, delay: 0).StartAsync();

            await contentDialog.ShowAsync();
        }

        private async void EquipmentGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            GoodEquipment ge = e.ClickedItem as GoodEquipment;

            var contentDialog = new ContentDialog()
            {
                Content = new GoodEquipmentDialog(ge),
                PrimaryButtonText = "确定",
                FullSizeDesired = false
            };

            contentDialog.Style = transparent;

            contentDialog.Closed += async (_s, _e) =>
            {
                await GoodsGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };

            contentDialog.PrimaryButtonClick += async (_s, _e) =>
            {
                await GoodsGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };
            await GoodsGrid.Blur(value: 7, duration: 200, delay: 0).StartAsync();

            await contentDialog.ShowAsync();
        }
    }
}
