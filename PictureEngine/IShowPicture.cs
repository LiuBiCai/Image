using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureEngine
{
    interface IShowPicture
    {
        Bitmap PsBmp { get; set; }
        Bitmap SourceBmp { get; set; }
        Point MouseStartPoint { get; set; }
        Point MouseEndPoint { get; set; }
        Bitmap ToGray(Bitmap bmp);
        Bitmap ToGrayBlank(Bitmap bmp);
        Bitmap ShowSelectPicture(Bitmap bmp,int degree);
       Bitmap SelectPix(Bitmap bmp);
    }
}
