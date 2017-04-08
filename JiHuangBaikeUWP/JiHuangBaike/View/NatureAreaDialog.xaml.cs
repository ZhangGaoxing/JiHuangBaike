using JiHuangBaike.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class NatureAreaDialog : Page
    {       
        private ObservableCollection<BindingImage> abundantData = new ObservableCollection<BindingImage>();
        private ObservableCollection<BindingImage> occasionalData = new ObservableCollection<BindingImage>();
        private ObservableCollection<BindingImage> rareData = new ObservableCollection<BindingImage>();

        public NatureAreaDialog(NatureArea na)
        {
            this.InitializeComponent();

            GetImage(na);
            AreaImage.Source = new BitmapImage(new Uri(na.Picture));
            AreaName.Text = na.Name;
            AreaEnName.Text = na.EnName;
            ROG.IsChecked = na.IsROG;
            SW.IsChecked = na.IsSW;
            DST.IsChecked = na.IsDST;
            AreaIntroduction.Text = na.Introduction;
        }

        public void GetImage(NatureArea na)
        {
            foreach (var item in na.Abundant)
            {
                abundantData.Add(
                    new BindingImage
                    {
                        ImagePath = $"ms-appx:///Assets/GameResources/{item}.png"
                    });
            }

            foreach (var item in na.Occasional)
            {
                occasionalData.Add(
                    new BindingImage
                    {
                        ImagePath = $"ms-appx:///Assets/GameResources/{item}.png"
                    });
            }

            foreach (var item in na.Rare)
            {
                rareData.Add(
                    new BindingImage
                    {
                        ImagePath = $"ms-appx:///Assets/GameResources/{item}.png"
                    });
            }
        }
    }
}
