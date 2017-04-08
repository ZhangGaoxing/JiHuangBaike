using JiHuangBaike.Data;
using LiveCharts;
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
    public sealed partial class CreatureDialog : Page
    {
        public CreatureDialog(Creature c)
        {
            this.InitializeComponent();

            CreatureImage.Source = new BitmapImage(new Uri(c.Picture));
            CreatureName.Text = c.Name;
            CreatureEnName.Text = c.EnName;
            ROG.IsChecked = c.IsROG;
            SW.IsChecked = c.IsSW;
            DST.IsChecked = c.IsDST;
            Health.Values = new ChartValues<double>(new double[] { c.Health });
            HealthDST.Values = new ChartValues<double>(new double[] { c.HealthDST });
            Attack.Values = new ChartValues<double>(new double[] { c.Attack });
            AttackInterval.Values = new ChartValues<double>(new double[] { c.AttackInterval });
            AttackScope.Values = new ChartValues<double>(new double[] { c.AttackScope });
            MoveSpeed.Values = new ChartValues<double>(new double[] { c.MoveSpeed });
            RunSpeed.Values = new ChartValues<double>(new double[] { c.RunSpeed });
            Dangerous.Text = c.Dangerous.ToString();
            SanityEffect.Text = c.SanityEffect.ToString();
            ActiveAttack.IsChecked = c.IsActiveAttack;
            TeamWork.IsChecked = c.IsTeamWork;
            Goods.Text = c.Goods;
            Ability.Text = c.Ability;
            Console.Text = c.Console;
            CreatureIntroduction.Text = c.Introduction;
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText(Console.Text);
            Clipboard.SetContent(dataPackage);
        }
    }
}
