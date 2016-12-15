using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hexis
{
    public partial class tabulka : Form
    {
        public class udaj
        {
            public string meno;
            public int kolko;
            public udaj(string meno, int kolko) { this.meno = meno; this.kolko = kolko; }
        }

        public int tahajbody
        {
            get { return pk; }
            set { pk = value; }
        }
   
        public tabulka()
        {
            InitializeComponent();
           // tab.Clear();
            pomene.Select();
        }

        int pk;
        List<udaj> tab = new List<udaj>();

        private void danemeno(object sender, EventArgs e)
        {
            bool je = false;
            int a = 0;
            try
            {   

                StreamWriter swp = new StreamWriter("..\\..\\tab.txt");
                swp.Close();
                StreamWriter sw = new StreamWriter("..\\..\\tab.txt", true);

                for (a= 0; a < tab.Count; a++) 
                {
                    if (tab[a].kolko >= pk) 
                    {
                        sw.WriteLine(tab[a].meno); sw.WriteLine(tab[a].kolko); 
                    }
                    else if (/*tab[a].kolko <= pk &&*/ a < 10 && !je)
                    {
                        sw.WriteLine(hrac.Text);
                        sw.WriteLine(pk + "");
                        if(a!=0) a--;
                        je = true;

                    }

                    if (tab[a].kolko < pk && ((a<9 &&je)||(a==10 &&!je)) )
                    {
                        sw.WriteLine(tab[a].meno); sw.WriteLine(tab[a].kolko);
                    }
                }
                if (a < 10 && je == false)
                {
                    sw.WriteLine(hrac.Text);
                    sw.WriteLine(pk + "");
                }
                sw.Close();
            }
            catch (Exception exp) { MessageBox.Show("zlyhal zapis - tabu+lka neuniesla +tarchu tvojich bodov"+exp.ToString()); }
            Close();
        }

        private void nacitaj()
        {
            try
            {
                StreamReader srt = new StreamReader("..\\..\\tab.txt");
                tab.Clear();
                string text; int cislo;
                while (!srt.EndOfStream)
                {
                    text = srt.ReadLine();
                    cislo = Convert.ToInt32(srt.ReadLine());
                    udaj U = new udaj(text, cislo);
                    tab.Add(U);
                }
                srt.Close();
            }
            catch(Exception exp) {MessageBox.Show("zlyhalo nacitanie" + exp.ToString()) ;}
        }

  

        private void tabulka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
                Close();
        }

        private void hrac_Validating(object sender, CancelEventArgs e)
        {
            if (hrac.Text.Length > 10) hrac.Text = hrac.Text.Substring(0,10);
        }

        private void tabulka_Load(object sender, EventArgs e)
        {
            nacitaj();
            if (tab.Count != 0 && tab[tab.Count - 1].kolko >= pk && tab.Count >= 10) Close();
        }



    }
}