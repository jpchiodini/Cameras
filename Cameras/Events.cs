using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Events
{
    public delegate void CameraEventHandler(object sender, Stream_Form e);


    public class Stream_Form : EventArgs
    {
        //bitmap to return
        private Bitmap bmp;

        public Bitmap bitmap
        { get { return bmp; } }

        public Stream_Form(Bitmap bmp)
        {
            this.bmp = bmp;
        }

    }
}
