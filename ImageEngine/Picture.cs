using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging;

namespace ImageEng
{
    class Picture
    {
        public Point findPicture(Bitmap sourceBmp, Bitmap dstBmp, Rectangle scope, float matchDegree)
        {
            Point point=new Point();
            ExhaustiveTemplateMatching templateMatching = new ExhaustiveTemplateMatching(matchDegree);
            TemplateMatch[] compare;
            if (!scope.IsEmpty)
                compare = templateMatching.ProcessImage(sourceBmp, dstBmp, scope);
            else
            {
                compare = templateMatching.ProcessImage(sourceBmp, dstBmp);
            }
            point.X=compare[0].Rectangle.X;
            point.Y = compare[0].Rectangle.Y;
            return point;
        }
    }
}
