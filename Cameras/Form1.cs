using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Events
{
    public partial class Form1 : Form
    {
        Bitmap bmp;


        public Form1()
        {
            InitializeComponent();
        }




        private void Capture_Click(object sender, EventArgs e)
        {

            //initialize the event handler here as well...

            getJpeg jpeg = new getJpeg();
            jpeg.onepic += new CameraEventHandler(Display_Pic);
            jpeg.update();
            


        }

        private void Display_Pic(object a, Stream_Form e)
        {
            bmp = e.bitmap;
            stream.Image = bmp;
        }


    }
}

