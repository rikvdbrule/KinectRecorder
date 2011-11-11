﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualKinect
{
    [Serializable]
    public class Vector
    {
        public float W { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public Microsoft.Research.Kinect.Nui.Vector NUI
        {
            get
            {

                Microsoft.Research.Kinect.Nui.Vector r = new Microsoft.Research.Kinect.Nui.Vector();
                r.W = this.W;
                r.X = this.X;
                r.Y = this.Y;
                r.Z = this.Z;
                return r;
            }
            set
            {
              this.W = value.W;
                this.X = value.X;
                this.Y = value.Y;
                this.Z = value.Z;
            }
        }
    }
}
