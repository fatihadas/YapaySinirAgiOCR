using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YSA_OCR
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        int[] karakter=new int[35];

        PictureBox[] pictureboxdizi;
        int pictureboxsayim = -1;

        YSA ysa;

        private void Form1_Load(object sender, EventArgs e)
        {
            CizimYap(1);
        }

        private void CizimYap(int state)
        {
            pictureboxdizi = null;
            pictureboxsayim = -1;

            pictureboxdizi = new PictureBox[35];
            int temp = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    pictureboxsayim++;
                    pictureboxdizi[pictureboxsayim] = new PictureBox();
                    pictureboxdizi[pictureboxsayim].Name = pictureboxsayim.ToString();
                    if(state==1)
                        pictureboxdizi[pictureboxsayim].Location = new System.Drawing.Point(31 * j, temp);
                    else
                        pictureboxdizi[pictureboxsayim].Location = new System.Drawing.Point(30 * j, temp);
                    pictureboxdizi[pictureboxsayim].Size = new System.Drawing.Size(30, 30);
                    //pictureboxdizi[pictureboxsayim].BorderStyle = BorderStyle.FixedSingle;
                    if (state == 1)
                        pictureboxdizi[pictureboxsayim].BorderStyle = BorderStyle.FixedSingle;
                    else
                        pictureboxdizi[pictureboxsayim].BorderStyle = BorderStyle.None;
                    karakter[pictureboxsayim] = 0;
                    pictureboxdizi[pictureboxsayim].MouseClick += new MouseEventHandler(picture_Click);
                    panel_giriş.Controls.Add(pictureboxdizi[pictureboxsayim]);
                }
                if (state == 1)
                    temp += 31;
                else
                    temp += 30;
                //temp += 31;
            }
        }

        private void picture_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            int temp = Convert.ToInt32(pb.Name);

            if(karakter[temp]==0)
            {
                pb.BackColor = Color.Black;
                karakter[temp] = 1;
            }
            else
            {
                pb.BackColor = Color.LightSteelBlue;
                karakter[temp] = 0;
            }
        }

        private void button_sıfırla_Click(object sender, EventArgs e)
        {
            foreach (PictureBox p in panel_giriş.Controls)
                p.BackColor = Color.LightSteelBlue;
            
            for (int i = 0; i < karakter.Length; i++)
            {
                karakter[i] = 0;
                karakter2[i] = 0;
            }
            checkBox_cizgi.Checked = false;
        }

        int[] karakter2 = new int[35];
        private void checkBox_cizgi_CheckedChanged(object sender, EventArgs e)
        {
            panel_giriş.Controls.Clear();

            karakter2 = new int[35];
            for (int f = 0; f < 35;f++ )
                karakter2[f] = karakter[f];

            if(checkBox_cizgi.Checked==true)
            {
                panel_giriş.Width = 152;
                panel_giriş.Height = 211;
                CizimYap(0);
                ÇizimKoru();
            }
            else
            {
                panel_giriş.Width = 156;
                panel_giriş.Height = 218;
                CizimYap(1);
                ÇizimKoru();
            }
        }

        private void ÇizimKoru()
        {
            for (int i = 0; i < 35; i++)
            {
                if(karakter2[i] == 1)
                    panel_giriş.Controls[i.ToString()].BackColor = Color.Black;
                karakter[i] = karakter2[i];
            }
        }

        private void button_eğit_Click(object sender, EventArgs e)
        {
            if(checkBox_epoch.Checked==true)
            {
                ysa.sonlanmakriteri = "epoch";
                label5.Text = Convert.ToInt32(numericUpDown_epoch.Value).ToString();
            }

            ysa.netveçıkışhesapla(Convert.ToInt32(numericUpDown_epoch.Value), Convert.ToDouble(numericUpDown_goal.Value),
                label_hataoranı);

            label6.Text = Convert.ToDouble(numericUpDown_goal.Value).ToString();

        }
        
        private void button_tahminet_Click(object sender, EventArgs e)
        {
            ysa.TestEt(karakter, label_çıkışA, label_çıkışB, label_çıkışC, label_çıkışD, label_çıkışE);
        }

        int tempClick;
        private void button_harfseç_Click(object sender, EventArgs e)
        {
            if (checkBox_otoyükle.Checked == true)
            {
                ysa.AutoCharacterLoad();
                groupBox_tanımlama.Enabled = false;
            }
            else
            {
                checkBox_otoyükle.Enabled = false;
                string harf = comboBox_harf.SelectedItem.ToString();
                //MessageBox.Show(harf);
                int h;
                switch (harf)
                {
                    case "A": h = 0; break;
                    case "B": h = 1; break;
                    case "C": h = 2; break;
                    case "D": h = 3; break;
                    case "E": h = 4; break;
                    default: h = 5; break;
                }
                MessageBox.Show("Karakter: "+harf + " -  Sütun: " + h.ToString(),"Tanımlandı");

                for (int i = 0; i < karakter.Length; i++)
                {
                    ysa.abcde[i, h] = karakter[i];
                }
                comboBox_harf.Items.Remove(comboBox_harf.SelectedItem);
                button_sıfırla.PerformClick();
                tempClick++;
                if (tempClick == 5)
                    groupBox_tanımlama.Enabled = false;
            }
            
        }

        private void checkBox_epoch_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_epoch.Checked == true)
            {
                numericUpDown_epoch.Enabled = true;
            }
            else
            {
                numericUpDown_epoch.Enabled = false;
            }
        }

        private void checkBox_otoyükle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_otoyükle.Checked == true)
                comboBox_harf.Enabled = false;
            else
                comboBox_harf.Enabled = true;
        }

        private void linkLabel_restart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Thread.Sleep(350);
            Application.Restart();
        }

        private void button_ağoluştur_Click(object sender, EventArgs e)
        {
            int nöronsayı = Convert.ToInt32(numericUpDown_nöronsayısı.Value);
            ysa = new YSA(karakter, nöronsayı, 5);

            double lamda = Convert.ToDouble(numericUpDown_lamda.Value);
            ysa.lamda = lamda;

            double alfa = Convert.ToDouble(numericUpDown_alfa.Value);
            ysa.alfa = alfa;

            groupBox_baslangıc.Enabled = false;
        }
    }
}
