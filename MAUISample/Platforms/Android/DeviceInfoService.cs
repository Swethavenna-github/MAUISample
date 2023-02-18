
using Android.OS;

namespace MAUISample.Platforms.Android
{
    public class DeviceInfoService : IDeviceInfoService
    {
        public string GetDeviceModel()
        {
            return Build.Model;
        }
    }
}
