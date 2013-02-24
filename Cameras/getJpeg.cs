using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Drawing;



namespace Events
{


    class getJpeg
    {

        // \r\n\r\n
        utilityLibrary ul = new utilityLibrary();
        byte[] delimeter = { 13, 10, 13, 10 };
        byte[] delimeter2 = { 13, 10 };
        int delimeterlen = 4;
        int delimeterlen2 = 2;
        int read = 0;
        int pos = 0, pos2 = 0;
        int offset = 0;
        int readSize = 1024;
        byte[] buffer = new byte[512 * 1024];
        byte[] boundary = null;
        public event CameraEventHandler onepic;

        public void update()
        {



            string source = "http://ptz1-iss.bu.edu/axis-cgi/mjpg/video.cgi?fps=5";//?des_fps=5
            // create request
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(source);

            // get response
            WebResponse resp = req.GetResponse();

            // check content type
            string ct = resp.ContentType;
            Console.WriteLine(ct);
            if (ct.IndexOf("multipart/x-mixed-replace") == -1)
                throw new ApplicationException("Invalid URL");


            // get boundary
            ASCIIEncoding encoding = new ASCIIEncoding();

            //converts the boundary to bytes
            boundary = encoding.GetBytes(ct.Substring(ct.IndexOf("boundary=", 0) + 9));

            Stream stream = resp.GetResponseStream();

            bool foundend = false;

            // while (true)
            // {

            while (foundend == false)
            {
                //read stream
                read = stream.Read(buffer, offset, readSize);
                offset += readSize;

                //first boundary position
                pos = ul.subarrayIndex(buffer, delimeter, pos);

                pos2 = ul.subarrayIndex(buffer, boundary, pos);               
                if (pos2 != -1)
                {
                    break;
                }
                pos = 0;
                pos2 = 0;
            }


            //####  a possible problem could be duplicates in reading the stream... check that its done correctly...

            pos += delimeterlen;

            //create a public event to send the bitmap...
            Bitmap bmp = (Bitmap)Bitmap.FromStream(new MemoryStream(buffer, pos, pos2 - 2 - pos)); //
            
            //sends one frame...
            onepic(this, new Stream_Form(bmp));
            

            //shift the array down... this part seems to be correct...
            //Array.Copy(buffer, pos2, buffer, 0, buffer.Length - pos2);
            //offset -= pos2 ;
            //offset = offset - pos2;
            //pos = 0;
            //pos2 = 0;


            // }
        }
    }
}



