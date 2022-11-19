using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureEngine
{
    interface IFindText
    {
        string findText(Bitmap bmp);
        string findTextC(Bitmap bmp);
    }
}
