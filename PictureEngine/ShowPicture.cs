using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureEngine
{
    class ShowPicture
    {
        public  Bitmap ToGray(Bitmap bmp)
        {
            LockBitmap lockbmp = new LockBitmap(bmp);
            //锁定Bitmap，通过Pixel访问颜色
            lockbmp.LockBits();

            //获取颜色
          for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j ++)
                {
                    //获取该点的像素的RGB的颜色
                    Color color = lockbmp.GetPixel(i, j);
                    //利用公式计算灰度值
                    int gray = (int)(color.R * 0.2125 + color.G * 0.7154 + color.B * 0.0721);
                    Color newColor = Color.FromArgb(gray, gray, gray);
                    lockbmp.SetPixel(i, j, newColor);
                }
            }
            //从内存解锁Bitmap
            lockbmp.UnlockBits();
            return bmp;
        }




        public Bitmap ToGrayBlank(Bitmap bmp, Point MouseStartPoint, Point MouseEndPoint)
        {
           
            LockBitmap lockbmp = new LockBitmap(bmp);
            //锁定Bitmap，通过Pixel访问颜色
            lockbmp.LockBits();
            for (int i = 0; i < bmp.Width; i++)
            {
               for (int j = 0; j < bmp.Height; j ++)
                {
                    
                    if ((i > Math.Min(MouseStartPoint.X, MouseEndPoint.X) &&
                         i < Math.Max(MouseStartPoint.X, MouseEndPoint.X)) &&
                        (j > Math.Min(MouseStartPoint.Y, MouseEndPoint.Y) &&
                         j < Math.Max(MouseStartPoint.Y, MouseEndPoint.Y))) ;
                    //Console.WriteLine(MouseStartPoint.X.ToString()+":"+MouseStartPoint.Y.ToString() + ":" + MouseEndPoint.X.ToString() + ":" + MouseEndPoint.Y.ToString());
                    else
                    {
                        //获取该点的像素的RGB的颜色
                        Color color = lockbmp.GetPixel(i, j);
                        //利用公式计算灰度值
                        int gray = (int)(color.R * 0.2125 + color.G * 0.7154 + color.B * 0.0721);
                        Color newColor = Color.FromArgb(gray, gray, gray);
                        lockbmp.SetPixel(i, j, newColor);
                    }

                }
            }
            //从内存解锁Bitmap
            lockbmp.UnlockBits();
            return bmp;

        }

        public Bitmap ShowSelectPicture(Bitmap bmp, Point MouseStartPoint, Point MouseEndPoint,int degree)
        {
            try
            {
                int width = degree*Math.Abs(MouseStartPoint.X - MouseEndPoint.X);
                int height =degree*Math.Abs(MouseStartPoint.Y - MouseEndPoint.Y);
                Bitmap bmpOut = new Bitmap(width,height, PixelFormat.Format24bppRgb);

                Graphics g = Graphics.FromImage(bmpOut);
                g.DrawImage(bmp, new Rectangle(0, 0, width, height), new Rectangle(degree*Math.Min(MouseStartPoint.X, MouseEndPoint.X), degree*Math.Min(MouseStartPoint.Y, MouseEndPoint.Y), width, height), GraphicsUnit.Pixel);
                g.Dispose();

                return bmpOut;
            }
            catch
            {
                return null;
            }
        }
       
        public Bitmap SelectPix(Bitmap bmp)
        {
            Console.WriteLine("bmp格式："+bmp.PixelFormat.ToString());
            Bitmap newBmp =(Bitmap) bmp.Clone();
           

            //获取颜色
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    //获取该点的像素的RGB的颜色
                    Color color = newBmp.GetPixel(i, j);
                    if (color.R > 130 && color.G > 130 && color.B > 130)
                    {
                        
                       color=Color.White;
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
        public Bitmap Binaryzation(Bitmap bmp,int threshold)
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


    }
}
