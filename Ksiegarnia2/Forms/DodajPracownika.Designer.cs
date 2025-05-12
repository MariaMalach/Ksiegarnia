namespace Ksiegarnia2.Forms
{
    partial class DodajPracownika
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.txbNazwisko = new System.Windows.Forms.TextBox();
            this.dgvPracownicy = new System.Windows.Forms.DataGridView();
            this.iDPracownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataZatrudnieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaStanowiskaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwPracownicyZeStanowiskiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ksiegarniaDataSet3 = new Ksiegarnia2.KsiegarniaDataSet3();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTelefon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbImie = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.vw_PracownicyZeStanowiskiemTableAdapter = new Ksiegarnia2.KsiegarniaDataSet3TableAdapters.vw_PracownicyZeStanowiskiemTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbStanowisko = new System.Windows.Forms.ComboBox();
            this.dtpZatrudnienie = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracownicy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPracownicyZeStanowiskiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Pink;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(13, 614);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 52);
            this.button2.TabIndex = 63;
            this.button2.Text = "Edytuj";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txbNazwisko
            // 
            this.txbNazwisko.BackColor = System.Drawing.Color.Pink;
            this.txbNazwisko.Location = new System.Drawing.Point(233, 225);
            this.txbNazwisko.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNazwisko.Name = "txbNazwisko";
            this.txbNazwisko.Size = new System.Drawing.Size(291, 26);
            this.txbNazwisko.TabIndex = 59;
            // 
            // dgvPracownicy
            // 
            this.dgvPracownicy.AutoGenerateColumns = false;
            this.dgvPracownicy.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvPracownicy.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPracownicy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPracownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPracownicy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPracownikaDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.dataZatrudnieniaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.nazwaStanowiskaDataGridViewTextBoxColumn});
            this.dgvPracownicy.DataSource = this.vwPracownicyZeStanowiskiemBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.999999F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPracownicy.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPracownicy.GridColor = System.Drawing.Color.Crimson;
            this.dgvPracownicy.Location = new System.Drawing.Point(557, 114);
            this.dgvPracownicy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPracownicy.Name = "dgvPracownicy";
            this.dgvPracownicy.RowHeadersWidth = 62;
            this.dgvPracownicy.RowTemplate.Height = 28;
            this.dgvPracownicy.Size = new System.Drawing.Size(1040, 552);
            this.dgvPracownicy.TabIndex = 57;
            // 
            // iDPracownikaDataGridViewTextBoxColumn
            // 
            this.iDPracownikaDataGridViewTextBoxColumn.DataPropertyName = "IDPracownika";
            this.iDPracownikaDataGridViewTextBoxColumn.HeaderText = "IDPracownika";
            this.iDPracownikaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDPracownikaDataGridViewTextBoxColumn.Name = "iDPracownikaDataGridViewTextBoxColumn";
            this.iDPracownikaDataGridViewTextBoxColumn.Width = 150;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.Width = 150;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataZatrudnieniaDataGridViewTextBoxColumn
            // 
            this.dataZatrudnieniaDataGridViewTextBoxColumn.DataPropertyName = "DataZatrudnienia";
            this.dataZatrudnieniaDataGridViewTextBoxColumn.HeaderText = "DataZatrudnienia";
            this.dataZatrudnieniaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataZatrudnieniaDataGridViewTextBoxColumn.Name = "dataZatrudnieniaDataGridViewTextBoxColumn";
            this.dataZatrudnieniaDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Width = 150;
            // 
            // nazwaStanowiskaDataGridViewTextBoxColumn
            // 
            this.nazwaStanowiskaDataGridViewTextBoxColumn.DataPropertyName = "NazwaStanowiska";
            this.nazwaStanowiskaDataGridViewTextBoxColumn.HeaderText = "NazwaStanowiska";
            this.nazwaStanowiskaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nazwaStanowiskaDataGridViewTextBoxColumn.Name = "nazwaStanowiskaDataGridViewTextBoxColumn";
            this.nazwaStanowiskaDataGridViewTextBoxColumn.Width = 150;
            // 
            // vwPracownicyZeStanowiskiemBindingSource
            // 
            this.vwPracownicyZeStanowiskiemBindingSource.DataMember = "vw_PracownicyZeStanowiskiem";
            this.vwPracownicyZeStanowiskiemBindingSource.DataSource = this.ksiegarniaDataSet3;
            // 
            // ksiegarniaDataSet3
            // 
            this.ksiegarniaDataSet3.DataSetName = "KsiegarniaDataSet3";
            this.ksiegarniaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Pink;
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodaj.Location = new System.Drawing.Point(289, 614);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(235, 52);
            this.btnDodaj.TabIndex = 56;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Pink;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(327, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(376, 39);
            this.label6.TabIndex = 55;
            this.label6.Text = "Dodaj/Edytuj Personel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Pink;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(23, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 29);
            this.label5.TabIndex = 54;
            this.label5.Text = "Numer telefonu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Pink;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(91, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 53;
            this.label4.Text = "Email";
            // 
            // txbTelefon
            // 
            this.txbTelefon.BackColor = System.Drawing.Color.Pink;
            this.txbTelefon.Location = new System.Drawing.Point(233, 420);
            this.txbTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTelefon.Name = "txbTelefon";
            this.txbTelefon.Size = new System.Drawing.Size(291, 26);
            this.txbTelefon.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "Data  zatrudnienia";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.Pink;
            this.txbEmail.Location = new System.Drawing.Point(233, 356);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(291, 26);
            this.txbEmail.TabIndex = 50;
            // 
            // txbImie
            // 
            this.txbImie.BackColor = System.Drawing.Color.Pink;
            this.txbImie.Location = new System.Drawing.Point(233, 114);
            this.txbImie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbImie.Name = "txbImie";
            this.txbImie.Size = new System.Drawing.Size(291, 26);
            this.txbImie.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1419, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(107, 48);
            this.button1.TabIndex = 65;
            this.button1.Text = "Wróć";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Pink;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1531, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 48);
            this.btnClose.TabIndex = 64;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // vw_PracownicyZeStanowiskiemTableAdapter
            // 
            this.vw_PracownicyZeStanowiskiemTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(56, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 66;
            this.label2.Text = "Imię";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Pink;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(56, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 67;
            this.label3.Text = "Nazwisko";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Pink;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(23, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 29);
            this.label7.TabIndex = 68;
            this.label7.Text = "Stanowisko";
            // 
            // cmbStanowisko
            // 
            this.cmbStanowisko.BackColor = System.Drawing.Color.Pink;
            this.cmbStanowisko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStanowisko.FormattingEnabled = true;
            this.cmbStanowisko.Location = new System.Drawing.Point(233, 485);
            this.cmbStanowisko.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStanowisko.Name = "cmbStanowisko";
            this.cmbStanowisko.Size = new System.Drawing.Size(291, 28);
            this.cmbStanowisko.TabIndex = 69;
            // 
            // dtpZatrudnienie
            // 
            this.dtpZatrudnienie.Location = new System.Drawing.Point(268, 293);
            this.dtpZatrudnienie.Name = "dtpZatrudnienie";
            this.dtpZatrudnienie.Size = new System.Drawing.Size(200, 26);
            this.dtpZatrudnienie.TabIndex = 70;
            // 
            // DodajPracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Ksiegarnia2.Properties.Resources.v807_mynt_03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1611, 702);
            this.ControlBox = false;
            this.Controls.Add(this.dtpZatrudnienie);
            this.Controls.Add(this.cmbStanowisko);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txbNazwisko);
            this.Controls.Add(this.dgvPracownicy);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbTelefon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbImie);
            this.Name = "DodajPracownika";
            this.Text = "DodajPracownika";
            this.Load += new System.EventHandler(this.DodajPracownika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracownicy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPracownicyZeStanowiskiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txbNazwisko;
        private System.Windows.Forms.DataGridView dgvPracownicy;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTelefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbImie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
        private KsiegarniaDataSet3 ksiegarniaDataSet3;
        private System.Windows.Forms.BindingSource vwPracownicyZeStanowiskiemBindingSource;
        private KsiegarniaDataSet3TableAdapters.vw_PracownicyZeStanowiskiemTableAdapter vw_PracownicyZeStanowiskiemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPracownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataZatrudnieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaStanowiskaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbStanowisko;
        private System.Windows.Forms.DateTimePicker dtpZatrudnienie;
    }
}