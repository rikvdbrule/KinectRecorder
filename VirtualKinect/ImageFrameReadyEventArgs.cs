﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualKinect
{
    public sealed class ImageFrameReadyEventArgs : EventArgs
    {
      //  public ImageFrameReadyEventArgs();
        public ImageFrame ImageFrame { get; set; }
    }
}
