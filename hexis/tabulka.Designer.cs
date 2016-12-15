namespace hexis
{
    partial class tabulka
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
            this.label1 = new System.Windows.Forms.Label();
            this.hrac = new System.Windows.Forms.TextBox();
            this.pomene = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patríš medzi \r\nnajlepších!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hrac
            // 
            this.hrac.Location = new System.Drawing.Point(35, 79);
            this.hrac.Name = "hrac";
            this.hrac.Size = new System.Drawing.Size(162, 29);
            this.hrac.TabIndex = 1;
            this.hrac.Text = "JA";
            this.hrac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hrac.Validating += new System.ComponentModel.CancelEventHandler(this.hrac_Validating);
            // 
            // pomene
            // 
            this.pomene.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pomene.Location = new System.Drawing.Point(79, 114);
            this.pomene.Name = "pomene";
            this.pomene.Size = new System.Drawing.Size(75, 23);
            this.pomene.TabIndex = 2;
            this.pomene.Text = "ok";
            this.pomene.UseVisualStyleBackColor = true;
            this.pomene.Click += new System.EventHandler(this.danemeno);
            // 
            // tabulka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 148);
            this.Controls.Add(this.pomene);
            this.Controls.Add(this.hrac);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tabulka";
            this.Text = "Gratulujeme!";
            this.Activated += new System.EventHandler(this.tabulka_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabulka_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hrac;
        private System.Windows.Forms.Button pomene;
    }
}