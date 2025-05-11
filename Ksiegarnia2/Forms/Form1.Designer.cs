namespace Ksiegarnia2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRaporty = new System.Windows.Forms.Button();
            this.btnHistoriaZakupow = new System.Windows.Forms.Button();
            this.btnZakupy = new System.Windows.Forms.Button();
            this.btnZasoby = new System.Windows.Forms.Button();
            this.btnPracownicy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRaporty
            // 
            this.btnRaporty.Location = new System.Drawing.Point(464, 242);
            this.btnRaporty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRaporty.Name = "btnRaporty";
            this.btnRaporty.Size = new System.Drawing.Size(238, 64);
            this.btnRaporty.TabIndex = 20;
            this.btnRaporty.Text = "Raporty";
            this.btnRaporty.UseVisualStyleBackColor = true;
            this.btnRaporty.Click += new System.EventHandler(this.btnRaporty_Click);
            // 
            // btnHistoriaZakupow
            // 
            this.btnHistoriaZakupow.Location = new System.Drawing.Point(323, 349);
            this.btnHistoriaZakupow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHistoriaZakupow.Name = "btnHistoriaZakupow";
            this.btnHistoriaZakupow.Size = new System.Drawing.Size(238, 64);
            this.btnHistoriaZakupow.TabIndex = 18;
            this.btnHistoriaZakupow.Text = "HistoriaZakupów";
            this.btnHistoriaZakupow.UseVisualStyleBackColor = true;
            this.btnHistoriaZakupow.Click += new System.EventHandler(this.btnHistoriaZakupow_Click);
            // 
            // btnZakupy
            // 
            this.btnZakupy.Location = new System.Drawing.Point(180, 242);
            this.btnZakupy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZakupy.Name = "btnZakupy";
            this.btnZakupy.Size = new System.Drawing.Size(238, 64);
            this.btnZakupy.TabIndex = 16;
            this.btnZakupy.Text = "Zakupy";
            this.btnZakupy.UseVisualStyleBackColor = true;
            this.btnZakupy.Click += new System.EventHandler(this.btnZakupy_Click);
            // 
            // btnZasoby
            // 
            this.btnZasoby.BackColor = System.Drawing.Color.Pink;
            this.btnZasoby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnZasoby.Location = new System.Drawing.Point(180, 142);
            this.btnZasoby.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZasoby.Name = "btnZasoby";
            this.btnZasoby.Size = new System.Drawing.Size(238, 64);
            this.btnZasoby.TabIndex = 14;
            this.btnZasoby.Text = "Zasoby";
            this.btnZasoby.UseVisualStyleBackColor = false;
            this.btnZasoby.Click += new System.EventHandler(this.btnZasoby_Click);
            // 
            // btnPracownicy
            // 
            this.btnPracownicy.BackColor = System.Drawing.Color.Pink;
            this.btnPracownicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPracownicy.Location = new System.Drawing.Point(464, 142);
            this.btnPracownicy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPracownicy.Name = "btnPracownicy";
            this.btnPracownicy.Size = new System.Drawing.Size(238, 64);
            this.btnPracownicy.TabIndex = 21;
            this.btnPracownicy.Text = "Personel";
            this.btnPracownicy.UseVisualStyleBackColor = false;
            this.btnPracownicy.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(845, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 48);
            this.button1.TabIndex = 22;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ksiegarnia2.Properties.Resources.v807_mynt_03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 571);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPracownicy);
            this.Controls.Add(this.btnRaporty);
            this.Controls.Add(this.btnHistoriaZakupow);
            this.Controls.Add(this.btnZakupy);
            this.Controls.Add(this.btnZasoby);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRaporty;
        private System.Windows.Forms.Button btnHistoriaZakupow;
        private System.Windows.Forms.Button btnZakupy;
        private System.Windows.Forms.Button btnZasoby;
        private System.Windows.Forms.Button btnPracownicy;
        private System.Windows.Forms.Button button1;
    }
}

