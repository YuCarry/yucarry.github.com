using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emguWinform
{
    public partial class Form1 : Form
    {
        MovieInfo movieInfo = new MovieInfo();
        Capture cap = new Capture("C:\\Users\\Hank\\Downloads\\camera1.mov");
        Capture Bgcap = new Capture("C:\\Users\\Hank\\Downloads\\camera1.mov");
        Image<Gray, byte> Background;
        public Form1()
        {
            InitializeComponent();
            
            movieInfo.fileName = "测试文件";
            movieInfo.fps = (int)cap.GetCaptureProperty(CapProp.Fps);
            movieInfo.frameCount = (int)cap.GetCaptureProperty(CapProp.FrameCount);
            progressBar1.Maximum = movieInfo.frameCount+1;
            progressBar1.Minimum = 0;
            
            movieInfo.currentFrame = -1;
            movieInfo.state= MovieInfo.State.Playing;

            BackgroundBuild(cap, out Background);
            imageBox2.Image = Background;
            timer1.Start();
        }

        private void BackgroundBuild(Capture cap, out Image<Gray, byte> Background)
        {
            int count = 0;
            Mat m = Bgcap.QueryFrame();
            var firstImage = m.ToImage<Gray, byte>();
            Background = new Image<Gray, byte>(firstImage.Width, firstImage.Height);
            int[,] Array = new int[firstImage.Height, firstImage.Width];
            while (count<=100)
            {

                var image = m.ToImage<Gray, byte>();//灰度化

                for (int i = 0; i < image.Height; i++)
                {
                    for(int j = 0; j < image.Width; j++)
                    {
                        Array[i,j] += image.Data[i,j,0];
                    }
                }
                count++;
                m = Bgcap.QueryFrame();
            }
            for (int i = 0; i < firstImage.Height; i++)
            {
                for(int j = 0; j < firstImage.Width; j++)
                {
                    Background.Data[i, j, 0] =(byte) (Array[i, j] / count);
                }
            }
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            movieInfo.state = MovieInfo.State.Playing;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (movieInfo.state == MovieInfo.State.Playing)
            {
                Mat m = cap.QueryFrame();
                if (movieInfo.currentFrame<movieInfo.frameCount-1)
                {
                    movieInfo.currentFrame++;
                    var image = m.ToImage<Gray, byte>();
                    imageBox1.Image = image;
                    imageBox3.Image = image.AbsDiff(Background);
                    progressBar1.Value = movieInfo.currentFrame;
                }
                else
                {
                    GC.Collect();
                    cap = new Capture("C:\\Users\\Hank\\Downloads\\camera1.mov");
                    movieInfo.currentFrame = 0;
                    movieInfo.state = MovieInfo.State.Paused;
                }
            }else
            {
                timer1.Stop();
            }
            
        }

        private void PAUSE_Click(object sender, EventArgs e)
        {
            movieInfo.state = MovieInfo.State.Paused;
        }

        private void STOP_Click(object sender, EventArgs e)
        {
            movieInfo.state = MovieInfo.State.Stopped;
            cap = new Capture("C:\\Users\\Hank\\Downloads\\camera1.mov");
        }
    }
    public class MovieInfo
    {
        public enum State
        {
            NewMovie, Started, Stopped, Paused, Playing, Scroll, PrevNext
        }
        public State state { get; set; }
        public  string fileName { get; set; }
        public  int frameCount { get; set; }
        public  int currentFrame { get; set; }
        public  int fps { get; set; }
    }

}
