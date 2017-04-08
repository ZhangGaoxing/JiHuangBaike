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
    public sealed partial class FoodRecipeDialog : Page
    {
        public FoodRecipeDialog(FoodRecipe fr)
        {
            this.InitializeComponent();

            RecipeImage.Source = new BitmapImage(new Uri(fr.Image));
            RecipeName.Text = fr.Name;
            RecipeEnName.Text = fr.EnName;
            RecipeNeed.Text = fr.Need;
            Hunger.Values = new ChartValues<double>(new double[] { fr.Hunger });
            Health.Values = new ChartValues<double>(new double[] { fr.Health });
            Sanity.Values = new ChartValues<double>(new double[] { fr.Sanity });
            Cooktime.Values = new ChartValues<double>(new double[] { fr.Cooktime });
            Perish.Values = new ChartValues<double>(new double[] { fr.Perish });
            Recommend1.Source = new BitmapImage(new Uri(fr.Recommend1));
            Recommend2.Source = new BitmapImage(new Uri(fr.Recommend2));
            Recommend3.Source = new BitmapImage(new Uri(fr.Recommend3));
            Recommend4.Source = new BitmapImage(new Uri(fr.Recommend4));
            RecipeIntroduction.Text = fr.Introduction;
            Console.Text = fr.Console;
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText(Console.Text);
            Clipboard.SetContent(dataPackage);
        }
    }
}
