namespace hexis
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ponukaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nováHraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ovládanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.najlepšíHráčiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.koniecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.u1 = new System.Windows.Forms.ToolStripMenuItem();
            this.začiatočníkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.u2 = new System.Windows.Forms.ToolStripMenuItem();
            this.u3 = new System.Windows.Forms.ToolStripMenuItem();
            this.rýchlosťToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.r0 = new System.Windows.Forms.ToolStripMenuItem();
            this.r1 = new System.Windows.Forms.ToolStripMenuItem();
            this.r2 = new System.Windows.Forms.ToolStripMenuItem();
            this.r3 = new System.Windows.Forms.ToolStripMenuItem();
            this.r4 = new System.Windows.Forms.ToolStripMenuItem();
            this.r5 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbod = new System.Windows.Forms.Label();
            this.lrad = new System.Windows.Forms.Label();
            this.llev = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pauzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukončiťHruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mriežkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.White;
            this.pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb1.Location = new System.Drawing.Point(12, 31);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(465, 563);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(372, 597);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "body:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ponukaToolStripMenuItem,
            this.u1,
            this.rýchlosťToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ponukaToolStripMenuItem
            // 
            this.ponukaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nováHraToolStripMenuItem,
            this.pauzaToolStripMenuItem,
            this.ukončiťHruToolStripMenuItem,
            this.toolStripSeparator1,
            this.ovládanieToolStripMenuItem,
            this.najlepšíHráčiToolStripMenuItem,
            this.toolStripSeparator2,
            this.koniecToolStripMenuItem});
            this.ponukaToolStripMenuItem.Name = "ponukaToolStripMenuItem";
            this.ponukaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ponukaToolStripMenuItem.Text = "&Ponuka";
            // 
            // nováHraToolStripMenuItem
            // 
            this.nováHraToolStripMenuItem.Name = "nováHraToolStripMenuItem";
            this.nováHraToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.nováHraToolStripMenuItem.Text = "Nová hra            N";
            this.nováHraToolStripMenuItem.Click += new System.EventHandler(this.nováHraToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // ovládanieToolStripMenuItem
            // 
            this.ovládanieToolStripMenuItem.Name = "ovládanieToolStripMenuItem";
            this.ovládanieToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ovládanieToolStripMenuItem.Text = "Ovládanie";
            this.ovládanieToolStripMenuItem.Click += new System.EventHandler(this.ovládanieToolStripMenuItem_Click);
            // 
            // najlepšíHráčiToolStripMenuItem
            // 
            this.najlepšíHráčiToolStripMenuItem.Name = "najlepšíHráčiToolStripMenuItem";
            this.najlepšíHráčiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.najlepšíHráčiToolStripMenuItem.Text = "Najlepší hráči";
            this.najlepšíHráčiToolStripMenuItem.Click += new System.EventHandler(this.najlepšíHráčiToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // koniecToolStripMenuItem
            // 
            this.koniecToolStripMenuItem.Name = "koniecToolStripMenuItem";
            this.koniecToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.koniecToolStripMenuItem.Text = "Koniec               Q";
            this.koniecToolStripMenuItem.Click += new System.EventHandler(this.koniecToolStripMenuItem_Click);
            // 
            // u1
            // 
            this.u1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.začiatočníkToolStripMenuItem,
            this.u2,
            this.u3,
            this.toolStripSeparator3,
            this.mriežkaToolStripMenuItem});
            this.u1.Name = "u1";
            this.u1.Size = new System.Drawing.Size(57, 20);
            this.u1.Text = "Úr&oveň";
            // 
            // začiatočníkToolStripMenuItem
            // 
            this.začiatočníkToolStripMenuItem.CheckOnClick = true;
            this.začiatočníkToolStripMenuItem.Name = "začiatočníkToolStripMenuItem";
            this.začiatočníkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.začiatočníkToolStripMenuItem.Text = "Začiatočník";
            this.začiatočníkToolStripMenuItem.Click += new System.EventHandler(this.začiatočníkToolStripMenuItem_Click);
            // 
            // u2
            // 
            this.u2.Checked = true;
            this.u2.CheckOnClick = true;
            this.u2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.u2.Name = "u2";
            this.u2.Size = new System.Drawing.Size(152, 22);
            this.u2.Text = "Pokročilý";
            this.u2.Click += new System.EventHandler(this.u2_Click);
            // 
            // u3
            // 
            this.u3.CheckOnClick = true;
            this.u3.Name = "u3";
            this.u3.Size = new System.Drawing.Size(152, 22);
            this.u3.Text = "Expert";
            this.u3.Click += new System.EventHandler(this.u3_Click);
            // 
            // rýchlosťToolStripMenuItem
            // 
            this.rýchlosťToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.r0,
            this.r1,
            this.r2,
            this.r3,
            this.r4,
            this.r5});
            this.rýchlosťToolStripMenuItem.Name = "rýchlosťToolStripMenuItem";
            this.rýchlosťToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.rýchlosťToolStripMenuItem.Text = "&Rýchlosť";
            // 
            // r0
            // 
            this.r0.Checked = true;
            this.r0.CheckOnClick = true;
            this.r0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.r0.Name = "r0";
            this.r0.Size = new System.Drawing.Size(152, 22);
            this.r0.Text = "0";
            this.r0.Click += new System.EventHandler(this.r0_Click);
            // 
            // r1
            // 
            this.r1.CheckOnClick = true;
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(152, 22);
            this.r1.Text = "1";
            this.r1.Click += new System.EventHandler(this.r1_Click);
            // 
            // r2
            // 
            this.r2.CheckOnClick = true;
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(152, 22);
            this.r2.Text = "2";
            this.r2.Click += new System.EventHandler(this.r2_Click);
            // 
            // r3
            // 
            this.r3.CheckOnClick = true;
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(152, 22);
            this.r3.Text = "3";
            this.r3.Click += new System.EventHandler(this.r3_Click);
            // 
            // r4
            // 
            this.r4.CheckOnClick = true;
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(152, 22);
            this.r4.Text = "4";
            this.r4.Click += new System.EventHandler(this.r4_Click);
            // 
            // r5
            // 
            this.r5.CheckOnClick = true;
            this.r5.Name = "r5";
            this.r5.Size = new System.Drawing.Size(152, 22);
            this.r5.Text = "5";
            this.r5.Click += new System.EventHandler(this.r5_Click);
            // 
            // lbod
            // 
            this.lbod.AutoSize = true;
            this.lbod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbod.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbod.Location = new System.Drawing.Point(438, 610);
            this.lbod.Name = "lbod";
            this.lbod.Size = new System.Drawing.Size(19, 20);
            this.lbod.TabIndex = 6;
            this.lbod.Text = "0";
            this.lbod.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lrad
            // 
            this.lrad.AutoSize = true;
            this.lrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lrad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lrad.Location = new System.Drawing.Point(225, 610);
            this.lrad.Name = "lrad";
            this.lrad.Size = new System.Drawing.Size(19, 20);
            this.lrad.TabIndex = 5;
            this.lrad.Text = "0";
            this.lrad.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // llev
            // 
            this.llev.AutoSize = true;
            this.llev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.llev.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llev.Location = new System.Drawing.Point(76, 610);
            this.llev.Name = "llev";
            this.llev.Size = new System.Drawing.Size(19, 20);
            this.llev.TabIndex = 4;
            this.llev.Text = "0";
            this.llev.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(24, 597);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "rýchlosť:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(193, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "rady:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pauzaToolStripMenuItem
            // 
            this.pauzaToolStripMenuItem.Name = "pauzaToolStripMenuItem";
            this.pauzaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pauzaToolStripMenuItem.Text = "Pauza                  P";
            this.pauzaToolStripMenuItem.Click += new System.EventHandler(this.pauzaToolStripMenuItem_Click);
            // 
            // ukončiťHruToolStripMenuItem
            // 
            this.ukončiťHruToolStripMenuItem.Name = "ukončiťHruToolStripMenuItem";
            this.ukončiťHruToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ukončiťHruToolStripMenuItem.Text = "Ukončiť hru       S";
            this.ukončiťHruToolStripMenuItem.Click += new System.EventHandler(this.ukončiťHruToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // mriežkaToolStripMenuItem
            // 
            this.mriežkaToolStripMenuItem.Checked = true;
            this.mriežkaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mriežkaToolStripMenuItem.Name = "mriežkaToolStripMenuItem";
            this.mriežkaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mriežkaToolStripMenuItem.Text = "Mriežka";
            this.mriežkaToolStripMenuItem.Click += new System.EventHandler(this.mriežkaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(495, 634);
            this.Controls.Add(this.lbod);
            this.Controls.Add(this.lrad);
            this.Controls.Add(this.llev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "hexis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ponukaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nováHraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ovládanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem najlepšíHráčiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem koniecToolStripMenuItem;
        private System.Windows.Forms.Label lbod;
        private System.Windows.Forms.Label lrad;
        private System.Windows.Forms.Label llev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem u1;
        private System.Windows.Forms.ToolStripMenuItem začiatočníkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem u2;
        private System.Windows.Forms.ToolStripMenuItem u3;
        private System.Windows.Forms.ToolStripMenuItem rýchlosťToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem r0;
        private System.Windows.Forms.ToolStripMenuItem r1;
        private System.Windows.Forms.ToolStripMenuItem r2;
        private System.Windows.Forms.ToolStripMenuItem r3;
        private System.Windows.Forms.ToolStripMenuItem r4;
        private System.Windows.Forms.ToolStripMenuItem r5;
        private System.Windows.Forms.ToolStripMenuItem pauzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukončiťHruToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mriežkaToolStripMenuItem;
    }
}

