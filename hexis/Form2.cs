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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            tab = new List<string>();
            nacitaj();
            button1.Select();
        }

        List<string> tab;

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode==Keys.Enter)
                Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Naozaj chceš zmazať tabuľku?", "Potvrdenie", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                StreamWriter swp = new StreamWriter("..\\..\\tab.txt");
                swp.Close();
            }
        }

        private void nacitaj()
        {
            try
            {
                StreamReader srt = new StreamReader("..\\..\\tab.txt");
                tab.Clear();
                while (!srt.EndOfStream)
                {
                    string text;
                    text = srt.ReadLine();
                    tab.Add(text);
                }
                srt.Close();
                pis();
                
               // MessageBox.Show("nacital som " + tab.Count);
            }
            catch (Exception exp) { MessageBox.Show("tabu+lka to nezvladla\r\n\r\n"+exp.ToString()); }
        }

        private void pis() 
        {
            for (int i = 0; i < tab.Count/2; i++) 
            {
                Label lab = new Label();
                lab.Font = button1.Font;
                lab.Location = new Point(30, 30 + i * 30);
                lab.Text =(i+1)+".   "+ tab[2 * i];

                Label labc = new Label();
                labc.Font = button1.Font;
                labc.Location = new Point(150, 30 + i * 30);
                labc.Text = tab[2 * i+1];

                this.Controls.Add(lab);
                this.Controls.Add(labc);
            }
            button1.Focus();
       }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
