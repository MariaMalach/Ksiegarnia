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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHistoriaZakupow = new System.Windows.Forms.Button();
            this.btnCennik = new System.Windows.Forms.Button();
            this.btnZakupy = new System.Windows.Forms.Button();
            this.btnPracownicy = new System.Windows.Forms.Button();
            this.btnZasoby = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRaporty
            // 
            this.btnRaporty.Location = new System.Drawing.Point(974, 12);
            this.btnRaporty.Name = "btnRaporty";
            this.btnRaporty.Size = new System.Drawing.Size(187, 47);
            this.btnRaporty.TabIndex = 20;
            this.btnRaporty.Text = "Raporty";
            this.btnRaporty.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1189, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 48);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnHistoriaZakupow
            // 
            this.btnHistoriaZakupow.Location = new System.Drawing.Point(781, 12);
            this.btnHistoriaZakupow.Name = "btnHistoriaZakupow";
            this.btnHistoriaZakupow.Size = new System.Drawing.Size(187, 47);
            this.btnHistoriaZakupow.TabIndex = 18;
            this.btnHistoriaZakupow.Text = "HistoriaZakupów";
            this.btnHistoriaZakupow.UseVisualStyleBackColor = true;
            // 
            // btnCennik
            // 
            this.btnCennik.Location = new System.Drawing.Point(588, 12);
            this.btnCennik.Name = "btnCennik";
            this.btnCennik.Size = new System.Drawing.Size(187, 47);
            this.btnCennik.TabIndex = 17;
            this.btnCennik.Text = "Cennik";
            this.btnCennik.UseVisualStyleBackColor = true;
            // 
            // btnZakupy
            // 
            this.btnZakupy.Location = new System.Drawing.Point(395, 12);
            this.btnZakupy.Name = "btnZakupy";
            this.btnZakupy.Size = new System.Drawing.Size(187, 47);
            this.btnZakupy.TabIndex = 16;
            this.btnZakupy.Text = "Zakupy";
            this.btnZakupy.UseVisualStyleBackColor = true;
            // 
            // btnPracownicy
            // 
            this.btnPracownicy.Location = new System.Drawing.Point(202, 12);
            this.btnPracownicy.Name = "btnPracownicy";
            this.btnPracownicy.Size = new System.Drawing.Size(187, 47);
            this.btnPracownicy.TabIndex = 15;
            this.btnPracownicy.Text = "Pracownicy";
            this.btnPracownicy.UseVisualStyleBackColor = true;
            // 
            // btnZasoby
            // 
            this.btnZasoby.Location = new System.Drawing.Point(9, 12);
            this.btnZasoby.Name = "btnZasoby";
            this.btnZasoby.Size = new System.Drawing.Size(187, 47);
            this.btnZasoby.TabIndex = 14;
            this.btnZasoby.Text = "Zasoby";
            this.btnZasoby.UseVisualStyleBackColor = true;
            this.btnZasoby.Click += new System.EventHandler(this.btnZasoby_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 571);
            this.Controls.Add(this.btnRaporty);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHistoriaZakupow);
            this.Controls.Add(this.btnCennik);
            this.Controls.Add(this.btnZakupy);
            this.Controls.Add(this.btnPracownicy);
            this.Controls.Add(this.btnZasoby);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRaporty;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHistoriaZakupow;
        private System.Windows.Forms.Button btnCennik;
        private System.Windows.Forms.Button btnZakupy;
        private System.Windows.Forms.Button btnPracownicy;
        private System.Windows.Forms.Button btnZasoby;
    }
}

