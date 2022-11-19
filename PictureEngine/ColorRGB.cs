using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureEngine
{
    public class Color2
    {
        public string name { get; set; }
        public Color color { get; set; }
        public int limit { get; set; }
        public Color2(string name,Color color)
        {
            this.name = name;
            this.color = color;
        }
    }
    public class ColorRGB
    {
        public Dictionary<string,Color2> knownColor { get; set; }
        public ColorRGB()
        {
            StreamReader sr = new StreamReader("ColorName.txt", Encoding.Default);
            string line;
            knownColor = new Dictionary<string, Color2>();
            while((line=sr.ReadLine())!=null)
            {
                string[] str = line.Split('#');
                if(str.Length==2)
                {
                    Color color = Color.FromArgb(255, int.Parse(str[1].Substring(0, 2), NumberStyles.HexNumber), int.Parse(str[1].Substring(2, 2), NumberStyles.HexNumber), int.Parse(str[1].Substring(4, 2), NumberStyles.HexNumber));
                    Color2 color2 = new Color2(str[0],color);
                    if(!knownColor.ContainsKey(color2.name))
                    knownColor.Add(color2.name,color2);
                }
               
            }
        }
        public Point findColorR(Bitmap bmp, Color colorAim)
        {
           
            LockBitmap lockbmp = new LockBitmap(bmp);
            //锁定Bitmap，通过Pixel访问颜色
            lockbmp.LockBits();
            Color color2 = lockbmp.GetPixel(0, 1);
            byte[] src1 = lockbmp.Pixels;
            int i = 0;
            int j = 0;
            int width = lockbmp.Stride;
            bool partR;
            bool partG;
            bool partB;

            for (i = 0; i < bmp.Height - 1; i++)
            {
                for (j = 0; j < width; j += 3)
                {

                    if (src1[i * width + j + 2] > colorAim.R)
                        partR = true;
                    else
                        partR = false;
                    if (src1[i * width + j + 1] < colorAim.G)
                        partG = true;
                    else
                        partG = false;
                    if (src1[i * width + j] < colorAim.B)
                        partB = true;
                    else
                        partB = false;
                    if (partR && partG && partB)
                        break;
                }
           
                if (j <= width - 3)
                    break;
            }
            //从内存解锁Bitmap
            

            Point point = new Point(j / 3, i);
            if (j > width - 3)
                point = new Point(0, 0);
            lockbmp.UnlockBits();
            return point;
        }
        public Point findColorG(Bitmap bmp, Color colorAim)
        {

            LockBitmap lockbmp = new LockBitmap(bmp);
            //锁定Bitmap，通过Pixel访问颜色
            lockbmp.LockBits();
            Color color2 = lockbmp.GetPixel(0, 1);
            byte[] src1 = lockbmp.Pixels;
            int i = 0;
            int j = 0;
            int width = lockbmp.Stride;
            bool partR;
            bool partG;
            bool partB;

            for (i = 0; i < bmp.Height - 1; i++)
            {
                for (j = 0; j < width; j += 3)
                {

                    if (src1[i * width + j + 2] < colorAim.R)
                        partR = true;
                    else
                        partR = false;
                    if (src1[i * width + j + 1] > colorAim.G)
                        partG = true;
                    else
                        partG = false;
                    if (src1[i * width + j] < colorAim.B)
                        partB = true;
                    else
                        partB = false;
                    if (partR && partG && partB)
                        break;
                }

                if (j <= width - 3)
                    break;
            }
            //从内存解锁Bitmap


            Point point = new Point(j / 3, i);
            if (j > width - 3)
                point = new Point(0, 0);
            lockbmp.UnlockBits();
            return point;
        }
        public Point findColorB(Bitmap bmp, Color colorAim)
        {

            LockBitmap lockbmp = new LockBitmap(bmp);
            //锁定Bitmap，通过Pixel访问颜色
            lockbmp.LockBits();
            Color color2 = lockbmp.GetPixel(0, 1);
            byte[] src1 = lockbmp.Pixels;
            int i = 0;
            int j = 0;
            int width = lockbmp.Stride;
            bool partR;
            bool partG;
            bool partB;

            for (i = 0; i < bmp.Height - 1; i++)
            {
                for (j = 0; j < width; j += 3)
                {

                    if (src1[i * width + j + 2]< colorAim.R)
                        partR = true;
                    else
                        partR = false;
                    if (src1[i * width + j + 1] < colorAim.G)
                        partG = true;
                    else
                        partG = false;
                    if (src1[i * width + j] >colorAim.B)
                        partB = true;
                    else
                        partB = false;
                    if (partR && partG && partB)
                        break;
                }

                if (j <= width - 3)
                    break;
            }
            //从内存解锁Bitmap


            Point point = new Point(j / 3, i);
            if (j > width - 3)
                point = new Point(0, 0);
            lockbmp.UnlockBits();
            return point;
        }
        public Point findColorBias(Bitmap bmp, Color colorAim, byte bias)
        {
            LockBitmap lockbmp = new LockBitmap(bmp);
            //锁定Bitmap，通过Pixel访问颜色
            lockbmp.LockBits();
            byte[] src1 = lockbmp.Pixels;
            int i = 0;
            int j = 0;
            int width = lockbmp.Stride;
            bool partR;
            bool partG;
            bool partB;
            for (i = 0; i < bmp.Height - 1; i++)
            {
                for (j = 0; j < width; j += 3)
                {
                    partR = compareColorBias(src1[i * width + j + 2], colorAim.R, bias);
                    partG = compareColorBias(src1[i * width + j + 1], colorAim.G, bias);
                    partB = compareColorBias(src1[i * width + j], colorAim.B, bias);
                    if (partR && partG && partB)
                        break;     
                }
                if (j <= width - 3)
                    break;
            }
            //从内存解锁Bitmap
            Point point = new Point(j / 3, i);
            if (j > width - 3)
                point = new Point(0, 0);
            lockbmp.UnlockBits();
            return point;
        }

        private bool compareColorBias(byte dstColor, byte sourceColor, byte bias)
        {
            int min = 0;
            int max = 255;
            if (sourceColor - bias > 0)
                min = sourceColor - bias;
            if (sourceColor + bias < 255)
                max = sourceColor + bias;
            if (dstColor >= min && dstColor <= max)
                return true;
            return false;
        }

        public Point[] findTwoLongWhiteLine(Bitmap bmp)
        {
           
            
            LockBitmap lockbmp = new LockBitmap(bmp);
            //锁定Bitmap，通过Pixel访问颜色
            lockbmp.LockBits();
            byte[] src1 = lockbmp.Pixels;
            int i = 0;
            int j = 0;
            int width = lockbmp.Stride;
            bool partR;
            bool partG;
            bool partB;
            Point[] point = new Point[2];
            int count = 0;
            for (i = 0; i < bmp.Height - 1; i++)
            {
                if (count > 1)
                    break;
                for (j = 0; j < width; j += 3)
                {
                   
                    partR = compareTwoValue(src1[i * width + j + 2], 160);
                    partG = compareTwoValue(src1[i * width + j + 1],180);
                    partB = compareTwoValue(src1[i * width + j], 200);
                    if ((partR && partG && partB) != true)
                        break;
                    if(j>200)
                    {
                        point[count].X = j / 3;
                        point[count].Y = i;
                        count++;
                        break;
                    }

                }
                
            }
            lockbmp.UnlockBits();
            return point;
        }
        private bool compareTwoValue(int value1,int valu2)
        {
            if (value1 > valu2)
                return true;
            return false;
        }

        public Color2 FindReletColor2(Color color,int limit=0)
        {
            int min = 255;
            Color2 minColor = new Color2("null", Color.Black);
        
            foreach(Color2 color2 in knownColor.Values)
            {
                int result = ComputeLimit(color2, color);
                if (result<min)
                {
                    min = result;
                    minColor = color2;
                }
                  
                if (min < limit&&limit!=0)
                  return color2;
            }
            minColor.limit =min;
            return minColor;

        }
        private int ComputeLimit(Color2 color2,Color color)
        {
            return Math.Abs(color2.color.R - color.R) + Math.Abs(color2.color.G - color.G) + Math.Abs(color2.color.B- color.B);
        }

        public bool HaveKnownColor2(Bitmap bmp,Color2 color2,int limit=0)
        {
           
            for(int i=0;i<bmp.Width;i++)
                for(int j=0;j<bmp.Height;j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    if (ComputeLimit(color2, color) <= limit)
                        return true;
                }
            return false;
        }

        public Point KnownColor2Pos(Bitmap bmp, Color2 color2, int limit = 0)
        {
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    if (ComputeLimit(color2, color) <= limit)
                        return new Point(i,j);
                }
            return new Point(-1, -1);
        }

        public bool IsThisColor2(Color color, Color2 color2, int limit = 0)
        {
            if (ComputeLimit(color2, color) < limit)
                return true;
            return false;
        }
    }

}
