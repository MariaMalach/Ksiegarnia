namespace Ksiegarnia
{
    partial class Zasoby
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
            this.txbWyszukiwarka = new System.Windows.Forms.TextBox();
            this.cmbKategorie = new System.Windows.Forms.ComboBox();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvZasoby = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ksiegarniaDataSet = new Ksiegarnia2.KsiegarniaDataSet();
            this.zasobyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zasobyTableAdapter = new Ksiegarnia2.KsiegarniaDataSetTableAdapters.ZasobyTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUtworzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZasoby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zasobyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txbWyszukiwarka
            // 
            this.txbWyszukiwarka.BackColor = System.Drawing.Color.Pink;
            this.txbWyszukiwarka.Location = new System.Drawing.Point(230, 48);
            this.txbWyszukiwarka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbWyszukiwarka.Name = "txbWyszukiwarka";
            this.txbWyszukiwarka.Size = new System.Drawing.Size(291, 26);
            this.txbWyszukiwarka.TabIndex = 2;
            // 
            // cmbKategorie
            // 
            this.cmbKategorie.BackColor = System.Drawing.Color.Pink;
            this.cmbKategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKategorie.FormattingEnabled = true;
            this.cmbKategorie.Location = new System.Drawing.Point(230, 101);
            this.cmbKategorie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKategorie.Name = "cmbKategorie";
            this.cmbKategorie.Size = new System.Drawing.Size(291, 28);
            this.cmbKategorie.TabIndex = 3;
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.BackColor = System.Drawing.Color.Pink;
            this.btnSzukaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSzukaj.Location = new System.Drawing.Point(556, 25);
            this.btnSzukaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(202, 49);
            this.btnSzukaj.TabIndex = 4;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = false;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Pink;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1202, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 48);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1089, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(107, 48);
            this.button1.TabIndex = 21;
            this.button1.Text = "Wróć";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Pink;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999998F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(556, 79);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 70);
            this.button2.TabIndex = 22;
            this.button2.Text = "wyszyść wyszukiwanie";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "wybierz kategorię:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(37, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "wyszukaj frazę:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Pink;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(298, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 36;
            this.label3.Text = "ZASOBY";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Pink;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(1066, 79);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 51);
            this.button3.TabIndex = 37;
            this.button3.Text = "Dodaj zasób";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.iloscDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataUtworzeniaDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn5});
            this.dgvZasoby.DataSource = this.zasobyBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.999999F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZasoby.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvZasoby.GridColor = System.Drawing.Color.Crimson;
            this.dgvZasoby.Location = new System.Drawing.Point(25, 187);
            this.dgvZasoby.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvZasoby.Name = "dgvZasoby";
            this.dgvZasoby.RowHeadersWidth = 62;
            this.dgvZasoby.RowTemplate.Height = 28;
            this.dgvZasoby.Size = new System.Drawing.Size(1225, 474);
            this.dgvZasoby.TabIndex = 41;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.ksiegarniaDataSet;
            this.bindingSource1.Position = 0;
            // 
            // ksiegarniaDataSet
            // 
            this.ksiegarniaDataSet.DataSetName = "KsiegarniaDataSet";
            this.ksiegarniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zasobyBindingSource
            // 
            this.zasobyBindingSource.DataMember = "Zasoby";
            this.zasobyBindingSource.DataSource = this.bindingSource1;
            // 
            // zasobyTableAdapter
            // 
            this.zasobyTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cena";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cena";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // Zasoby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ksiegarnia2.Properties.Resources.v807_mynt_03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1278, 672);
            this.ControlBox = false;
            this.Controls.Add(this.dgvZasoby);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.cmbKategorie);
            this.Controls.Add(this.txbWyszukiwarka);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Zasoby";
            this.Text = "Zasoby";
            this.Load += new System.EventHandler(this.Zasoby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZasoby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zasobyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbWyszukiwarka;
        private System.Windows.Forms.ComboBox cmbKategorie;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorzyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokWydaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wydawnictwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvZasoby;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Ksiegarnia2.KsiegarniaDataSet ksiegarniaDataSet;
        private System.Windows.Forms.BindingSource zasobyBindingSource;
        private Ksiegarnia2.KsiegarniaDataSetTableAdapters.ZasobyTableAdapter zasobyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUtworzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}