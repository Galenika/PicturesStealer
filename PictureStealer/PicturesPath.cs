using System;


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
