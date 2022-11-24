using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {

        double x, y;
        string islem;

        public Form1()
        {
            InitializeComponent();
        }

        #region C Butonu
        private void btn_c_Click(object sender, EventArgs e)
        {
            text_box1.Text = "0";
            label1.Text = "";
        }
        #endregion

        #region Rakamlar
        private void btn_1_Click(object sender, EventArgs e)
        {
            if (text_box1.Text == "0")
            {
                text_box1.Text = "1";
            }
            else
            {
                text_box1.Text += "1";
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (text_box1.Text == "0")
            {
                text_box1.Text = "2";
            }
            else
            {
                text_box1.Text += "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (text_box1.Text == "0")
            {
                text_box1.Text = "3";
            }
            else
            {
                text_box1.Text += "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (text_box1.Text == "0")
            {
                text_box1.Text = "4";
            }
            else
            {
                text_box1.Text += "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (text_box1.Text == "0")
            {
                text_box1.Text = "5";
            }
            else
            {
                text_box1.Text += "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (text_box1.Text == "0")
            {
                text_box1.Text = "6";
            }
            else
            {
                text_box1.Text += "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (text_box1.Text == "0")
            {
                text_box1.Text = "7";
            }
            else
            {
                text_box1.Text += "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (text_box1.Text == "0")
            {
                text_box1.Text = "8";
            }
            else
            {
                text_box1.Text += "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (text_box1.Text == "0")
            {
                text_box1.Text = "9";
            }
            else
            {
                text_box1.Text += "9";
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (text_box1.Text == "0")
            {
                text_box1.Text = "0";
            }
            else
            {
                text_box1.Text += "0";
            }
        }
        #endregion

        #region Delete Butonu
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(text_box1.Text) > 0)
            {
                text_box1.Text = text_box1.Text.Remove(text_box1.Text.Length - 1, 1);

                if (text_box1.Text.Length == 0)
                {
                    text_box1.Text = "0";
                }
            }
        }

        #endregion

        #region DortIslem
        private void btn_toplama_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(text_box1.Text);
            islem = "+";
            label1.Text = text_box1.Text + "+";
            text_box1.Text = "0";
        }

        private void btn_cikarma_Click(object sender, EventArgs e)
        {

            x = Convert.ToDouble(text_box1.Text);
            islem = "-";
            label1.Text = text_box1.Text + "-";
            text_box1.Text = "0";

        }

        private void btn_bolme_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(text_box1.Text);
            islem = "/";
            label1.Text = text_box1.Text + "/";
            text_box1.Text = "0";
        }

        private void btn_carpma_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(text_box1.Text);
            islem = "x";
            label1.Text = text_box1.Text + "x";
            text_box1.Text = "0";
        }
        #endregion

        #region Diger Islemler
        private void btn_karesi_Click(object sender, EventArgs e)
        {
            double kare = Convert.ToDouble(text_box1.Text);
            kare = Math.Pow(kare, 2);
            text_box1.Text = Convert.ToString(kare);
        }

        private void btn_karakok_Click(object sender, EventArgs e)
        {
            double karekok = Convert.ToDouble(text_box1.Text);
            karekok = Math.Sqrt(karekok);
            text_box1.Text = Convert.ToString(karekok);
        }

        private void btn_yuzde_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(text_box1.Text);
            islem = "mod";
            label1.Text = text_box1.Text + "(mod)";
            text_box1.Text = "0";
        }

        private void btn_birbolux_Click(object sender, EventArgs e)
        {
            double bolumx = Convert.ToDouble(text_box1.Text);
            bolumx = 1 / (bolumx);
            text_box1.Text = Convert.ToString(bolumx);
        }
        #endregion

        #region Esittir Butonu
        private void btn_esittir_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(text_box1.Text);

            if (islem == "+")
            {
                text_box1.Text = Convert.ToString(x + y);
                label1.Text = "";
            }

            if (islem == "-")
            {
                text_box1.Text = Convert.ToString(x - y);
                label1.Text = "";
            }

            if (islem == "/")
            {
                text_box1.Text = Convert.ToString(x / y);
                label1.Text = "";
            }

            if (islem == "x")
            {
                text_box1.Text = Convert.ToString(x * y);
                label1.Text = "";
            }

            if (islem == "mod")
            {
                text_box1.Text = Convert.ToString(x % y);
                label1.Text = "";
            }


        }

        #endregion






    }
}
