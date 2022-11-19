using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEng
{
    public class ImageEngine : IFindPicture
    {
        Picture picture = new Picture();

        public Point findPicture(Bitmap sourceBmp, Bitmap dstBmp, Rectangle scope, float matchDegree, string[] filters)
        {
            
            Point point = new Point();
            if (string.IsNullOrEmpty(filters[0]))
            {
                point = picture.findPicture(sourceBmp, dstBmp, scope, matchDegree);
            }
            return point;
        }

        public void test()
        {
            Console.WriteLine("start");
        }
    }
}
