using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace JiHuangBaike.Manager
{
    class SettingSet
    {
        const string SETTING_THEME = "Theme";

        public static void ThemeSettingSet(int index)
        {
            var rootContainer = ApplicationData.Current.LocalSettings;

            rootContainer.Values[SETTING_THEME] = index;
        }

        public static int ThemeSettingRead()
        {
            var rootContainer = ApplicationData.Current.LocalSettings;
            object themeIndex;

            if (rootContainer.Values.TryGetValue(SETTING_THEME, out themeIndex))
            {
                return (int)themeIndex;
            }
            else
            {
                return 1;
            }
        }
    }
}
