namespace Ksiegarnia.Forms
{
    partial class Transakcje
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.cmbKategorie = new System.Windows.Forms.ComboBox();
            this.txbWyszukiwarka = new System.Windows.Forms.TextBox();
            this.dgvTransakcje = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailPracownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historiaZakupowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ksiegarniaDataSet2 = new Ksiegarnia2.KsiegarniaDataSet2();
            this.historiaZakupowTableAdapter = new Ksiegarnia2.KsiegarniaDataSet2TableAdapters.HistoriaZakupowTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransakcje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiaZakupowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Pink;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(353, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 47;
            this.label3.Text = "TRANSAKCJE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(80, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 46;
            this.label2.Text = "wyszukaj frazę:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(80, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "wybierz kategorię:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Pink;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999998F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(628, 112);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 70);
            this.button2.TabIndex = 44;
            this.button2.Text = "wyszyść wyszukiwanie";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1127, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(107, 48);
            this.button1.TabIndex = 43;
            this.button1.Text = "Wróć";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Pink;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1240, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 48);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.BackColor = System.Drawing.Color.Pink;
            this.btnSzukaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSzukaj.Location = new System.Drawing.Point(628, 58);
            this.btnSzukaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(202, 49);
            this.btnSzukaj.TabIndex = 41;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = false;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // cmbKategorie
            // 
            this.cmbKategorie.BackColor = System.Drawing.Color.Pink;
            this.cmbKategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKategorie.FormattingEnabled = true;
            this.cmbKategorie.Location = new System.Drawing.Point(312, 134);
            this.cmbKategorie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKategorie.Name = "cmbKategorie";
            this.cmbKategorie.Size = new System.Drawing.Size(291, 28);
            this.cmbKategorie.TabIndex = 40;
            // 
            // txbWyszukiwarka
            // 
            this.txbWyszukiwarka.BackColor = System.Drawing.Color.Pink;
            this.txbWyszukiwarka.Location = new System.Drawing.Point(312, 81);
            this.txbWyszukiwarka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbWyszukiwarka.Name = "txbWyszukiwarka";
            this.txbWyszukiwarka.Size = new System.Drawing.Size(291, 26);
            this.txbWyszukiwarka.TabIndex = 39;
            // 
            // dgvTransakcje
            // 
            this.dgvTransakcje.AutoGenerateColumns = false;
            this.dgvTransakcje.BackgroundColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransakcje.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransakcje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransakcje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.emailPracownikaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn});
            this.dgvTransakcje.DataSource = this.historiaZakupowBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.999999F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransakcje.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransakcje.GridColor = System.Drawing.Color.Crimson;
            this.dgvTransakcje.Location = new System.Drawing.Point(5, 212);
            this.dgvTransakcje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTransakcje.Name = "dgvTransakcje";
            this.dgvTransakcje.RowHeadersWidth = 62;
            this.dgvTransakcje.RowTemplate.Height = 28;
            this.dgvTransakcje.Size = new System.Drawing.Size(1303, 479);
            this.dgvTransakcje.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDZakupu";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDZakupu";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDZasobu";
            this.dataGridViewTextBoxColumn2.HeaderText = "IDZasobu";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DataZakupu";
            this.dataGridViewTextBoxColumn3.HeaderText = "DataZakupu";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ilosc";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ilosc";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // emailPracownikaDataGridViewTextBoxColumn
            // 
            this.emailPracownikaDataGridViewTextBoxColumn.DataPropertyName = "emailPracownika";
            this.emailPracownikaDataGridViewTextBoxColumn.HeaderText = "emailPracownika";
            this.emailPracownikaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailPracownikaDataGridViewTextBoxColumn.Name = "emailPracownikaDataGridViewTextBoxColumn";
            this.emailPracownikaDataGridViewTextBoxColumn.Width = 150;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.Width = 150;
            // 
            // historiaZakupowBindingSource
            // 
            this.historiaZakupowBindingSource.DataMember = "HistoriaZakupow";
            this.historiaZakupowBindingSource.DataSource = this.ksiegarniaDataSet2;
            // 
            // ksiegarniaDataSet2
            // 
            this.ksiegarniaDataSet2.DataSetName = "KsiegarniaDataSet2";
            this.ksiegarniaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historiaZakupowTableAdapter
            // 
            this.historiaZakupowTableAdapter.ClearBeforeFill = true;
            // 
            // Transakcje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Ksiegarnia2.Properties.Resources.v807_mynt_03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1407, 702);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.cmbKategorie);
            this.Controls.Add(this.txbWyszukiwarka);
            this.Controls.Add(this.dgvTransakcje);
            this.Name = "Transakcje";
            this.Text = "HistoriaZakupow";
            this.Load += new System.EventHandler(this.HistoriaZakupow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransakcje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiaZakupowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZakupuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZasobuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPracownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataZakupuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCenyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.ComboBox cmbKategorie;
        private System.Windows.Forms.TextBox txbWyszukiwarka;
        private System.Windows.Forms.DataGridView dgvTransakcje;
        private Ksiegarnia2.KsiegarniaDataSet2 ksiegarniaDataSet2;
        private System.Windows.Forms.BindingSource historiaZakupowBindingSource;
        private Ksiegarnia2.KsiegarniaDataSet2TableAdapters.HistoriaZakupowTableAdapter historiaZakupowTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailPracownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
    }
}