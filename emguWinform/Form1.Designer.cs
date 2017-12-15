using Emgu.CV.CvEnum;

namespace emguWinform
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.PLAY = new System.Windows.Forms.Button();
            this.PAUSE = new System.Windows.Forms.Button();
            this.STOP = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(0, 0);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(273, 383);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.Click += new System.EventHandler(this.imageBox1_Click);
            // 
            // PLAY
            // 
            this.PLAY.Location = new System.Drawing.Point(51, 404);
            this.PLAY.Name = "PLAY";
            this.PLAY.Size = new System.Drawing.Size(75, 23);
            this.PLAY.TabIndex = 4;
            this.PLAY.Text = "播放";
            this.PLAY.UseVisualStyleBackColor = true;
            this.PLAY.Click += new System.EventHandler(this.button2_Click);
            // 
            // PAUSE
            // 
            this.PAUSE.Location = new System.Drawing.Point(146, 404);
            this.PAUSE.Name = "PAUSE";
            this.PAUSE.Size = new System.Drawing.Size(75, 23);
            this.PAUSE.TabIndex = 5;
            this.PAUSE.Text = "暂停";
            this.PAUSE.UseVisualStyleBackColor = true;
            this.PAUSE.Click += new System.EventHandler(this.PAUSE_Click);
            // 
            // STOP
            // 
            this.STOP.Location = new System.Drawing.Point(243, 404);
            this.STOP.Name = "STOP";
            this.STOP.Size = new System.Drawing.Size(75, 23);
            this.STOP.TabIndex = 6;
            this.STOP.Text = "停止";
            this.STOP.UseVisualStyleBackColor = true;
            this.STOP.Click += new System.EventHandler(this.STOP_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(541, 404);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(358, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 4;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(270, 0);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(338, 383);
            this.imageBox2.TabIndex = 8;
            this.imageBox2.TabStop = false;
            // 
            // imageBox3
            // 
            this.imageBox3.Location = new System.Drawing.Point(626, 0);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(273, 383);
            this.imageBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageBox3.TabIndex = 9;
            this.imageBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 439);
            this.Controls.Add(this.imageBox3);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.STOP);
            this.Controls.Add(this.PAUSE);
            this.Controls.Add(this.PLAY);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button PLAY;
        private System.Windows.Forms.Button PAUSE;
        private System.Windows.Forms.Button STOP;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private Emgu.CV.UI.ImageBox imageBox3;
    }
}

