using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PictureStealer
{
    public class PicturesPath
    {
        String imagesPath;
      public String GetPicturesPath()
        {
            imagesPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures).ToString();
            return imagesPath;

        }
    }

}
