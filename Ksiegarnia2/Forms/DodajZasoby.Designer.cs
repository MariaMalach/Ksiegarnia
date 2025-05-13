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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUtworzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZasobyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ksiegarniaDataSet = new Ksiegarnia2.KsiegarniaDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAutorzy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxWydawnictwo = new System.Windows.Forms.TextBox();
            this.textBoxKategoria = new System.Windows.Forms.TextBox();
            this.buttonEdycja = new System.Windows.Forms.Button();
            this.zasobyTableAdapter = new Ksiegarnia2.KsiegarniaDataSetTableAdapters.ZasobyTableAdapter();
            this.zasoby_AutorzyTableAdapter1 = new Ksiegarnia2.KsiegarniaDataSet2TableAdapters.Zasoby_AutorzyTableAdapter();
            this.ksiegarniaDataSet1 = new Ksiegarnia2.KsiegarniaDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZasoby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZasobyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tytuł";
            // 
            // txbTytul
            // 
            this.txbTytul.BackColor = System.Drawing.Color.Pink;
            this.txbTytul.Location = new System.Drawing.Point(208, 87);
            this.txbTytul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTytul.Name = "txbTytul";
            this.txbTytul.Size = new System.Drawing.Size(259, 22);
            this.txbTytul.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Rok wydania";
            // 
            // textRokWydania
            // 
            this.textRokWydania.BackColor = System.Drawing.Color.Pink;
            this.textRokWydania.Location = new System.Drawing.Point(208, 281);
            this.textRokWydania.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textRokWydania.Name = "textRokWydania";
            this.textRokWydania.Size = new System.Drawing.Size(259, 22);
            this.textRokWydania.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Pink;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(27, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ilość";
            // 
            // textIlosc
            // 
            this.textIlosc.BackColor = System.Drawing.Color.Pink;
            this.textIlosc.Location = new System.Drawing.Point(208, 332);
            this.textIlosc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textIlosc.Name = "textIlosc";
            this.textIlosc.Size = new System.Drawing.Size(259, 22);
            this.textIlosc.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Pink;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(27, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Kategoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Pink;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(27, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Wydwanictwo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Pink;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(292, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 33);
            this.label6.TabIndex = 36;
            this.label6.Text = "Dodaj zasób";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Pink;
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodaj.Location = new System.Drawing.Point(258, 487);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(209, 42);
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
            this.button1.Location = new System.Drawing.Point(1260, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(95, 38);
            this.button1.TabIndex = 39;
            this.button1.Text = "Wróć";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Pink;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1360, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 38);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZasoby.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvZasoby.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZasoby.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.iloscDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataUtworzeniaDataGridViewTextBoxColumn});
            this.dgvZasoby.DataSource = this.ZasobyBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.999999F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZasoby.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvZasoby.GridColor = System.Drawing.Color.Crimson;
            this.dgvZasoby.Location = new System.Drawing.Point(496, 87);
            this.dgvZasoby.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvZasoby.Name = "dgvZasoby";
            this.dgvZasoby.RowHeadersWidth = 62;
            this.dgvZasoby.RowTemplate.Height = 28;
            this.dgvZasoby.Size = new System.Drawing.Size(924, 442);
            this.dgvZasoby.TabIndex = 40;
            this.dgvZasoby.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZasoby_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tytul";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tytul";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RokWydania";
            this.dataGridViewTextBoxColumn2.HeaderText = "RokWydania";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // iloscDataGridViewTextBoxColumn
            // 
            this.iloscDataGridViewTextBoxColumn.DataPropertyName = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.HeaderText = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iloscDataGridViewTextBoxColumn.Name = "iloscDataGridViewTextBoxColumn";
            this.iloscDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Kategoria";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kategoria";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Wydawnictwo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Wydawnictwo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataUtworzeniaDataGridViewTextBoxColumn
            // 
            this.dataUtworzeniaDataGridViewTextBoxColumn.DataPropertyName = "DataUtworzenia";
            this.dataUtworzeniaDataGridViewTextBoxColumn.HeaderText = "DataUtworzenia";
            this.dataUtworzeniaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataUtworzeniaDataGridViewTextBoxColumn.Name = "dataUtworzeniaDataGridViewTextBoxColumn";
            this.dataUtworzeniaDataGridViewTextBoxColumn.Width = 150;
            // 
            // ZasobyBindingSource
            // 
            this.ZasobyBindingSource.DataMember = "Zasoby";
            this.ZasobyBindingSource.DataSource = this.ksiegarniaDataSet;
            // 
            // ksiegarniaDataSet
            // 
            this.ksiegarniaDataSet.DataSetName = "KsiegarniaDataSet";
            this.ksiegarniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Pink;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(30, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 42;
            this.label7.Text = "Cena";
            // 
            // textBoxCena
            // 
            this.textBoxCena.BackColor = System.Drawing.Color.Pink;
            this.textBoxCena.Location = new System.Drawing.Point(208, 229);
            this.textBoxCena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(259, 22);
            this.textBoxCena.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Pink;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(30, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 44;
            this.label8.Text = "Autorzy";
            // 
            // textBoxAutorzy
            // 
            this.textBoxAutorzy.BackColor = System.Drawing.Color.Pink;
            this.textBoxAutorzy.Location = new System.Drawing.Point(208, 176);
            this.textBoxAutorzy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAutorzy.Name = "textBoxAutorzy";
            this.textBoxAutorzy.Size = new System.Drawing.Size(259, 22);
            this.textBoxAutorzy.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Pink;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(32, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(401, 18);
            this.label9.TabIndex = 45;
            this.label9.Text = "Jeśli pozycja ma wiecej niż jednego autora wypiisz ich z \" , \"";
            // 
            // textBoxWydawnictwo
            // 
            this.textBoxWydawnictwo.BackColor = System.Drawing.Color.Pink;
            this.textBoxWydawnictwo.Location = new System.Drawing.Point(208, 432);
            this.textBoxWydawnictwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxWydawnictwo.Name = "textBoxWydawnictwo";
            this.textBoxWydawnictwo.Size = new System.Drawing.Size(259, 22);
            this.textBoxWydawnictwo.TabIndex = 47;
            // 
            // textBoxKategoria
            // 
            this.textBoxKategoria.BackColor = System.Drawing.Color.Pink;
            this.textBoxKategoria.Location = new System.Drawing.Point(208, 381);
            this.textBoxKategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKategoria.Name = "textBoxKategoria";
            this.textBoxKategoria.Size = new System.Drawing.Size(259, 22);
            this.textBoxKategoria.TabIndex = 46;
            // 
            // buttonEdycja
            // 
            this.buttonEdycja.BackColor = System.Drawing.Color.Pink;
            this.buttonEdycja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonEdycja.Location = new System.Drawing.Point(12, 487);
            this.buttonEdycja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdycja.Name = "buttonEdycja";
            this.buttonEdycja.Size = new System.Drawing.Size(209, 42);
            this.buttonEdycja.TabIndex = 48;
            this.buttonEdycja.Text = "Edytuj";
            this.buttonEdycja.UseVisualStyleBackColor = false;
            this.buttonEdycja.Click += new System.EventHandler(this.button2_Click);
            // 
            // zasobyTableAdapter
            // 
            this.zasobyTableAdapter.ClearBeforeFill = true;
            // 
            // zasoby_AutorzyTableAdapter1
            // 
            this.zasoby_AutorzyTableAdapter1.ClearBeforeFill = true;
            // 
            // ksiegarniaDataSet1
            // 
            this.ksiegarniaDataSet1.DataSetName = "KsiegarniaDataSet";
            this.ksiegarniaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DodajZasoby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ksiegarnia2.Properties.Resources.v807_mynt_03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1432, 562);
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
            ((System.ComponentModel.ISupportInitialize)(this.ZasobyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet1)).EndInit();
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
        private System.Windows.Forms.BindingSource bindingSource1;
        
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
        private KsiegarniaDataSet ksiegarniaDataSet;
        private System.Windows.Forms.BindingSource ZasobyBindingSource;
        private KsiegarniaDataSetTableAdapters.ZasobyTableAdapter zasobyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUtworzeniaDataGridViewTextBoxColumn;
        private KsiegarniaDataSet2TableAdapters.Zasoby_AutorzyTableAdapter zasoby_AutorzyTableAdapter1;
        private KsiegarniaDataSet ksiegarniaDataSet1;
    }
}