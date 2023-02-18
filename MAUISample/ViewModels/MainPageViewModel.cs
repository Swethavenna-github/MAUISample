using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISample.ViewModels
{
   public  class MainPageViewModel
    {

        private readonly IDeviceInfoService _deviceInfoService;

        public MainPageViewModel(IDeviceInfoService deviceInfoService) 
        {
            _deviceInfoService= deviceInfoService;
        }
        
        public string DeviceModel { get; set; }

       
        private void GetDeviceModel()
        {
            DeviceModel=_deviceInfoService.GetDeviceModel();
        }

        public string DeviceModelPartial { get; set; }
        private void GetDeviceModelUsingPartialClassMethod()
        {
            DeviceModelPartial = new DeviceInfoPartialClass().GetDeviceInfo();
        }
    }
}
