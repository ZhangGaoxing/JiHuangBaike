using JiHuangBaike.Data;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public sealed partial class CharacterDialog : Page
    {
        public CharacterDialog(Character c)
        {
            this.InitializeComponent();
            CharacterImage.Source = new BitmapImage(new Uri(c.Image));
            CharacterName.Text = c.Name;
            CharacterEnName.Text = c.EnName;
            CharacterMotto.Text = c.Motto;
            Hunger.Values = new ChartValues<double>(new double[] { c.Hunger });
            Health.Values = new ChartValues<double>(new double[] { c.Health });
            Sanity.Values = new ChartValues<double>(new double[] { c.Sanity });
            CharacterDamage.Text = $"伤害：{c.Damage}";
            CharacterDescription.Text = c.Description;
            CharacterIntroduction.Text = c.Introduction;
        }
    }
}
