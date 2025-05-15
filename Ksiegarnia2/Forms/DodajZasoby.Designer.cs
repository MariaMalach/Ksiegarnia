namespace Ksiegarnia2.Forms
{
    partial class DodajZasoby
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTytul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textRokWydania = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textIlosc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvZasoby = new System.Windows.Forms.DataGridView();
            this.vwZasobyAutorzyCenyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ksiegarniaDataSet5 = new Ksiegarnia2.KsiegarniaDataSet5();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAutorzy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxWydawnictwo = new System.Windows.Forms.TextBox();
            this.textBoxKategoria = new System.Windows.Forms.TextBox();
            this.buttonEdycja = new System.Windows.Forms.Button();
            this.vw_ZasobyAutorzyCenyTableAdapter = new Ksiegarnia2.KsiegarniaDataSet5TableAdapters.vw_ZasobyAutorzyCenyTableAdapter();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZasoby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwZasobyAutorzyCenyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(34, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tytuł";
            // 
            // txbTytul
            // 
            this.txbTytul.BackColor = System.Drawing.Color.Pink;
            this.txbTytul.Location = new System.Drawing.Point(234, 109);
            this.txbTytul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTytul.Name = "txbTytul";
            this.txbTytul.Size = new System.Drawing.Size(291, 26);
            this.txbTytul.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(34, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Rok wydania";
            // 
            // textRokWydania
            // 
            this.textRokWydania.BackColor = System.Drawing.Color.Pink;
            this.textRokWydania.Location = new System.Drawing.Point(234, 351);
            this.textRokWydania.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textRokWydania.Name = "textRokWydania";
            this.textRokWydania.Size = new System.Drawing.Size(291, 26);
            this.textRokWydania.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Pink;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ilość";
            // 
            // textIlosc
            // 
            this.textIlosc.BackColor = System.Drawing.Color.Pink;
            this.textIlosc.Location = new System.Drawing.Point(234, 415);
            this.textIlosc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textIlosc.Name = "textIlosc";
            this.textIlosc.Size = new System.Drawing.Size(291, 26);
            this.textIlosc.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Pink;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(30, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 29);
            this.label4.TabIndex = 31;
            this.label4.Text = "Kategoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Pink;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(30, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 29);
            this.label5.TabIndex = 32;
            this.label5.Text = "Wydwanictwo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Pink;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(328, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 39);
            this.label6.TabIndex = 36;
            this.label6.Text = "Dodaj zasób";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Pink;
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodaj.Location = new System.Drawing.Point(290, 609);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(235, 52);
            this.btnDodaj.TabIndex = 37;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1418, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(107, 48);
            this.button1.TabIndex = 39;
            this.button1.Text = "Wróć";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Pink;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1530, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 48);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvZasoby
            // 
            this.dgvZasoby.AutoGenerateColumns = false;
            this.dgvZasoby.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvZasoby.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZasoby.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZasoby.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZasoby.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvZasoby.DataSource = this.vwZasobyAutorzyCenyBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.999999F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZasoby.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvZasoby.GridColor = System.Drawing.Color.Crimson;
            this.dgvZasoby.Location = new System.Drawing.Point(558, 109);
            this.dgvZasoby.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvZasoby.Name = "dgvZasoby";
            this.dgvZasoby.RowHeadersWidth = 62;
            this.dgvZasoby.RowTemplate.Height = 28;
            this.dgvZasoby.Size = new System.Drawing.Size(1040, 552);
            this.dgvZasoby.TabIndex = 40;
            this.dgvZasoby.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZasoby_CellContentClick);
            // 
            // vwZasobyAutorzyCenyBindingSource
            // 
            this.vwZasobyAutorzyCenyBindingSource.DataMember = "vw_ZasobyAutorzyCeny";
            this.vwZasobyAutorzyCenyBindingSource.DataSource = this.ksiegarniaDataSet5;
            // 
            // ksiegarniaDataSet5
            // 
            this.ksiegarniaDataSet5.DataSetName = "KsiegarniaDataSet5";
            this.ksiegarniaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Pink;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(34, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 29);
            this.label7.TabIndex = 42;
            this.label7.Text = "Cena";
            // 
            // textBoxCena
            // 
            this.textBoxCena.BackColor = System.Drawing.Color.Pink;
            this.textBoxCena.Location = new System.Drawing.Point(234, 286);
            this.textBoxCena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(291, 26);
            this.textBoxCena.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Pink;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(34, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 29);
            this.label8.TabIndex = 44;
            this.label8.Text = "Autorzy";
            // 
            // textBoxAutorzy
            // 
            this.textBoxAutorzy.BackColor = System.Drawing.Color.Pink;
            this.textBoxAutorzy.Location = new System.Drawing.Point(234, 220);
            this.textBoxAutorzy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAutorzy.Name = "textBoxAutorzy";
            this.textBoxAutorzy.Size = new System.Drawing.Size(291, 26);
            this.textBoxAutorzy.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Pink;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(36, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(482, 22);
            this.label9.TabIndex = 45;
            this.label9.Text = "Jeśli pozycja ma wiecej niż jednego autora wypiisz ich z \" , \"";
            // 
            // textBoxWydawnictwo
            // 
            this.textBoxWydawnictwo.BackColor = System.Drawing.Color.Pink;
            this.textBoxWydawnictwo.Location = new System.Drawing.Point(234, 540);
            this.textBoxWydawnictwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxWydawnictwo.Name = "textBoxWydawnictwo";
            this.textBoxWydawnictwo.Size = new System.Drawing.Size(291, 26);
            this.textBoxWydawnictwo.TabIndex = 47;
            // 
            // textBoxKategoria
            // 
            this.textBoxKategoria.BackColor = System.Drawing.Color.Pink;
            this.textBoxKategoria.Location = new System.Drawing.Point(234, 476);
            this.textBoxKategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKategoria.Name = "textBoxKategoria";
            this.textBoxKategoria.Size = new System.Drawing.Size(291, 26);
            this.textBoxKategoria.TabIndex = 46;
            // 
            // buttonEdycja
            // 
            this.buttonEdycja.BackColor = System.Drawing.Color.Pink;
            this.buttonEdycja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonEdycja.Location = new System.Drawing.Point(14, 609);
            this.buttonEdycja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdycja.Name = "buttonEdycja";
            this.buttonEdycja.Size = new System.Drawing.Size(235, 52);
            this.buttonEdycja.TabIndex = 48;
            this.buttonEdycja.Text = "Edytuj";
            this.buttonEdycja.UseVisualStyleBackColor = false;
            this.buttonEdycja.Click += new System.EventHandler(this.button2_Click);
            // 
            // vw_ZasobyAutorzyCenyTableAdapter
            // 
            this.vw_ZasobyAutorzyCenyTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Tytul";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tytul";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Autorzy";
            this.dataGridViewTextBoxColumn6.HeaderText = "Autorzy";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Cena";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cena";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "RokWydania";
            this.dataGridViewTextBoxColumn8.HeaderText = "RokWydania";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Kategoria";
            this.dataGridViewTextBoxColumn9.HeaderText = "Kategoria";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Wydawnictwo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Wydawnictwo";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // DodajZasoby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Ksiegarnia2.Properties.Resources.v807_mynt_03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1611, 702);
            this.ControlBox = false;
            this.Controls.Add(this.buttonEdycja);
            this.Controls.Add(this.textBoxWydawnictwo);
            this.Controls.Add(this.textBoxKategoria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxAutorzy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCena);
            this.Controls.Add(this.dgvZasoby);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textIlosc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textRokWydania);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbTytul);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DodajZasoby";
            this.Text = "DodajZasoby";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZasoby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwZasobyAutorzyCenyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTytul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textRokWydania;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textIlosc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvZasoby;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorzyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokWydaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wydawnictwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAutorzy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxWydawnictwo;
        private System.Windows.Forms.TextBox textBoxKategoria;
        private System.Windows.Forms.Button buttonEdycja;

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUtworzeniaDataGridViewTextBoxColumn;
        private KsiegarniaDataSet5 ksiegarniaDataSet5;
        private System.Windows.Forms.BindingSource vwZasobyAutorzyCenyBindingSource;
        private KsiegarniaDataSet5TableAdapters.vw_ZasobyAutorzyCenyTableAdapter vw_ZasobyAutorzyCenyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}