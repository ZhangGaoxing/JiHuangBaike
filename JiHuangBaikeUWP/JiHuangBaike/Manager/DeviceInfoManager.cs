using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System.Profile;

namespace JiHuangBaike.Manager
{
    public class DeviceInfoManager
    {
        public static ulong GetOsVersion()
        {
            ulong version = Convert.ToUInt64(AnalyticsInfo.VersionInfo.DeviceFamilyVersion);
            return version >> 16 & 0xFFFF;
        }
    }
}
