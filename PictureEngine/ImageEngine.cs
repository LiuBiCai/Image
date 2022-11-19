using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace PictureEngine
{
    public class ImageEngine : IFindPicture,IShowPicture,IFindText
    {
        Picture picture = new Picture();
        ShowPicture showPicture=new ShowPicture();
        private Bitmap sourceBmp;
        private Bitmap dstBmp;
        private Bitmap psBmp;
        public Point MouseStartPoint { get; set; }
        public Point MouseEndPoint { get; set; }
        public Bitmap SourceBmp
        {
            get
            { return sourceBmp; }
            set
            {
                if (value.PixelFormat != PixelFormat.Format24bppRgb)
                {
                    Console.WriteLine("Format {0}",value.PixelFormat.ToString());
                    sourceBmp = BitTo24(value);
                }
                else
                {
                    sourceBmp =(Bitmap)value.Clone();
                }

            }
        }
        public Bitmap DstBmp
        {
            get { return dstBmp; }
            set
            {
                if (value.PixelFormat != PixelFormat.Format24bppRgb)
                {
                    Console.WriteLine("Format {0}", value.PixelFormat.ToString());
                    dstBmp = BitTo24(value);
                }
                else
                {
                    dstBmp = (Bitmap)value.Clone();
                }
            }
        }
        public Bitmap PsBmp
        {
            get { return psBmp; }
            set
            {
                if (value.PixelFormat != PixelFormat.Format24bppRgb)
                {
                    Console.WriteLine("Format {0}", value.PixelFormat.ToString());
                    psBmp = BitTo24(value);
                }
                else
                {
                    psBmp = (Bitmap)value.Clone();
                }
            }
        }
        public ColorRGB colorRGB;
        public ImageEngine()
        {
            colorRGB = new ColorRGB();
        }

        public List<Point> findPicture(Bitmap sourceBmp,Bitmap dstBmp,Rectangle scope, float matchDegree)
        {
            
            string[] filters = new string[0];
            List<Point> points = new List<Point>();
            if (filters.Length == 0)
            {
                points = picture.findPicture(sourceBmp, dstBmp, scope, matchDegree);
            }
            return points;
        }
        public List<Point> findPicture(Bitmap sourceBmp, Bitmap dstBmp,float matchDegree)
        {
            string[] filters = new string[0];
            List<Point> points = new List<Point>();
            if (filters.Length == 0)
            {
                points = picture.findPicture(sourceBmp, dstBmp, new Rectangle(), matchDegree);
            }
            return points;
        }
        public List<Point> findPicture(Rectangle scope, float matchDegree)
        {
            string[] filters = new string[0];
            List<Point> points = new List<Point>();
            if(filters.Length==0)
            { 
                points = picture.findPicture(sourceBmp, dstBmp, scope, matchDegree);
            }
            return points;
        }
        public List<Point> findPicture(Rectangle scope, float matchDegree, string[] filters)
        {
           
            List<Point> points = new List<Point>();
            if (filters.Length == 0)
            {
                points = picture.findPicture(sourceBmp, dstBmp, scope, matchDegree);
            }
            return points;
        }

        public Point findColorR( Bitmap bmp,Color colorAim)
        {
           
            Point point = new Point();
            point = colorRGB.findColorR(bmp, colorAim);
            return point;
        }
        public Point findColorG(Bitmap bmp, Color colorAim)
        {
         
            Point point = new Point();
            point = colorRGB.findColorG(bmp, colorAim);
            return point;
        }
        public Point findColorB(Bitmap bmp, Color colorAim)
        {
          
            Point point = new Point();
            point = colorRGB.findColorB(bmp, colorAim);
            return point;
        }
        public Point findColorBias(Bitmap bmp, Color colorAim, byte bias)
        {
           
            Point point = new Point();
            point = colorRGB.findColorBias(bmp, colorAim,bias);
            return point;
        }
       

        public Bitmap ToGray(Bitmap bmp)
        {
            Bitmap newBmp = showPicture.ToGray(bmp);
            return newBmp;
        }

        public Bitmap ToGrayBlank(Bitmap bmp)
        {
            Bitmap newBmp = showPicture.ToGrayBlank(bmp,MouseStartPoint,MouseEndPoint);
            return newBmp;
        }


        public Bitmap ShowSelectPicture(Bitmap bmp,int degree)
        {
            Bitmap newBmp = showPicture.ShowSelectPicture(bmp, MouseStartPoint, MouseEndPoint,degree);
            return newBmp;
        }


    

        public Bitmap SelectPix(Bitmap bmp)
        {
            Bitmap newBmp = showPicture.SelectPix(bmp);
            return newBmp;
        }

        public Bitmap Binaryzation(Bitmap bmp,int threshold)
        {
            Bitmap newBmp = showPicture.Binaryzation(bmp,threshold);
            return newBmp;
        }

        private static Bitmap BitTo24(Bitmap source)
        {
            Bitmap bmp = source;
            Rectangle rectangle = new Rectangle(0, 0, bmp.Width, bmp.Height);
            Bitmap bmp24 = bmp.Clone(rectangle, PixelFormat.Format24bppRgb);
            return bmp24;
        }

        public string findText(Bitmap bmp)
        {
            TesseractEngine _tesseractEngine = null;


            Tesseract.TesseractEnviornment.CustomSearchPath = "tesseract";
            _tesseractEngine = new TesseractEngine(@"tesseract/tessdata", "eng", EngineMode.Default);


            string code = string.Empty;
            using (var page = _tesseractEngine.Process(bmp))
            {
                code = page.GetText().ToString().Replace("\n", string.Empty);
                
            }
            return code;
        }
        public Point findLongWhiteLine(Bitmap bmp,int index)
        {
            Point point = new Point(0, 0);           
            Point[] points = colorRGB.findTwoLongWhiteLine(bmp);
            if (points.Length <= index)
                return point;
            else
                return points[index];

        }
        public Color2 FindReletColor2(Color color, int limit = 0)
        {
            return colorRGB.FindReletColor2(color, limit);
        }
        public bool HaveKnownColor2(Bitmap bmp, Color2 color2, int limit = 0)
        {
            return colorRGB.HaveKnownColor2(bmp, color2, limit);
        }
        public bool HaveKnownColor2(Bitmap bmp, string name, int limit = 0)
        {
            
            return colorRGB.HaveKnownColor2(bmp, colorRGB.knownColor[name], limit);
        }

        public Point KnownColor2Pos(Bitmap bmp, Color2 color2, int limit = 0)
        {
            return colorRGB.KnownColor2Pos(bmp, color2, limit);
        }
        public Point KnownColor2Pos(Bitmap bmp, string name, int limit = 0)
        {
            return colorRGB.KnownColor2Pos(bmp, colorRGB.knownColor[name], limit);
        }

        public bool IsThisColor2(Color color,string name,int limit=0)
        {
            return colorRGB.IsThisColor2(color, colorRGB.knownColor[name], limit);
        }

        public string findTextC(Bitmap bmp)
        {
            TesseractEngine _tesseractEngine = null;


            Tesseract.TesseractEnviornment.CustomSearchPath = "tesseract";
            _tesseractEngine = new TesseractEngine(@"tesseract/tessdata", "ch", EngineMode.Default);


            string code = string.Empty;
            using (var page = _tesseractEngine.Process(bmp))
            {
                code = page.GetText().ToString().Replace("\n", string.Empty);

            }
            return code;
        }
    }
}
