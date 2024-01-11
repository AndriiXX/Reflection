using System;
using System.Drawing;
using System.Windows.Forms;

namespace Reflection1
{
    public partial class Form1 : Form
    {
        private PictureBox pictureBox = new PictureBox();

        public Form1()
        {
            InitializeComponent();
            CreatePictureBox();
        }

        private void CreatePictureBox()
        {     
            pictureBox = new PictureBox();
            
            pictureBox.Size = new Size(400, 300);

            Image image1 = Image.FromFile(@"C:\Users\admin\Desktop\Untitled4_20230527162858.png");

            pictureBox.Size = new Size(image1.Width, image1.Height);

            pictureBox.Image = image1;

            this.Controls.Add(pictureBox);
        }

    }
}