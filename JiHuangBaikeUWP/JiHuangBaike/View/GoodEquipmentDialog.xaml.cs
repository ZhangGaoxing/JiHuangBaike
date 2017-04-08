using JiHuangBaike.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace JiHuangBaike.View
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class GoodEquipmentDialog : Page
    {
        public GoodEquipmentDialog(GoodEquipment ge)
        {
            this.InitializeComponent();

            EquipmentImage.Source = new BitmapImage(new Uri(ge.Picture));
            EquipmentName.Text = ge.Name;
            EquipmentEnName.Text = ge.EnName;
            ROG.IsChecked = ge.IsROG;
            SW.IsChecked = ge.IsSW;
            DST.IsChecked = ge.IsDST;
            if (ge.Attack != 0)
            {
                EquipmentAttack.Text = "攻击：" + ge.Attack.ToString();
                EquipmentAttack.Visibility = Visibility.Visible;
            }
            EquipmentDurability.Text = "耐久：" + ge.Durability;
            if (ge.Wet != 0)
            {
                EquipmentWet.Text = "防潮：" + ge.Wet.ToString();
                EquipmentWet.Visibility = Visibility.Visible;
            }
            if (ge.Heat != 0)
            {
                EquipmentHeat.Text = "隔热：" + ge.Heat.ToString();
                EquipmentHeat.Visibility = Visibility.Visible;
            }
            if (ge.Sanity != 0)
            {
                EquipmentSanity.Text = "精神：" + ge.Sanity.ToString();
                EquipmentSanity.Visibility = Visibility.Visible;
            }
            if (ge.Defense != 0)
            {
                EquipmentDefense.Text = "防御：" + ge.Defense.ToString();
                EquipmentDefense.Visibility = Visibility.Visible;
            }
            if (ge.Hunger != 0)
            {
                EquipmentHunger.Text = "饥饿：" + ge.Hunger.ToString();
                EquipmentHunger.Visibility = Visibility.Visible;
            }
            EquipmentIntroduction.Text = ge.Introduction;
            Console.Text = ge.Console;
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText(Console.Text);
            Clipboard.SetContent(dataPackage);
        }
    }
}
