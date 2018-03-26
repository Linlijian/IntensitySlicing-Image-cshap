using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntensitySlicing
{
    public partial class Form1 : Form
    {
        private Bitmap f_image = null;  //input image
        public Bitmap image;
        public Bitmap color;
        public Bitmap color1;
     
        int[] rr;
        int[] gg;
        int[] bb;
        int size;
        public Form1()
        {
            InitializeComponent();
        }

        private void Histogram_Click(object sender, EventArgs e)
        {
            Hit hitoutput = new Hit(image,f_image);
            hitoutput.Show();
        }
        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileImage = new OpenFileDialog();
            OpenFileImage.Filter = "bitmap (*.bmp)|*.bmp";
            OpenFileImage.FilterIndex = 1;
            if (OpenFileImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (f_image != null)
                        f_image.Dispose();
                    f_image = (Bitmap)Bitmap.FromFile(OpenFileImage.FileName, false);

                }
                catch (Exception)
                {
                    MessageBox.Show("Can not open file”, “File Error");
                }
            }
            image = new Bitmap(f_image.Width, f_image.Height);



            Picinput.Image = f_image;
            //Hit hittogram = new Hit(f_image);
            //hittogram.Show();
        }
        private void IntensitySlicing_Click(object sender, EventArgs e)
        {
            int min = getMin(f_image); // 25
            int max = getMax(f_image); // 200
            int c1 = getColor(max, min); // 113
            int c2 = getColor(c1, min); // 69
            int c3 = getColor(c1, max); // 157
            int c4 = getColor(c3, max); // 179
            int c5 = getColor(c4, max); // 190
            size = f_image.Width * f_image.Height;
            
            // 0--69--113--157--179--190--255
            //c1 = 0--69 = rgb(255, 102, 102)
            //c2 = 69--113 = rgb(255, 255, 102)
            //c3 = 113--157 = rgb(102, 255, 102)
            //c4 = 157--179 = rgb(102, 255, 255)
            //c5 = 179--190 = rgb(102, 102, 255)
            //c6 = 190--255 = rgb(255, 102, 255)
            DisplayColor(255, 102, 102, c2, 1);
            DisplayColor(255, 255, 102, c1, 2);
            DisplayColor(102, 255, 102, c3, 3);
            DisplayColor(102, 255, 255, c4, 4);
            DisplayColor(102, 102, 255, c5, 5);
            DisplayColor(255, 102, 255, 255, 6);
            int y = 0;
            int[] r = new int[f_image.Width * f_image.Height];
            int[] g = new int[f_image.Width * f_image.Height];
            int[] b = new int[f_image.Width * f_image.Height];

            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    Color PixelColor = f_image.GetPixel(i, j);
                    int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                    if(C_gray >= c5 && C_gray < 255)
                    {
                        r[y] = 255;
                        g[y] = 102;
                        b[y] = 255;
                    }
                    else if(C_gray >= c4 && C_gray < c5)
                    {
                        r[y] = 102;
                        g[y] = 102;
                        b[y] = 255;
                    }
                    else if (C_gray >= c3 && C_gray < c4)
                    {
                        r[y] = 102;
                        g[y] = 255;
                        b[y] = 255;
                    }
                    else if (C_gray >= c2 && C_gray < c3)
                    {
                        r[y] = 102;
                        g[y] = 255;
                        b[y] = 102;
                    }
                    else if (C_gray >= c1 && C_gray < c2)
                    {
                        r[y] = 255;
                        g[y] = 255;
                        b[y] = 102;
                    }
                    else
                    {
                        r[y] = 255;
                        g[y] = 102;
                        b[y] = 102;
                    }
                    y++;
                }
            }

            y = 0;
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    image.SetPixel(i, j, Color.FromArgb(r[y], g[y], b[y]));
                    y++;
                }
            }
            Picoutput.Image = image;
            rr = r;
            gg = g;
            bb = b;
        }
        public void DisplayColor(int r,int g,int b,int gr,int no)
        {
            color = new Bitmap(f_image.Width, f_image.Height);
            color1 = new Bitmap(f_image.Width, f_image.Height);
            for (int i = 0; i < 114; i++)
            {
                for (int j = 0; j < 41; j++)
                {
                    color.SetPixel(i, j, Color.FromArgb(r,g,b));                    
                }
            }
            
            for (int i = 0; i < 114; i++)
            {
                for (int j = 0; j < 41; j++)
                {
                    color1.SetPixel(i, j, Color.FromArgb(gr, gr, gr));
                }
            }
            if(no == 1)
            {
                picColor1.Image = color;
                PicGray1.Image = color1;
            }
            else if (no == 2)
            {
                picColor2.Image = color;
                PicGray2.Image = color1;
            }
            else
                if (no == 3)
            {
                picColor3.Image = color;
                PicGray3.Image = color1;
            }
            else
                if (no == 4)
            {
                picColor4.Image = color;
                PicGray4.Image = color1;
            } else
                if (no == 5)
            {
                picColor5.Image = color;
                PicGray5.Image = color1;
            }
            else
            {
                picColor6.Image = color;
                PicGray6.Image = color1;
            }
        }
        public int getMin(Bitmap a)
        {
            
            int y = 0;
            int min = 999;
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    Color PixelColor = f_image.GetPixel(i, j);
                    int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                    if (C_gray < min)
                        min = C_gray;
                }
            }
            return min;

        }
        public int getMax(Bitmap a)
        {

            int y = 0;
            int max = 0;
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    Color PixelColor = f_image.GetPixel(i, j);
                    int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                    if (C_gray > max)
                        max = C_gray;
                }
            }
            return max;

        }
        public int getColor(int max, int min)
        {
            return (max + min) / 2;
        }
        
    }
}
