using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using AForge.Video.DirectShow;
using PictureEngine;
using System.Drawing.Imaging;
using System.Threading;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace ImageTest
{
    public partial class Form2 : Form
    {
        FilterInfoCollection videoDevices;
        string nowFile { get; set; }
        string path { get; set; }
        ImageEngine imageEngine=new ImageEngine();
        bool Is1080P=false;
        bool changePos { get; set; }
     // private string windowName = "WindowsForms10.Window.8.app.0.141b42a_r39_ad1";
   //   private string windowName = "WindowsForms10.Window.8.app.0.141b42a_r9_ad1";
        private string windowName = "WindowsForms10.Window.8.app.0.141b42a_r10_ad1";
        int degree
        {
            get
            {
                if (Is1080P)
                    return 3;
                else
                    return 2;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            /*path = @"C:\Users\Bizat\Desktop\FIFA\Sign1V1\bin\Debug\template\";
            DirectoryInfo dir = new DirectoryInfo(path);

            FileInfo[] files = dir.GetFiles();
            foreach(FileInfo file in files)
            {
                cameraList.Items.Add(file.Name);
            }
            if(files.Length>0)
            {
                nowFile = files[files.Length - 1].Name;
                updatePicture();
                cameraList.SelectedItem = nowFile;
            }
            
            */
            /*
            try
            {

                
                // enumerate video devices
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                {
                    throw new Exception();
                }

                for (int i = 1, n = videoDevices.Count; i <= n; i++)
                {
                    string cameraName = i + " : " + videoDevices[i - 1].Name;

                    cameraList.Items.Add(cameraName);
                   
                }
                cameraList.SelectedIndex = 0;
                Is1080P = is1080P.Checked;
               
            }
            catch
            {
               cameraList.Items.Add("No cameras found");
               cameraList.SelectedIndex = 0;
               cameraList.Enabled = false;
               
            }
            // list of video devices
            Console.WriteLine(videoDevices.Count);
            pictureBox1.Visible=false;
            stop.Enabled = false;
            findPictureTest.Enabled = false;
            pos.SelectedIndex = 0;
            */
            //Process[] processes = Process.GetProcessesByName("ForkRemote3");
            Process[] processes = Process.GetProcessesByName("chiaki");
            foreach (Process process in processes)
            {
                cameraList.Items.Add(process.MainWindowTitle+","+process.Id);
            }
            cameraList.SelectedIndex = 0;


        }
        private void updatePicture()
        {
            /*
            Bitmap bmp = imageEngine.PsBmp;
            Bitmap bmp1;
            if(isSplit.Checked)
            {
                int num = pos.SelectedIndex;
                int yIndex = (int)Math.Floor((double)num / 2);
                
                bmp1 = bmp.Clone(new Rectangle((int)Math.Floor((double)num % 2) * bmp.Width / 2,  yIndex* bmp.Height / 2, bmp.Width / 2, bmp.Height / 2),System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            }
            else
                bmp1 = new Bitmap(bmp, bmp.Width / degree, bmp.Height / degree);
            pictureBox1.Image = bmp1;
            imageEngine.SourceBmp = bmp1;
            imageEngine.PsBmp = bmp;
           */

        }
        private void start_Click(object sender, EventArgs e)
        {
            var process = Process.GetProcessById(int.Parse(cameraList.Text.Split(',')[1]));
            IntPtr handle = WindowControl.FindWindowEx(process.MainWindowHandle, IntPtr.Zero, windowName, null);
            pictureBox1.Image = BackgroundCapture.CaptureWindow(handle);
            imageEngine.SourceBmp = (Bitmap)pictureBox1.Image;
            /*
            DirectoryInfo dir = new DirectoryInfo(path);

            FileInfo[] files = dir.GetFiles();
            bool find = false;
            foreach(FileInfo file in files)
            {
                if (find)
                {
                    nowFile = file.Name;
                    break;
                }                   
                if(nowFile==file.Name)
                {
                    find = true ;
                }
            }
            //cameraList.Text = nowFile;

            // create first video source


         

            VideoCaptureDevice videoSource1 = new VideoCaptureDevice(videoDevices[cameraList.SelectedIndex].MonikerString);
            videoSource1.DesiredFrameRate = 10;
            
            
           
            if(is1080P.Checked==true)
            videoSource1.VideoResolution = videoSource1.VideoCapabilities[12];
            else
            {
                videoSource1.VideoResolution = videoSource1.VideoCapabilities[5];
            }
            
   
            if (!psVideoSource.IsRunning)
            {
                psVideoSource.VideoSource = videoSource1;
                psVideoSource.Start();
            }
            start.Enabled = false;
            stop.Enabled = true;
            pictureBox1.Visible = false;
            
             */

        }

        private void stop_Click(object sender, EventArgs e)
        {
           
           
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
            Bitmap grayBmp = (Bitmap) imageEngine.SourceBmp.Clone();
            pictureBox1.Image = imageEngine.ToGray(grayBmp);
            timer1.Interval = 20;
            timer1.Start();
            imageEngine.MouseStartPoint = pictureBox1.PointToClient(MousePosition);
            imageEngine.MouseEndPoint = pictureBox1.PointToClient(MousePosition);
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {           
            pictureBox1.Image = imageEngine.SourceBmp;
            if(pictureBox2.Image!=null)
            hashBox.Text = ImageHashing.AverageHash(pictureBox2.Image).ToString(); 
            timer1.Stop();

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Bitmap grayBmp = (Bitmap)imageEngine.SourceBmp.Clone();
            pictureBox1.Image = imageEngine.ToGrayBlank(grayBmp);
            pictureBox2.Image = imageEngine.ShowSelectPicture(imageEngine.SourceBmp,1);
            pictureBox3.Image = imageEngine.ShowSelectPicture(imageEngine.SourceBmp, 1);
            //pictureBox3.Image = imageEngine.ShowSelectPicture(imageEngine.PsBmp,degree);
           
            mousePosition.Text = imageEngine.MouseStartPoint.X + "," + imageEngine.MouseStartPoint.Y + "," +
                                 imageEngine.MouseEndPoint.X + "," + imageEngine.MouseEndPoint.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(changePos)
            {
                imageEngine.MouseEndPoint = pictureBox1.PointToClient(MousePosition);
                pointPos.Text = imageEngine.MouseEndPoint.X + "," + imageEngine.MouseEndPoint.Y;
            }
            
            /*
            Color color= imageEngine.SourceBmp.GetPixel(imageEngine.MouseEndPoint.X, imageEngine.MouseEndPoint.Y);
            pointColor.Text = "R " + color.R + " G " + color.G + " B " + color.B;
            int X = Math.Abs(imageEngine.MouseEndPoint.X - 10);
            int Y = Math.Abs(imageEngine.MouseEndPoint.Y - 10);
            Bitmap bmp = imageEngine.SourceBmp.Clone(new Rectangle(X, Y, X+21> imageEngine.SourceBmp.Width?1:21,Y + 21 > imageEngine.SourceBmp.Height? 1 : 21), PixelFormat.Format24bppRgb);
            pictureBox4.Image= new Bitmap(bmp, bmp.Width *5, bmp.Height *5);
            Graphics g = Graphics.FromImage(pictureBox4.Image);
            g.DrawRectangle(new Pen(Color.Blue,1), 50, 50, 5, 5);//通过画线方法或其它方法
            */

        }
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void findPictureTest_Click(object sender, EventArgs e)
        {
            
            Rectangle rectangle=new Rectangle();
            string[] filters=new string[0];
            List<Point> points =new List<Point>();
            
          
            imageEngine.DstBmp = (Bitmap)pictureBox2.Image;
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            points = imageEngine.findPicture(rectangle, 0.85f, filters);
            stopwatch.Stop();
            if (points.Count > 0)
            {
                Console.WriteLine(stopwatch.Elapsed.TotalSeconds);
                pictureResult.Text=points[0].X + "," + points[0].Y;
               
            }
        }

        private void savePicture_Click(object sender, EventArgs e)
        {
             string sPath = Directory.GetCurrentDirectory() + "\\template";
            //string sPath = @"F:\OneDrive\代码\DNFControl\DNFControlSingle\bin\Debug\template";
            if (!Directory.Exists(sPath))
            {
                Directory.CreateDirectory(sPath);
            }
            savePictureDialog.InitialDirectory =sPath ;
            savePictureDialog.Filter = "Bmp files (*.bmp)|*.bmp|All files (*.*)|*.*";
            savePictureDialog.FileName = savePictureName.Text + ".bmp";
            DialogResult result = savePictureDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (tabControl1.SelectedIndex == 0)
                    pictureBox2.Image.Save(savePictureDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                else
                {
                    pictureBox3.Image.Save(savePictureDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                }
            }

        }

        private void openPicture_Click(object sender, EventArgs e)
        {
            string sPath = Directory.GetCurrentDirectory() + "\\template";
            //string sPath = @"F:\OneDrive\代码\DNFControl\DNFControlSingle\bin\Debug\template";
            if (!Directory.Exists(sPath))
            {
                Directory.CreateDirectory(sPath);
            }
            openPictureDialog.InitialDirectory = sPath;
            openPictureDialog.Filter = "Bmp files (*.bmp)|*.bmp|All files (*.*)|*.*";
            openPictureDialog.FileName = savePictureName.Text + ".bmp";
            DialogResult result = openPictureDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if(tabControl1.SelectedIndex==0)
                pictureBox2.Image=Image.FromFile(openPictureDialog.FileName);
                else
                {
                    pictureBox3.Image = Image.FromFile(openPictureDialog.FileName);
                }
            }
        }



        private void findTextTest_Click(object sender, EventArgs e)
        {
            string code = string.Empty;
            Bitmap newBmp=(Bitmap)pictureBox3.Image.Clone();
            code=imageEngine.findText(newBmp);
            textResult.Text = code;
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string sPath = Directory.GetCurrentDirectory() + "\\template\\bmp.txt";
            Bitmap bmp = (Bitmap)pictureBox2.Image;
            using (StreamWriter writer = new StreamWriter(sPath))
            {
                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        //获取该点的像素的RGB的颜色
                        Color color = bmp.GetPixel(i, j);
                        writer.WriteLine("{0},{1}:{2},{3},{4}",i,j,color.R,color.G,color.B);
                        //利用公式计算灰度值
                       
                    }
                }
                
                
            }*/
            string code = string.Empty;
            Bitmap newBmp = (Bitmap)pictureBox3.Image.Clone();
            code = imageEngine.findTextC(newBmp);
            textResult.Text = code;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            /*
            Bitmap bmp = (Bitmap)pictureBox3.Image;
            Bitmap selectedBmp= Binaryzation(bmp,100);
            pictureBox3.Image = selectedBmp;
            */
            //GenerateHighThumbnail(pictureBox3.Image, "单行原图C5倍.bmp",2);
            pictureBox3.Image = KiResizeImage((Bitmap)pictureBox3.Image);
        }
        public static Bitmap KiResizeImage(Bitmap bmp)
        {
            try
            {
                Bitmap b = new Bitmap(bmp.Width*2,bmp.Height*2);
                Graphics g = Graphics.FromImage(b);
                // 插值算法的质量
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(bmp, new Rectangle(0, 0, bmp.Width * 2, bmp.Height *2), new Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
                g.Dispose();
                return b;
            }
            catch
            {
                return null;
            }
        }
        public Bitmap Binaryzation(Bitmap bmp, int threshold)
        {
            Console.WriteLine("bmp格式：" + bmp.PixelFormat.ToString());
            Bitmap newBmp = (Bitmap)bmp.Clone();


            //获取颜色
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    //获取该点的像素的RGB的颜色
                    Color color = newBmp.GetPixel(i, j);
                    if (color.R > threshold && color.G > threshold && color.B > threshold)
                    {

                        color = Color.White;
                        newBmp.SetPixel(i, j, color);
                    }

                    else
                    {
                        color = Color.Black;
                        newBmp.SetPixel(i, j, color);
                    }
                }
            }


            Console.WriteLine("newBmp格式：" + newBmp.PixelFormat.ToString());
            return newBmp;
        }
        //使用方法调用GenerateHighThumbnail()方法即可  
        //参数oldImagePath表示要被缩放的图片路径  
        //参数newImagePath表示缩放后保存的图片路径  
        //参数width和height分别是缩放范围宽和高  
        public static void GenerateHighThumbnail(Image oldImage, string newImagePath, int scale)
        {

            int newWidth = AdjustSize(oldImage.Width * scale, oldImage.Height * scale, oldImage.Width, oldImage.Height).Width;
            int newHeight = AdjustSize(oldImage.Width * scale, oldImage.Height * scale, oldImage.Width, oldImage.Height).Height;
            //。。。。。。。。。。。  
            System.Drawing.Image thumbnailImage = oldImage.GetThumbnailImage(newWidth, newHeight, new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);
            System.Drawing.Bitmap bm = new System.Drawing.Bitmap(thumbnailImage);
            //处理jpeg质量的函数  
            System.Drawing.Imaging.ImageCodecInfo ici = GetEncoderInfo("image/jpeg");
            if (ici != null)
            {
                System.Drawing.Imaging.EncoderParameters ep = new System.Drawing.Imaging.EncoderParameters(1);
                ep.Param[0] = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)100);
                bm.Save(newImagePath, ici, ep);
                
                //释放所有资源，不释放，可能会出错误。  
                ep.Dispose();
                ep = null;
            }
            ici = null;
            bm.Dispose();
            bm = null;
            thumbnailImage.Dispose();
            thumbnailImage = null;
          
        }


        private static bool ThumbnailCallback()
        {
            return false;
        }


        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }


        public struct PicSize
        {
            public int Width;
            public int Height;
        }


        public static PicSize AdjustSize(int spcWidth, int spcHeight, int orgWidth, int orgHeight)
        {
            PicSize size = new PicSize();

            // 取得比例系数   
            float w = orgWidth / (float)spcWidth;
            float h = orgHeight / (float)spcHeight;
            // 宽度比大于高度比   
            if (w > h)
            {
                size.Width = spcWidth;
                size.Height = (int)(w >= 1 ? Math.Round(orgHeight / w) : Math.Round(orgHeight * w));
            }
            // 宽度比小于高度比   
            else if (w < h)
            {
                size.Height = spcHeight;
                size.Width = (int)(h >= 1 ? Math.Round(orgWidth / h) : Math.Round(orgWidth * h));
            }
            // 宽度比等于高度比   
            else
            {
                size.Width = spcWidth;
                size.Height = spcHeight;
            }

            return size;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openPicture_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //savePicture_Click(sender, e);
            GenerateHighThumbnail(pictureBox3.Image, "单行原图C5倍.bmp", 5);
        }

        private void is1080P_CheckedChanged(object sender, EventArgs e)
        {
          //  psVideoSource.SignalToStop();
            //psVideoSource.WaitForStop();
            start_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Point point = imageEngine.KnownColor2Pos(imageEngine.SourceBmp, colorName.Text, 10);
            //pictureResult.Text = point.X + "," + point.Y;
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            var process = Process.GetProcessById(int.Parse(cameraList.Text));
            IntPtr handle = WindowControl.FindWindowEx(process.MainWindowHandle, IntPtr.Zero, windowName, null);
            
            Bitmap bitmap1 = (Bitmap)BackgroundCapture.CaptureWindow(handle);
            Bitmap bmp = new Bitmap(bitmap.Width, bitmap.Height);
            for(int i=0;i<bitmap.Width;i++)
                for(int j=0;j<bitmap.Height;j++)
                {
                    if (i > 600 && j < 100)
                        continue;
                    if (i > 750 && j > 100)
                        continue;
                    Color color = bitmap.GetPixel(i, j);
                    Color color1 = bitmap1.GetPixel(i, j);
                    if (color==color1)
                    {
                        bmp.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        int limit = Math.Abs(color.R - color1.R) + Math.Abs(color.G - color1.G) + Math.Abs(color.B - color1.B);
                        Console.WriteLine(limit);
                        if (limit > 255)
                        {
                            limit = limit - 255;
                            
                        }  
                        else
                        {
                            if (limit < 80||color.R<color.G)
                                bmp.SetPixel(i, j, Color.Black);
                            else
                            // bmp.SetPixel(i, j, Color.FromArgb(limit, 255, 255));
                            {
                                pictureResult.Text = i + "," + j;
                                break;
                            }

                        }
                        

                    }
                       
                }
            pictureBox1.Image = bmp;
            /*
            Bitmap bitmap;
            Bitmap bmp;
            for(int i=0;i<100;i++)
            {
                bmp = (Bitmap)psVideoSource.GetCurrentVideoFrame();
                int num = 1;
                int yIndex = (int)Math.Floor((double)num / 2);
               
                bitmap = bmp.Clone(new Rectangle((int)Math.Floor((double)num % 2) * bmp.Width / 2, yIndex * bmp.Height / 2, bmp.Width / 2, bmp.Height / 2), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                bitmap.Save("test.bmp");
                Color color = bitmap.GetPixel(844, 80);
                Console.WriteLine("R " + color.R + " G " + color.G + " B " + color.B);
                Thread.Sleep(10);
            }
           */

            /*
            bool find=imageEngine.HaveKnownColor2((Bitmap)pictureBox4.Image, colorName.Text, 10);
            pictureResult.Text = find.ToString();
            



            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            Bitmap bitmap1 = (Bitmap)psVideoSource.GetCurrentVideoFrame();
            Bitmap bmp = new Bitmap(bitmap.Width, bitmap.Height);
            
            for (int i = 2; i < bitmap.Width - 2; i += 2)
                for (int j = 0; j < bitmap.Height; j += 2)
                            
                {
                    Color color = bitmap.GetPixel(i, j);
                    //if( color.R  <= color.G && color.R  <= color.B)
                    if(color.R+ color.G+ color.B==0)
                    {
                        color = bitmap.GetPixel(i+1, j);
                        if (color.R > 0xa0 && color.R < 0xc0 && color.G > 0x90 && color.G < 0xb0&&color.B>0x70&&color.B<0x90)
                        {
                            bmp.SetPixel(i, j, Color.Red);
                            i += 2;
                        }
                            
                        else
                        {
                            color = bitmap.GetPixel(i - 1, j);
                            if (color.R > 0xa0 && color.R < 0xc0 && color.G > 0x90 && color.G < 0xb0 && color.B > 0x70 && color.B < 0x90)
                            {
                               
                                bmp.SetPixel(i, j, Color.Red);
                                i += 2;
                            } 
                            else
                                bmp.SetPixel(i, j, Color.White);
                        }
                           
                        /*
                         int count = 0;
                         for (int l = i; l < i + 36; l += 2)
                         {
                             color = bitmap.GetPixel(l, j);
                             if (color.R + color.G + color.B == 0)
                                 count++;
                             else

                                 break;
                         }
                         if(count==18)
                         {
                             bmp.SetPixel(i, j, Color.Red);
                         }
                         else
                         {
                             bmp.SetPixel(i, j, Color.White);
                         }
                    }
                    else
                    {
                        bmp.SetPixel(i, j, Color.Black);
                    }

                }


                    //计算两针差别
                    /*

                             // 计算某种颜色-蓝色
                             bool findSart = false;
                             bool findEnd = false;
                             Point start = new Point(0, 0);
                             Point end = new Point(0, 0);
                             for (int i = 0; i < bitmap.Width - 5; i += 2)
                                 for (int j = 0; j < 100; j += 2)
                                 {
                                     Color color = bitmap.GetPixel(i, j);
                                     if (color.R + 10 < color.G && color.R + 10 < color.B)
                                     {
                                         int count = 0;
                                         for (int l = i; l < i + 5; l += 2)
                                         {
                                             for (int m = j; m < j + 5; m += 2)
                                             {
                                                 color = bitmap.GetPixel(l, m);
                                                 if (color.R + 10 < color.G && color.R + 10 < color.B)
                                                 {
                                                     count++;
                                                 }
                                                 else
                                                     break;
                                             }
                                         }
                                         if (count == 9)
                                         {
                                             if (!findSart)
                                             {
                                                 findSart = true;
                                                 start = new Point(i, j);
                                                 j += 20;
                                                 bmp.SetPixel(i, j, Color.Red);
                                             }
                                             if (findSart && !findEnd)
                                             {
                                                 findEnd = true;
                                                 end = new Point(i, j);
                                                 bmp.SetPixel(i, j, Color.Red);
                                             }
                                         }
                                         else
                                         bmp.SetPixel(i, j, Color.White);

                                     }
                                 }
                             Console.WriteLine("start " + start.X + "," + start.Y + " " + "end" + end.X + ", " + end.Y);
                   
                    pictureBox1.Image = bmp;
            imageEngine.SourceBmp = bmp;
            imageEngine.PsBmp = bmp;
            /*
            Bitmap bmp = (Bitmap)pictureBox2.Image.Clone();
        
            int x = imageEngine.MouseStartPoint.X;
            int y = imageEngine.MouseStartPoint.Y;
            int x2 = imageEngine.MouseEndPoint.X;
            int y2= imageEngine.MouseEndPoint.Y;
          //  Bitmap bmp = newBmp.Clone(new Rectangle(Math.Min(x, x2) , Math.Min(y, y2), Math.Abs(x - x2) , Math.Abs(y - y2)), System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            Point point1 = imageEngine.findLongWhiteLine(bmp, 0);
            Point point2 = imageEngine.findLongWhiteLine(bmp, 1);
            Console.WriteLine(point1);
            Console.WriteLine(point2);
            */
        }

       

        private void cameraList_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void pos_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                updatePicture();
            }
            catch
            {
                ;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var pos = pointPos.Text.Split(',');
            int num;
            if(pos.Length==2&&int.TryParse(pos[1],out num))
            {
                imageEngine.MouseEndPoint = new Point(int.Parse(pos[0]), int.Parse(pos[1]));

            Color color = imageEngine.SourceBmp.GetPixel(imageEngine.MouseEndPoint.X>imageEngine.SourceBmp.Width? imageEngine.SourceBmp.Width-1: imageEngine.MouseEndPoint.X,
                imageEngine.MouseEndPoint.Y > imageEngine.SourceBmp.Height ? imageEngine.SourceBmp.Height- 1 : imageEngine.MouseEndPoint.Y);
               
              
                pointColor.Text = "R " + color.R.ToString("x") + " G " + color.G.ToString("x") + " B " + color.B.ToString("x");
                Color2 color2 = imageEngine.FindReletColor2(color,10);
                pointColorName.Text = color2.name+" "+color2.limit;
                int X = Math.Abs(imageEngine.MouseEndPoint.X - 10);
                int Y = Math.Abs(imageEngine.MouseEndPoint.Y - 10);
                Bitmap bmp = imageEngine.SourceBmp.Clone(new Rectangle(X, Y, X + 21 > imageEngine.SourceBmp.Width ? 1 : 21, Y + 21 > imageEngine.SourceBmp.Height ? 1 : 21), PixelFormat.Format24bppRgb);
                pictureBox4.Image = new Bitmap(bmp, bmp.Width * 5, bmp.Height * 5);
                Graphics g = Graphics.FromImage(pictureBox4.Image);
                g.DrawRectangle(new Pen(Color.Blue), 50, 50, 5, 5);//通过画线方法或其它方法 
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            changePos = !changePos;
            var pos = pointPos.Text.Split(',');
            int num;
            if (pos.Length == 2 && int.TryParse(pos[1], out num))
            {
                imageEngine.MouseEndPoint = new Point(int.Parse(pos[0]), int.Parse(pos[1]));

                Color color = imageEngine.SourceBmp.GetPixel(imageEngine.MouseEndPoint.X, imageEngine.MouseEndPoint.Y);


                //pointColor.Text = "R " + color.R.ToString("x") + " G " + color.G.ToString("x") + " B " + color.B.ToString("x");
                Color2 color2 = imageEngine.FindReletColor2(color, 10);
                colorName.Text = color2.name;
                
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void hashButton_Click(object sender, EventArgs e)
        {
            ulong hash1;
            if(hashPosText.Text=="")
                hash1= ulong.Parse(hashBox.Text);
            else
            {
                var data = hashPosText.Text.Split(',');
                Rectangle sourceRect = new Rectangle(int.Parse(data[0]),int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]));
                int startX = Math.Min(sourceRect.X, sourceRect.Width);
                int startY = Math.Min(sourceRect.Y, sourceRect.Height);
                int width = Math.Abs(sourceRect.X - sourceRect.Width);
                int height = Math.Abs(sourceRect.Y - sourceRect.Height);
                sourceRect = new Rectangle(startX, startY, width, height);
                hash1 = ImageHashing.AverageHash(((Bitmap)pictureBox1.Image).Clone(sourceRect, PixelFormat.Format24bppRgb));
           }

            if (hashText.Text != "")
            {
                ulong hash2 = ulong.Parse(hashText.Text);
                hashSimilarly.Text = ImageHashing.Similarity(hash1, hash2).ToString();
            }
            else

                hashText.Text = hash1.ToString();
        }
    }

}
