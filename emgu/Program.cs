using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using System.Drawing;

namespace emgu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Image<Bgr, byte> image1 = new Image<Bgr, byte>(480, 320,new Bgr(255,0,0));
            //Image<Gray,byte> image2=image1.Convert<Gray, byte>();
            //Console.WriteLine(image2.Data[0,0,0]);
           // image2.Save("image1.jpg");
            Capture cap = new Capture("C:\\Users\\Hank\\Downloads\\camera1.mov");

            Mat m = cap.QueryFrame();
            int i = 0;
           // // Console.Write(cap.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount));
           // m.ToImage<Bgr, byte>().Save("test1.jpg");
            while (m != null)
            {
                GC.Collect();
                m = cap.QueryFrame();
                i++;
                Console.WriteLine(i);
            }
           // cap = new Capture("C:\\Users\\Hank\\Videos\\Captures\\运动1.mp4");
           // m = cap.QueryFrame();
           // m.Save("test2.jpg");
           // i = 0;
           //// GC.Collect();
           // while (m != null)
           // {
           //     m = cap.QueryFrame();
           //     i++;
           //     Console.WriteLine(i);
           // }
            //var temp1 = m.ToImage<Bgr, byte>();
            //while (temp1 != null)
            //{
            //    m = cap.QueryFrame();
            //    temp1 = m.ToImage<Bgr, byte>();
            //}
            //temp1.Save("test.jpg");
            //cap = new Capture("C:\\Users\\Hank\\Videos\\Captures\\运动1.mp4");
            //m = cap.QueryFrame();
            //var temp2 = m.ToImage<Bgr, byte>();
            //temp2.Save("test.jpg");

            Console.ReadKey();
        }
    }
}
