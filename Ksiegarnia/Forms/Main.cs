using System.Windows.Forms;

namespace Ksiegarnia
{
    internal class Main : Form
    {
        private Button btnRaporty;
        private Button btnClose;
        private Button btnHistoriaZakupow;
        private Button btnCennik;
        private Button btnZakupy;
        private Button btnPracownicy;
        private Button btnZasoby;

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
            this.btnRaporty.Location = new System.Drawing.Point(972, 12);
            this.btnRaporty.Name = "btnRaporty";
            this.btnRaporty.Size = new System.Drawing.Size(187, 47);
            this.btnRaporty.TabIndex = 13;
            this.btnRaporty.Text = "Raporty";
            this.btnRaporty.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1187, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 48);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnHistoriaZakupow
            // 
            this.btnHistoriaZakupow.Location = new System.Drawing.Point(779, 12);
            this.btnHistoriaZakupow.Name = "btnHistoriaZakupow";
            this.btnHistoriaZakupow.Size = new System.Drawing.Size(187, 47);
            this.btnHistoriaZakupow.TabIndex = 11;
            this.btnHistoriaZakupow.Text = "HistoriaZakupów";
            this.btnHistoriaZakupow.UseVisualStyleBackColor = true;
            // 
            // btnCennik
            // 
            this.btnCennik.Location = new System.Drawing.Point(586, 12);
            this.btnCennik.Name = "btnCennik";
            this.btnCennik.Size = new System.Drawing.Size(187, 47);
            this.btnCennik.TabIndex = 10;
            this.btnCennik.Text = "Cennik";
            this.btnCennik.UseVisualStyleBackColor = true;
            // 
            // btnZakupy
            // 
            this.btnZakupy.Location = new System.Drawing.Point(393, 12);
            this.btnZakupy.Name = "btnZakupy";
            this.btnZakupy.Size = new System.Drawing.Size(187, 47);
            this.btnZakupy.TabIndex = 9;
            this.btnZakupy.Text = "Zakupy";
            this.btnZakupy.UseVisualStyleBackColor = true;
            // 
            // btnPracownicy
            // 
            this.btnPracownicy.Location = new System.Drawing.Point(200, 12);
            this.btnPracownicy.Name = "btnPracownicy";
            this.btnPracownicy.Size = new System.Drawing.Size(187, 47);
            this.btnPracownicy.TabIndex = 8;
            this.btnPracownicy.Text = "Pracownicy";
            this.btnPracownicy.UseVisualStyleBackColor = true;
            // 
            // btnZasoby
            // 
            this.btnZasoby.Location = new System.Drawing.Point(7, 12);
            this.btnZasoby.Name = "btnZasoby";
            this.btnZasoby.Size = new System.Drawing.Size(187, 47);
            this.btnZasoby.TabIndex = 7;
            this.btnZasoby.Text = "Zasoby";
            this.btnZasoby.UseVisualStyleBackColor = true;
            this.btnZasoby.Click += new System.EventHandler(this.btnZasoby_Click);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(1269, 571);
            this.Controls.Add(this.btnRaporty);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHistoriaZakupow);
            this.Controls.Add(this.btnCennik);
            this.Controls.Add(this.btnZakupy);
            this.Controls.Add(this.btnPracownicy);
            this.Controls.Add(this.btnZasoby);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        private void btnZasoby_Click(object sender, System.EventArgs e)
        {
            Zasoby zasoby = new Zasoby();
            zasoby.Show();
        }
    }
}