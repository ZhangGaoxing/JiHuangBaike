using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace JiHuangBaike.Data
{
    public class Skin
    {
        public string Picture { get; set; }

        public string Name { get; set; }

        public string EnName { get; set; }

        public string Introduction { get; set; }

        public string Rarity { get; set; }

        public SolidColorBrush Color { get; set; }
    }
}
