﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EnglishDirectory
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }

        void LoadNextImage()
        {
            Random rand = new Random();
            string[] files = Directory.GetFiles(@"image\", "*.jpg");
            slidePic.ImageLocation = files[rand.Next(files.Length)];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void btnFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/TruongDaiHocMo/");
        }

        private void btnIG_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/ou.edu.vn/");
        }

        private void btnYTB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCW60en-uPCwkTfG4SNGLcFA");
        }

    }
}
