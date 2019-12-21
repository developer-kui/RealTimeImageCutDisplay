using RealTimeImageCutDisplay.Properties;
using System;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RealTimeImageCutDisplay
{
    public partial class Form1 : Form
    {
        private string fileName = null;
        private Point point = new Point();
        private Size size = new Size();
        bool capMode = false;

        public Form1()
        {
            InitializeComponent();
            ScreenSetting();

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
                //**バージョン取得
                this.Text += " v" + ad.CurrentVersion.ToString();
                //**最終更新日取得                //update_date = "最終更新日:" + ad.TimeOfLastUpdateCheck.ToLongDateString().ToString();
            }
            else
            {
                this.Text += " v1.0";
            }
            this.Text += " Created By kui";

            textBoxDirectory.Text = Settings.Default.Directory;
        }
        private int TextParse(string text)
        {
            int result = 0;
            if(int.TryParse(text, out result) == false){
                result = 0;
            }
            return result;
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            ImageUpdate();
        }
        private string GetNewImageFileName()
        {
            string fileName = "";
            string dir = textBoxDirectory.Text;
            try
            {
                if (string.IsNullOrWhiteSpace(dir) == false)
                {
                    var files = Directory.GetFiles(dir).OrderBy(f => File.GetLastWriteTime(f));
                    fileName = files.Last();
                }
            }
            catch (Exception)
            {

            }
            return fileName;
        }

        private void ScreenSetting()
        {
            int w = Settings.Default.ClientFormSize.Width;
            int h = Settings.Default.ClientFormSize.Height;
            int x = Settings.Default.ClientFormPoint.X;
            int y = Settings.Default.ClientFormPoint.Y;
            if (Screen.PrimaryScreen.Bounds.Width < w)
            {
                w = Screen.PrimaryScreen.Bounds.Width / 2;
            }

            if (Screen.PrimaryScreen.Bounds.Height < h)
            {
                h = Screen.PrimaryScreen.Bounds.Height / 2;
            }

            if (x < 0)
            {
                x = 0;
            }
            if (y < 0)
            {
                y = 0;
            }

            this.Size = new Size(w, h);
            this.Location = new Point(x, y);
        }
        private void ScreenCapture()
        {
            Point point = new Point(TextParse(textBoxX.Text), TextParse(textBoxY.Text));
            Size size = new Size(TextParse(textBoxWidth.Text), TextParse(textBoxHeight.Text));
            Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Bitmap img = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(img))
                {
                    //画面全体をコピーする
                    g.CopyFromScreen(new Point(0, 0), new Point(0, 0), img.Size);
                    g.Dispose();
                }
                //ImageオブジェクトのGraphicsオブジェクトを作成する

                using (Graphics g = Graphics.FromImage(canvas))
                {
                    //切り取る部分の範囲を決定する。ここでは、位置(10,10)、大きさ100x100
                    Rectangle srcRect = new Rectangle(point, size);
                    //描画する部分の範囲を決定する。ここでは、位置(0,0)、大きさ100x100で描画する
                    Rectangle desRect = new Rectangle(0, 0, pictureBox1.Size.Width, pictureBox1.Size.Height);

                    //補間方法として最近傍補間を指定する
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                    //画像の一部を描画する
                    g.DrawImage(img, desRect, srcRect, GraphicsUnit.Pixel);
                    g.Dispose();
                }
                img.Dispose();
            }
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            }
            //PictureBox1に表示する
            pictureBox1.Image = canvas;
        }
        private void ImageUpdate(bool resize = false)
        {
            string fileName = GetNewImageFileName();
            Point point = new Point(TextParse(textBoxX.Text), TextParse(textBoxY.Text));
            Size size = new Size(TextParse(textBoxWidth.Text), TextParse(textBoxHeight.Text));

            if (string.IsNullOrWhiteSpace(fileName) == false &&
                (this.fileName != fileName || this.point != point || this.size != size || resize))
            {
                this.fileName = fileName;
                this.point = point;
                this.size = size;

                try
                {
                    //描画先とするImageオブジェクトを作成する
                    Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    //ImageオブジェクトのGraphicsオブジェクトを作成する

                    using (Graphics g = Graphics.FromImage(canvas))
                    {
                        using (Bitmap img = new Bitmap(fileName))
                        {
                            //切り取る部分の範囲を決定する。ここでは、位置(10,10)、大きさ100x100
                            Rectangle srcRect = new Rectangle(point, size);
                            //描画する部分の範囲を決定する。ここでは、位置(0,0)、大きさ100x100で描画する
                            Rectangle desRect = new Rectangle(0, 0, pictureBox1.Size.Width, pictureBox1.Size.Height);

                            //補間方法として最近傍補間を指定する
                            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                            //画像の一部を描画する
                            g.DrawImage(img, desRect, srcRect, GraphicsUnit.Pixel);

                            img.Dispose();
                        }
                        g.Dispose();
                    }

                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }
                    //PictureBox1に表示する
                    pictureBox1.Image = canvas;                

                    Settings.Default.Directory = textBoxDirectory.Text;
                    Settings.Default.ImagePoint = point;
                    Settings.Default.ImageSize = size;
                    Settings.Default.Save();
                }
                catch (Exception)
                {

                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ImageUpdate();
        }


        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (Settings.Default.ClientFormSize != this.Size)
            {
                if (capMode)
                {
                    ScreenCapture();
                }
                else
                {
                    ImageUpdate(true);
                }
                Settings.Default.ClientFormSize = this.Size;
                Settings.Default.Save();
            }
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if (Settings.Default.ClientFormPoint != this.Location)
            {
                Settings.Default.ClientFormPoint = this.Location;
                Settings.Default.Save();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialogクラスのインスタンスを作成
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            //上部に表示する説明テキストを指定する
            fbd.Description = "フォルダを指定してください。";
            //ルートフォルダを指定する
            //デフォルトでDesktop
            fbd.RootFolder = Environment.SpecialFolder.Desktop;

            //ダイアログを表示する
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                textBoxDirectory.Text = fbd.SelectedPath;
                capMode = false;
            }
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (capMode == false)
            {
                ImageUpdate(true);
            }
        }
        private void capButton_Click(object sender, EventArgs e)
        {
            capMode = true;
            textBoxDirectory.Text = "";
            fileName = null;

            Settings.Default.Directory = "";
            Settings.Default.Save();

            ScreenCapture();
        }
    }
}
