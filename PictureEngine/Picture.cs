using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging;

namespace PictureEngine
{
    class Picture
    {

        //大于10s
        public Point findPictureByTemplate(Bitmap sourceBmp, Bitmap dstBmp, Rectangle scope, float matchDegree)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            Point point = new Point();
            ExhaustiveTemplateMatching templateMatching = new ExhaustiveTemplateMatching(matchDegree);
            TemplateMatch[] compare;
           
            if (!scope.IsEmpty)
                compare = templateMatching.ProcessImage(sourceBmp, dstBmp, scope);
            else
            {
                compare = templateMatching.ProcessImage(sourceBmp, dstBmp);
            }
            if (compare.Length > 0)
            {
                point.X = compare[0].Rectangle.X;
                point.Y = compare[0].Rectangle.Y;
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed.TotalSeconds + " " +compare.Length);
            return point;
        }

        /// <summary>
        /// 在大图里找小图
        /// </summary>
        /// <returns></returns>
        public List<Point> findPicture(Bitmap sourceBmp, Bitmap targetBmp, Rectangle sourceRect, float similar)
        {

            Bitmap bmp;
            if (sourceRect.IsEmpty)
            {
                sourceRect = new Rectangle(0, 0, sourceBmp.Width, sourceBmp.Height);
                bmp = sourceBmp;
            }
            else
            {
                int startX= Math.Min(sourceRect.X, sourceRect.Width);
                int startY = Math.Min(sourceRect.Y, sourceRect.Height);
                int width = Math.Abs(sourceRect.X - sourceRect.Width);
                int height = Math.Abs(sourceRect.Y - sourceRect.Height);
                sourceRect = new Rectangle(startX, startY, width, height);
                bmp = sourceBmp.Clone(sourceRect, PixelFormat.Format24bppRgb);
              
                sourceRect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            }
               
            
           
            BitmapData sData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData pData = targetBmp.LockBits(new Rectangle(0, 0, targetBmp.Width, targetBmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            List<Point> list;
            if (similar < 1)
            {
                //相似找图
                list = _FindPic(sData, pData, sourceRect, 255 - (int)(255 * similar));
            }
            else
            {
                //全匹配找图效率最高
                list = _FindPic(sData, pData, sourceRect);
            }

            bmp.UnlockBits(sData);
            targetBmp.UnlockBits(pData);

            return list;
        }

        /// <summary>
        /// 全匹配找图
        /// </summary>
        private static unsafe List<Point> _FindPic(BitmapData sourceData, BitmapData targetData, Rectangle sourceRect)
        {
            List<Point> list = new List<Point>();

            int sStride = sourceData.Stride;
            int pStride = targetData.Stride;
            IntPtr sIptr = sourceData.Scan0;
            IntPtr pIptr = targetData.Scan0;

            bool isOk = false;
            int breakW = sourceRect.Width - targetData.Width + 1;
            int breakH = sourceRect.Height - targetData.Height + 1;

            for (int h = sourceRect.Top; h < breakH; h++)
            {
                for (int w = sourceRect.Left; w < breakW; w++)
                {
                    for (int y = 0; y < targetData.Height; y++)
                    {
                        for (int x = 0; x < targetData.Width; x++)
                        {
                            var sPtr = (byte*)((int)sIptr + sStride * (h + y) + (w + x) * 3);
                            var pPtr = (byte*)((int)pIptr + pStride * y + x * 3);

                            if (sPtr[0] == pPtr[0] && sPtr[1] == pPtr[1] && sPtr[2] == pPtr[2])
                            {
                                isOk = true;
                            }
                            else
                            {
                                isOk = false;
                                break;
                            }
                        }
                        if (isOk == false) { break; }
                    }

                    if (isOk) { list.Add(new Point(w, h)); }

                    isOk = false;
                }
            }

            return list;
        }

        /// <summary>
        /// 相似找图
        /// </summary>
        private static unsafe List<Point> _FindPic(BitmapData sourceData, BitmapData targetData, Rectangle sourceRect, int similar)
        {
            List<Point> list = new List<Point>();
            int sStride = sourceData.Stride;
            int pStride = targetData.Stride;
            IntPtr sIptr = sourceData.Scan0;
            IntPtr pIptr = targetData.Scan0;
            bool isOk = false;
            int breakW = sourceRect.Width - targetData.Width + 1;
            int breakH = sourceRect.Height - targetData.Height + 1;

            for (int h = sourceRect.Top; h < breakH; h++)
            {
                for (int w = sourceRect.Left; w < breakW; w++)
                {
                    for (int y = 0; y < targetData.Height; y++)
                    {
                        for (int x = 0; x < targetData.Width; x++)
                        {
                            var sPtr = (byte*)((int)sIptr + sStride * (h + y) + (w + x) * 3);
                            var pPtr = (byte*)((int)pIptr + pStride * y + x * 3);

                            if (ScanColor(sPtr[0], sPtr[1], sPtr[2], pPtr[0], pPtr[1], pPtr[2], similar))  //比较颜色
                            {
                                isOk = true;
                            }
                            else
                            {
                                isOk = false; break;
                            }
                        }
                        if (isOk == false) { break; }
                    }

                    if (isOk) { list.Add(new Point(w, h)); }
                    isOk = false;
                }
            }

            return list;
        }
        //找图BGR比较
        private static unsafe bool ScanColor(byte b1, byte g1, byte r1, byte b2, byte g2, byte r2, int similar)
        {
            if ((Math.Abs(b1 - b2)) > similar) { return false; } //B
            if ((Math.Abs(g1 - g2)) > similar) { return false; } //G
            if ((Math.Abs(r1 - r2)) > similar) { return false; } //R
            return true;
        }
    }
}
