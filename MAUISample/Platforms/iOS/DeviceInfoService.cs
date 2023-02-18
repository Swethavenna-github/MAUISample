
namespace MAUISample.Platforms.iOS
{
    public class DeviceInfoService : IDeviceInfoService
    {
        public string GetDeviceModel()
        {
            return UIKit.UIDevice.CurrentDevice.Model;

        }
    }
}
