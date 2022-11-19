using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace PictureEngine
{
    interface IFindPicture
    {
        Bitmap SourceBmp { get; set; }
        Bitmap DstBmp { get; set; }
        List<Point> findPicture(Rectangle scope , float matchDegree, string[] filters);

    }
}
