//toto je nova verzia, ktora použiva kocku vo formate 8x4
//ked su kocky uplne hore tak pri rotacii vybehnu a padne to
//dorobit, aby sa nereagovalo natla4itka, kym nie je spustena hra
//cele skontrolovat

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace hexis
{
    public partial class Form1 : Form
    {
        Image[] obr = new Image[5];
        Image ph;

        int[, , ,] kocky = new int[6,12, 8, 4];
        int x;
        int y;
        Bitmap bmp;
        Graphics g;
        Graphics ug;
        Brush bbr = new SolidBrush(Color.White);
        int[,] aktual = new int[8,4];
        int[,] spadnute = new int[32, 24];
        int[,] fs = new int[32, 24];
        Random rand = new Random();
        int w;
        bool kde;
        bool gr;

        int kmax;//kolko kociek sa pouziva
        int ay;
        int krot;
        int ki;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pb1.Width, pb1.Height);
            g = Graphics.FromImage(bmp);
            ug = Graphics.FromImage(bmp);

            ph = Image.FromFile("p.png");
            kde = true;
            gr = true;

            ay = 0;
            krot = 0;
            ki = 1;
            kmax = 8;
            timer1.Stop();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                obr[i] = Image.FromFile(Convert.ToString(i + 1) + ".png");
            }

            ug.FillRectangle(bbr, 0, 0, 480, 560);
            for (int j = 0; j < 560; j += 46)
                for (int i = 0; i < 480; i += 30)
                {
                    ug.DrawImage(ph, i - 2, j, 30, 30);
                    ug.DrawImage(ph, i + 15 - 2, j + 23, 30, 30);
                }
            g = ug;
            pb1.Image = bmp;

            StreamReader sr = new StreamReader("k11I.txt");
            string riadok;

            for (int r = 0; r < 6; r++)
            {
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        riadok = sr.ReadLine();
                        for (int k = 0; k < 8; k++)
                        {
                            kocky[r, i, k,j] = Int32.Parse(riadok.Substring(k, 1));

                        }
                    }
                }
            }
            sr.Close();
            x = 0; y = 0;
        }

        private void men()
        {
            if (kde == false) { kde = true; return; }
            if (kde == true) { kde = false; return; }
        }

        private void cisti()
        {
            ug.FillRectangle(bbr, 0, 0, 480, 560);
            if (gr)
            {
                for (int j = 0; j < 560; j += 46)
                    for (int i = 0; i < 480; i += 30)
                    {
                        ug.DrawImage(ph, i - 2, j, 30, 30);
                        ug.DrawImage(ph, i + 15 - 2, j + 23, 30, 30);
                    }
            }
            g = ug;
        }

        private void kresli()
        {
            cisti();
            for (int i = 0; i < 8; i++)//kresli padjucu kocku
            {
                for (int j = 0; j < 4; j++)
                {
                    if (aktual[i, j] != 0)
                    {
                        g.DrawImage(obr[w], i * 15 + x - 1 , j * 23 + y, 30, 30);
                    }
                }
            }
            for (int i = 0; i < 32; i++)//kresli u6 dopadnute kocky
            {
                for (int j = 0; j < 24; j++)
                {
                    if (spadnute[i, j] != 0)
                    {
                        g.DrawImage(obr[fs[i, j]], i * 15 - 2 -15, j * 23, 30, 30);
                    }
                }
            }
            pb1.Image = bmp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ttick();
            kresli();
        }

        private void ttick()
        {
            ay++;

            y += 23;//netreba ay aj y, sta4i jedno-> prerobit
            if (kde) x += 15;
            else x -= 15;
            if (!test()) { y -= 23; ay--; if (kde)x -= 15; else x += 15; men(); ttick(); }
            
            if (!test2()) { dopad(); }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left && e.Modifiers == Keys.Control) { x -= 30; kde = false; if (!test() || !test2(23)) { x += 30; } else kresli(); return; }
            if (e.KeyCode == Keys.Right && e.Modifiers == Keys.Control) { x += 30; kde = true; if (!test() || !test2(23)) { x -= 30; } else kresli(); return; }
            switch (e.KeyCode)
            {
                case Keys.S: stop(); break;
                case Keys.Q: Close(); break;
                case Keys.G: grid(); break;
                case Keys.P: pauza(); break;
                case Keys.N: novy(); break;
            };
            if(!u1.Enabled)
            switch (e.KeyCode)
            {
                case Keys.Down: ttick(); break;
                case Keys.Left: kde = false; break;
                case Keys.Right: kde = true; break;
                case Keys.Up: otoc(); if (!test()||!test2()) { otoc(-1); } break;

            };
            kresli();
        }

        private bool test()//test na narazenie o steny
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (aktual[i, j] == 1)
                    {   
                        //spodok
                        if ((j * 23 + y) >= pb1.Height - 23)
                        {
                            y -= 23; ay--;
                            { if (kde)x -= 15; else x += 15; dopad(); return true; }
                        }
                        //lava stena
                        if (i * 15 + x < 0-15) {  return false; }
                        //prava stena
                        if (i * 15 + x > pb1.Width - 30) { return false; }
                    }
                }
            }
            return true;
        }

        private bool test2(int yyy = 0)
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 4; j++)
                    if (aktual[i, j] == 1)
                        {
                            if (y < 0) { koniec(); }   
                            if (spadnute[(x + 3) / 15 + i +1, y / 23 + j] == 1) { y = y - 23 + yyy; if (yyy != 23) { ay--; if (kde)x -= 15; else x += 15; };if (test()) return false; else MessageBox.Show("zlyhalo"); }
                        }
           return true;
        }

        public void dopad()
        {
            if (y < 0) { koniec(); return; }
                for (int i = 0; i < 8; i++)
                    for (int j = 0; j < 4; j++)
                        if (aktual[i, j] == 1)
                           {
                                spadnute[(x +1) / 15 + i +1, y / 23 + j] = 1; fs[(x+1) / 15 + i +1, y / 23 + j] = w;
                           }
            kontrola();
            pridajbod();

            generuj();
        }

        private void grid()
        {
            gr = !gr;
        }

        public void generuj()
        {
            krot = 0;
            ay = 0;
            kde = Convert.ToBoolean(rand.Next(0, 1));
            int q = rand.Next(0, kmax);

            ki = q;
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 4; j++) aktual[i, j] = kocky[0, q, i, j];
            x = rand.Next(2, 10) * 30 - 1; y = 0;
            w = rand.Next(0, 5);
            if (!test2()) { dopad(); }
        }


        public void otoc(int okolko = 1)
        {
            krot += okolko;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                    aktual[i, j] = kocky[krot % 6, ki, i,j];
            }
        }

        public void kontrola()
        {
            int p = 0;
            int j = 0;
            for (int i = 0; i < 24; i++)
            {
                for (j = 0; j < 32; j++)
                {
                    if (spadnute[j, i] != 0) p++;
                }
                if (p == 15) mazrad(i);
                p = 0;
            }
        }

        public void mazrad(int q)
        {
            for (int j = 0; j < 32; j++)
            {
                spadnute[j, q] = 0;
                fs[j, q] = 0;
            }
            if (q % 2 == 0)
            {
                for (int i = q - 1; i > 1; i--)
                    for (int j = 0; j < 32; j++)
                    {

                        if (i % 2 == 1)
                        {
                            if (j == 31) spadnute[j, i + 1] = 0;
                            else
                            {
                                spadnute[j, i + 1] = spadnute[j + 1, i];
                                fs[j, i + 1] = fs[j + 1, i];
                            }
                        }
                        else
                        {
                            if (j == 0) spadnute[j, i + 1] = 0;
                            else
                            {
                                spadnute[j, i + 1] = spadnute[j - 1, i];
                                fs[j, i - 1] = fs[j, i];
                            }
                        }
                    }
            }
            if (q % 2 == 1)
            {
                for (int i = q - 1; i > 1; i--)
                    for (int j = 0; j < 32; j++)
                    {

                        if (i % 2 == 0)
                        {
                            if (j == 0) spadnute[j, i + 1] = 0;
                            else
                            {
                                spadnute[j, i + 1] = spadnute[j - 1, i];
                                fs[j, i + 1] = fs[j - 1, i];
                            }
                        }
                        else
                        {
                            if (j == 31) spadnute[j, i + 1] = 0;
                            else
                            {
                                spadnute[j, i + 1] = spadnute[j + 1, i];
                                fs[j, i + 1] = fs[j + 1, i];
                            }
                        }
                    }
            }
            //   prady++;
            lbod.Text = (Convert.ToInt32(lbod.Text) + 15) + "";
            lrad.Text = (Convert.ToInt32(lrad.Text) + 1) + "";
            if (Convert.ToInt32(lrad.Text) % 5 == 0)
            {
                timer1.Interval = timer1.Interval - 20;
                llev.Text = (Convert.ToInt32(llev.Text) + 1) + "";
            }
        }

        public void pridajbod()
        {
            int p = 0;
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 4; j++)
                    if (aktual[i, j] != 0) p++;
            lbod.Text = (Convert.ToInt32(lbod.Text) + p) + "";
        }

        public void koniec()
        {
            u1.Enabled = true;
            rýchlosťToolStripMenuItem.Enabled = true;
            timer1.Stop();
            tabulka t2 = new tabulka();
            t2.tahajbody = Convert.ToInt32(lbod.Text);
            t2.ShowDialog();
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }

        public void stop() 
        {
            u1.Enabled = true;
            rýchlosťToolStripMenuItem.Enabled = true;
            g.Clear(Color.White);
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 4; j++) aktual[i, j] = 0;
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    spadnute[j, i] = 0;
                    fs[j, i] = 0;
                }
            }
            lbod.Text = "0";
            llev.Text = "0";
            lrad.Text = "0";
            timer1.Start();
            x = 0; y = 0;
        }

        public void novy()
        {
            u1.Enabled = false;
            rýchlosťToolStripMenuItem.Enabled = false;
            g.Clear(Color.White);
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 4; j++) aktual[i, j] = 0;
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    spadnute[j, i] = 0;
                    fs[j, i] = 0;
                }
            }
            lbod.Text = "0";
            llev.Text = "0";
            lrad.Text = "0";
            timer1.Start();
            x = 0; y = 0;
            generuj();
            kresli();

        }

        private void pauza()
        {
            timer1.Stop();
            MessageBox.Show("Pauza");
            timer1.Start();

        }

        private void koniecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nováHraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            novy();
        }

        private void najlepšíHráčiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void ovládanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("rotacia .......... sipka hore\r\npad .......... sipka dole\r\nzmena smeru .......... sipky \r\nposun .......... ctrl + sipky");
        }

        private void začiatočníkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            u2.Checked = false;
            u3.Checked = false;
            kmax = 5;
        }

        private void u2_Click(object sender, EventArgs e)
        {
            začiatočníkToolStripMenuItem.Checked = false;
            u3.Checked = false;
            kmax = 8;
        }

        private void u3_Click(object sender, EventArgs e)
        {
            začiatočníkToolStripMenuItem.Checked = false;
            u2.Checked = false;
            kmax = 12;
        }

        private void r0_Click(object sender, EventArgs e)
        {
            r1.Checked = false; r2.Checked = false; r3.Checked = false; r4.Checked = false; r5.Checked = false;
            timer1.Interval = 500;
        }

        private void r1_Click(object sender, EventArgs e)
        {
            r0.Checked = false; r2.Checked = false; r3.Checked = false; r4.Checked = false; r5.Checked = false;
            timer1.Interval = 480;
        }

        private void r2_Click(object sender, EventArgs e)
        {
            r0.Checked = false; r1.Checked = false; r3.Checked = false; r4.Checked = false; r5.Checked = false;
            timer1.Interval = 460;
        }

        private void r3_Click(object sender, EventArgs e)
        {
            r0.Checked = false; r1.Checked = false; r2.Checked = false; r4.Checked = false; r5.Checked = false;
            timer1.Interval = 440;
        }

        private void r4_Click(object sender, EventArgs e)
        {
            r0.Checked = false; r1.Checked = false; r2.Checked = false; r3.Checked = false; r5.Checked = false;
            timer1.Interval = 420;
        }

        private void r5_Click(object sender, EventArgs e)
        {
            r0.Checked = false; r1.Checked = false; r3.Checked = false; r4.Checked = false; r4.Checked = false;
            timer1.Interval = 400;
        }

        private void pauzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pauza();
        }

        private void ukončiťHruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void mriežkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grid();
            mriežkaToolStripMenuItem.Checked = gr;
            cisti();
            kresli();
        }
    }
}

