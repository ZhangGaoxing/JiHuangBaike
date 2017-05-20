using JiHuangBaike.Data;
using Microsoft.Toolkit.Uwp.UI.Animations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml;
using System.Xml.Serialization;
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
    public sealed partial class CharacterPage : Page
    {
        private ObservableCollection<Character> characterData = new ObservableCollection<Character>();

        Style transparent = (Style)Application.Current.Resources["TransparentDialog"];

        public CharacterPage()
        {
            this.InitializeComponent();
            Deserialize();
        }

        public async void Deserialize()
        {
            Uri xmlUri = new Uri("ms-appx:///XML/Characters.xml");
            StorageFile xmlFile = await StorageFile.GetFileFromApplicationUriAsync(xmlUri);
            XmlDocument xml = await XmlDocument.LoadFromFileAsync(xmlFile);
            var characterList = xml.DocumentElement.SelectNodes("Character");
            foreach (var item in characterList)
            {
                var childList = item.ChildNodes;
                characterData.Add(
                    new Character
                    {
                        Image = $"ms-appx:///Assets/GameResources/{childList[1].InnerText}.png",
                        Name = childList[3].InnerText,
                        EnName = childList[5].InnerText,
                        Motto = childList[7].InnerText,
                        Description = childList[9].InnerText,
                        Health = Convert.ToInt32(childList[11].InnerText),
                        Hunger = Convert.ToInt32(childList[13].InnerText),
                        Sanity = Convert.ToInt32(childList[15].InnerText),
                        Damage = Convert.ToDouble(childList[17].InnerText),
                        Introduction = childList[19].InnerText
                    });
            }
        }

        private async void CharacterGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Character c = e.ClickedItem as Character;

            var contentDialog = new ContentDialog()
            {
                Content = new CharacterDialog(c),
                PrimaryButtonText = "确定",
                FullSizeDesired = false
            };

            contentDialog.Style = transparent;

            contentDialog.Closed += async (_s, _e) =>
            {
                 await CharacterGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                 contentDialog.Hide();
            };

            contentDialog.PrimaryButtonClick += async (_s, _e) =>
            {
                await CharacterGrid.Blur(value: 0, duration: 0, delay: 0).StartAsync();
                contentDialog.Hide();
            };
            await CharacterGrid.Blur(value: 7, duration: 200, delay: 0).StartAsync();

            await contentDialog.ShowAsync();
        }
    }
}
