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
    public partial class Hit : Form
    {

        private Bitmap f_image;
        private Bitmap f_image2;


        public Hit(Bitmap a, Bitmap s)
        {
            f_image = a;
            f_image2 = s;
            InitializeComponent();
        }



        private void Hit_Load(object sender, EventArgs e)
        {        
            Original();
            RGB();
            GImage();
        }
        public void Original()
        {
            int[] arrCo = new int[255];
            int[] arrNco = new int[255];

            for (int i = 0; i < f_image2.Width; i++)
            {
                for (int j = 0; j < f_image2.Height; j++)
                {

                    Color PixelColor = f_image2.GetPixel(i, j);
                    int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                    if (C_gray >= 254)
                        C_gray = 254;
                    arrCo[C_gray] += 1;

                }
            }
            for (int i = 0; i < arrCo.Length; i++)
            {
                this.chartOriginal.Series["Original"].Points.AddXY(i, arrCo[i]);
            }

        }
        public void GImage()
        {
            int[] arrCo = new int[255];
            int[] arrNco = new int[255];

            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    Color PixelColor = f_image.GetPixel(i, j);
                    int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                    if (C_gray >= 254)
                        C_gray = 254;
                    arrCo[C_gray] += 1;

                }
            }
            for (int i = 0; i < arrCo.Length; i++)
            {
                this.chartGImage.Series["GImage"].Points.AddXY(i, arrCo[i]);
            }

        }
        public void RGB()
        {
            int[] color = new int[f_image.Width * f_image.Height];
            int color1 = 0;
            int color2 = 0;
            int color3 = 0;
            int color4 = 0;
            int color5 = 0;
            int color6 = 0;
            int y = 0;
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    Color PixelColor = f_image.GetPixel(i, j);
                    int r = (int)(PixelColor.R);
                    int g = (int)(PixelColor.G);
                    int b = (int)(PixelColor.B);

                    if (r == 255 && g == 102 && b == 102)
                        color1++;
                    if (r == 255 && g == 255 && b == 102)
                        color2++;
                    if (r == 102 && g == 255 && b == 102)
                        color3++;
                    if (r == 102 && g == 255 && b == 255)
                        color4++;
                    if (r == 102 && g == 102 && b == 255)
                        color5++;
                    if (r == 255 && g == 102 && b == 255)
                        color6++;




                }
            }

            this.chartColor2.Series["(255,102,102)"].Points.AddXY(y, color1);
            this.chartColor2.Series["(255,255,102)"].Points.AddXY(y, color2);
            this.chartColor2.Series["(102,255,102)"].Points.AddXY(y, color3);
            this.chartColor2.Series["(102,255,255)"].Points.AddXY(y, color4);
            this.chartColor2.Series["(102,102,255)"].Points.AddXY(y, color5);
            this.chartColor2.Series["(255,102,255)"].Points.AddXY(y, color6);

        }
    }
}
