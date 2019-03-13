using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YSA_OCR
{
    class YSA
    {
        int[] girişdizisi = new int[35];
        double[,] çıkışdizisi = new double[5,5];
        int gizlikatmannöronsayısı;
        int çıkışnöronsayısı;

        double[,] girişağırlıkları;
        double[] gizlikatmantoplamnet;
        double[] gizlikatmançıkışdeğerleri;
        double[,] gizlikatmanağırlıkları;
        double[] gizlikatmanbiasağırlıkları;
        double[] çıkışbiasağırlıkları;
        double[] çıkıştoplamnet;
        double[] çıkışdeğerleri;

        public double ortabias = 1, çıkışbias = 1, lamda = 0.5, alfa = 0.8;
        public int[,] abcde=new int[35,5];
        public double[] Em;
        double çıkıştoplamhata = 0;

        double[] Sçıkış;
        double[,] deltaarakatman;
        double[,] deltaarakatmanönceki;

        double[] deltaçıkışkatmanbias;
        double[] deltaçıkışkatmanbiasönceki;

        double[] Sgizli;
        double[,] deltailkkatman;
        double[,] deltailkkatmanönceki;
        double[] deltaarakatmanbias;
        double[] deltaarakatmanbiasönceki;

        public string sonlanmakriteri;
        public YSA(int[] girişdizisi, int gizlikatmannöronsayısı, int çıkışnöronsayısı)
        {
            this.girişdizisi = girişdizisi;
            this.gizlikatmannöronsayısı = gizlikatmannöronsayısı;
            this.çıkışnöronsayısı = çıkışnöronsayısı;

            girişağırlıkları = new double[girişdizisi.Length, gizlikatmannöronsayısı];

            gizlikatmantoplamnet = new double[gizlikatmannöronsayısı];
            gizlikatmançıkışdeğerleri = new double[gizlikatmannöronsayısı];
            gizlikatmanağırlıkları = new double[gizlikatmannöronsayısı,çıkışnöronsayısı];
            gizlikatmanbiasağırlıkları = new double[gizlikatmannöronsayısı];

            çıkışbiasağırlıkları = new double[çıkışnöronsayısı];
            çıkıştoplamnet = new double[çıkışnöronsayısı];
            çıkışdeğerleri = new double[çıkışnöronsayısı];

            Em = new double[çıkışnöronsayısı];

            Sçıkış = new double[çıkışnöronsayısı];
            deltaarakatman = new double[gizlikatmannöronsayısı, çıkışnöronsayısı];
            deltaarakatmanönceki = new double[gizlikatmannöronsayısı, çıkışnöronsayısı];
            deltaçıkışkatmanbias = new double[çıkışnöronsayısı];
            deltaçıkışkatmanbiasönceki = new double[çıkışnöronsayısı];

            Sgizli = new double[gizlikatmannöronsayısı];
            deltailkkatman = new double[girişdizisi.Length, gizlikatmannöronsayısı];
            deltailkkatmanönceki = new double[girişdizisi.Length,gizlikatmannöronsayısı];
            deltaarakatmanbias = new double[gizlikatmannöronsayısı];
            deltaarakatmanbiasönceki = new double[gizlikatmannöronsayısı];


            RandomDeğerlerAtama();
            targetOluşturFonk();
        }
        
        private void RandomDeğerlerAtama()
        {
            Random rnd=new Random();
            for (int i = 0; i < girişdizisi.Length; i++)
            {
                for (int j = 0; j < gizlikatmannöronsayısı; j++)
                {
                    girişağırlıkları[i, j] = rnd.NextDouble() * (1 - (-1)) + (-1);
                }
            }

            for (int i = 0; i < gizlikatmannöronsayısı; i++)
            {
                for (int j = 0; j < çıkışnöronsayısı; j++)
                {
                    gizlikatmanağırlıkları[i, j] = rnd.NextDouble() * (1 - (-1)) + (-1);
                }
                gizlikatmanbiasağırlıkları[i] = rnd.NextDouble() * (1 - (-1)) + (-1);
            }

            for (int i = 0; i < çıkışnöronsayısı; i++)
            {
                çıkışbiasağırlıkları[i] = rnd.NextDouble() * (1 - (-1)) + (-1);
            }
        }

        public double aktivastonFonk(double net,double deger)
        {
            return 1/(1+Math.Pow(Math.E,(-(net+deger))));
        }

        public void targetOluşturFonk()
        {
            for (int i = 0; i < 5; i++)
            {
                çıkışdizisi[i, i] = 1;
            }
        }
        int epoch = 0;
        public void netveçıkışhesapla(int döngüsayısı,double hataorani,Label labeldöngü)
        {
            
            int kaçıncıkarakter = 0;
            do
            {
                //gizli katman degerli hesaplanması
                for (int i = 0; i < gizlikatmannöronsayısı; i++)//-35
                {
                    for (int k = 0; k < girişdizisi.Length; k++)
                    {
                        gizlikatmantoplamnet[i] += abcde[k, kaçıncıkarakter] * girişağırlıkları[k, kaçıncıkarakter];
                    }
                    gizlikatmantoplamnet[i] += gizlikatmanbiasağırlıkları[i];
                    gizlikatmançıkışdeğerleri[i] = aktivastonFonk(gizlikatmantoplamnet[i], 0);
                }

                //cıkıs katman degerli hesaplanması
                for (int i = 0; i < çıkışnöronsayısı; i++)//-35
                {
                    for (int k = 0; k < gizlikatmannöronsayısı; k++)
                    {
                        çıkıştoplamnet[i] += gizlikatmançıkışdeğerleri[i] * gizlikatmanağırlıkları[k,i];
                    }
                    çıkıştoplamnet[i] += çıkışbiasağırlıkları[i];
                    çıkışdeğerleri[i] = aktivastonFonk(çıkıştoplamnet[i], 0);

                    Em[i] = çıkışdizisi[i, kaçıncıkarakter] - çıkışdeğerleri[i];

                }
                çıkıştoplamhata = hataKareleriToplamı();//??

                //geri yayılım ara katman degerleri
                for (int k = 0; k < çıkışnöronsayısı; k++)
                {
                    Sçıkış[k] = çıkışdeğerleri[k] * (1 - çıkışdeğerleri[k]) * Em[k];
                }

                //delta ara katman
                for (int i = 0; i < çıkışnöronsayısı; i++)
                {
                    for (int k = 0; k < gizlikatmannöronsayısı; k++)
                    {
                        deltaarakatman[k, i] = lamda * Sçıkış[i] * çıkışdeğerleri[i] +
                             alfa * deltaarakatmanönceki[k, i];

                        deltaarakatmanönceki[k, i] =
                            deltaarakatman[k, i];
                    }
                    deltaçıkışkatmanbias[i] = lamda * Sçıkış[i] + alfa * deltaçıkışkatmanbiasönceki[i];
                    deltaçıkışkatmanbiasönceki[i] = deltaçıkışkatmanbias[i];
                }

                //ara ile cıkıs arası guncelle
                for (int i = 0; i < çıkışnöronsayısı; i++)
                {
                    for (int k = 0; k < gizlikatmannöronsayısı; k++)
                    {
                        gizlikatmanağırlıkları[k, i] += deltaarakatman[k, i];
                    }
                    çıkışbiasağırlıkları[i] += deltaçıkışkatmanbias[i];
                }

                //geri yayılım ilk katman degerleri
                for (int j = 0; j < gizlikatmannöronsayısı; j++)
                {
                    double tmp=0;
                    for (int m = 0; m < çıkışnöronsayısı; m++)
                    {
                        tmp+=Sçıkış[m]*gizlikatmanağırlıkları[j,m];
                    }
                    Sgizli[j] = gizlikatmançıkışdeğerleri[j] * (1 - gizlikatmançıkışdeğerleri[j]) * tmp;     
                }

                //delta ilk katman
                for (int i = 0; i < gizlikatmannöronsayısı; i++)
                {
                    for (int k = 0; k < girişdizisi.Length; k++)
                    {
                        deltailkkatman[k, i] = lamda * Sgizli[i] * girişdizisi[i] +
                             alfa * deltailkkatmanönceki[k, i];

                        deltailkkatmanönceki[k, i] =
                            deltailkkatman[k, i];
                    }
                    deltaarakatmanbias[i] = lamda * Sgizli[i] + alfa * deltaarakatmanbiasönceki[i];
                    deltaarakatmanbiasönceki[i] = deltaarakatmanbias[i];
                }

                //giriş ile ara arası guncelle
                for (int i = 0; i < gizlikatmannöronsayısı; i++)
                {
                    for (int k = 0; k < girişdizisi.Length; k++)
                    {
                        girişağırlıkları[k, i] += deltailkkatman[k, i];
                    }
                    gizlikatmanbiasağırlıkları[i] += deltaarakatmanbias[i];
                }

                kaçıncıkarakter++;//duruma göre karakteri değiştir
                if (kaçıncıkarakter == 5)
                    kaçıncıkarakter = 0;

                epoch++;
                if (epoch >= döngüsayısı && sonlanmakriteri=="epoch")
                    break;
                if (hataorani >= çıkıştoplamhata)
                    break;
            } while (true);
            
            labeldöngü.Text = "Epoch : " + epoch.ToString() + "\n\nGoal : " + çıkıştoplamhata.ToString();
        }

        public double hataKareleriToplamı()
        {
            double temp=0;
            for (int i = 0; i < Em.Length; i++)
            {
                temp += Math.Pow(Em[i], 2);
                //temp = Math.Pow(Em[i], 2);
            }
            return temp;//  /2 maybe
            //return Math.Sqrt(temp);
        }

        public void AutoCharacterLoad()
        {
            int[,] otoChar = {
                         {0,0,1,0,0, 0,1,0,1,0, 1,0,0,0,1, 1,1,1,1,1, 1,0,0,0,1, 1,0,0,0,1, 1,0,0,0,1},
                         {1,1,1,1,0, 1,0,0,0,1, 1,0,0,0,1, 1,1,1,1,0, 1,0,0,0,1, 1,0,0,0,1, 1,1,1,1,0},
                         {0,0,1,1,0, 0,1,0,0,1, 1,0,0,0,0, 1,0,0,0,0, 1,0,0,0,0, 0,1,0,0,1, 0,0,1,1,0},
                         {1,1,1,0,0, 1,0,0,1,0, 1,0,0,0,1, 1,0,0,0,1, 1,0,0,0,1, 1,0,0,1,0, 1,1,1,0,0},
                         {1,1,1,1,1, 1,0,0,0,0, 1,0,0,0,0, 1,1,1,1,1, 1,0,0,0,0, 1,0,0,0,0, 1,1,1,1,1}};

            for (int k = 0; k < 5; k++)
            {
                for (int i = 0; i < 35; i++)
                {
                    abcde[i, k] = otoChar[k,i];
                }
            }
        }

        public void TestEt(int[] gelen,Label a,Label b,Label c,Label d,Label e)
        {
            //gizli katman degerli hesaplanması
            for (int i = 0; i < gizlikatmannöronsayısı; i++)//-35
            {
                for (int k = 0; k < girişdizisi.Length; k++)
                {
                    gizlikatmantoplamnet[i] += gelen[k] * girişağırlıkları[k, i];
                }
                gizlikatmantoplamnet[i] += gizlikatmanbiasağırlıkları[i];
                gizlikatmançıkışdeğerleri[i] = aktivastonFonk(gizlikatmantoplamnet[i], 0);
            }

            //cıkıs katman degerli hesaplanması
            for (int i = 0; i < çıkışnöronsayısı; i++)//-35
            {
                for (int k = 0; k < gizlikatmannöronsayısı; k++)
                {
                    çıkıştoplamnet[i] += gizlikatmançıkışdeğerleri[i] * gizlikatmanağırlıkları[k, i];
                }
                çıkıştoplamnet[i] += çıkışbiasağırlıkları[i];
                çıkışdeğerleri[i] = aktivastonFonk(çıkıştoplamnet[i], 0);

                //Em[i] = çıkışdizisi[i, kaçıncıkarakter] - çıkışdeğerleri[i];
            }
            //çıkıştoplamhata = hataKareleriToplamı();

            a.Text = çıkışdeğerleri[0].ToString();
            b.Text = çıkışdeğerleri[1].ToString();
            c.Text = çıkışdeğerleri[2].ToString();
            d.Text = çıkışdeğerleri[3].ToString();
            e.Text = çıkışdeğerleri[4].ToString();

            double maxValue = çıkışdeğerleri.Max();
            int maxIndex = çıkışdeğerleri.ToList().IndexOf(maxValue);
            sonuçLabelSeç(a, b, c, d, e, maxIndex);
        }

        public void sonuçLabelSeç(Label a, Label b, Label c, Label d, Label e, int maxIndex)
        {
            if (maxIndex == 0)
                a.BackColor = Color.LightGreen;
            else if (maxIndex == 1)
                b.BackColor = Color.LightGreen;
            else if (maxIndex == 2)
                c.BackColor = Color.LightGreen;
            else if (maxIndex == 3)
                d.BackColor = Color.LightGreen;
            else
                e.BackColor = Color.LightGreen;
        }

    }

}
