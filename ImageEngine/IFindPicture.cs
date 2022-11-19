using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ImageEng
{
    interface IFindPicture
    {
        Point findPicture(Bitmap sourceBmp, Bitmap dstBmp, Rectangle scope , float matchDegree, string[] filters);

    }
}
