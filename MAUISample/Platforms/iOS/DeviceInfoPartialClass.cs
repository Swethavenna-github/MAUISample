﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISample
{
    public partial class DeviceInfoPartialClass
    {
        public partial string GetDeviceInfo()
        {
            return UIKit.UIDevice.CurrentDevice.Model;

        }
    }
}