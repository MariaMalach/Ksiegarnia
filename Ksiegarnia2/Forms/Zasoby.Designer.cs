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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zasoby));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ksiegarniaDataSet5 = new Ksiegarnia2.KsiegarniaDataSet5();
            this.ksiegarniaDataSet = new Ksiegarnia2.KsiegarniaDataSet();
            this.zasobyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_Zasoby_PelneTableAdapter = new Ksiegarnia2.KsiegarniaDataSet5TableAdapters.vw_Zasoby_PelneTableAdapter();
            this.dgvZasoby = new System.Windows.Forms.DataGridView();
            this.tytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokWydaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaKategoriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaWydawnictwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorzyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUtworzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwZasobyPelneBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zasobyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZasoby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwZasobyPelneBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = false;
            this.bindingSource1.DataSource = this.ksiegarniaDataSet5;
            this.bindingSource1.Position = 0;
            // 
            // ksiegarniaDataSet5
            // 
            this.ksiegarniaDataSet5.DataSetName = "KsiegarniaDataSet5";
            this.ksiegarniaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // vw_Zasoby_PelneTableAdapter
            // 
            this.vw_Zasoby_PelneTableAdapter.ClearBeforeFill = true;
            // 
            // dgvZasoby
            // 
            this.dgvZasoby.AutoGenerateColumns = false;
            this.dgvZasoby.BackgroundColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZasoby.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZasoby.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZasoby.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tytulDataGridViewTextBoxColumn,
            this.rokWydaniaDataGridViewTextBoxColumn,
            this.iloscDataGridViewTextBoxColumn,
            this.nazwaKategoriiDataGridViewTextBoxColumn,
            this.nazwaWydawnictwaDataGridViewTextBoxColumn,
            this.autorzyDataGridViewTextBoxColumn,
            this.dataUtworzeniaDataGridViewTextBoxColumn});
            this.dgvZasoby.DataSource = this.vwZasobyPelneBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 9.999999F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZasoby.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvZasoby.GridColor = System.Drawing.Color.Crimson;
            this.dgvZasoby.Location = new System.Drawing.Point(0, 141);
            this.dgvZasoby.Name = "dgvZasoby";
            this.dgvZasoby.RowHeadersWidth = 62;
            this.dgvZasoby.RowTemplate.Height = 28;
            this.dgvZasoby.Size = new System.Drawing.Size(1269, 394);
            this.dgvZasoby.TabIndex = 0;
            // 
            // tytulDataGridViewTextBoxColumn
            // 
            this.tytulDataGridViewTextBoxColumn.DataPropertyName = "Tytul";
            this.tytulDataGridViewTextBoxColumn.HeaderText = "Tytul";
            this.tytulDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tytulDataGridViewTextBoxColumn.Name = "tytulDataGridViewTextBoxColumn";
            this.tytulDataGridViewTextBoxColumn.Width = 150;
            // 
            // rokWydaniaDataGridViewTextBoxColumn
            // 
            this.rokWydaniaDataGridViewTextBoxColumn.DataPropertyName = "RokWydania";
            this.rokWydaniaDataGridViewTextBoxColumn.HeaderText = "RokWydania";
            this.rokWydaniaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rokWydaniaDataGridViewTextBoxColumn.Name = "rokWydaniaDataGridViewTextBoxColumn";
            this.rokWydaniaDataGridViewTextBoxColumn.Width = 150;
            // 
            // iloscDataGridViewTextBoxColumn
            // 
            this.iloscDataGridViewTextBoxColumn.DataPropertyName = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.HeaderText = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iloscDataGridViewTextBoxColumn.Name = "iloscDataGridViewTextBoxColumn";
            this.iloscDataGridViewTextBoxColumn.Width = 150;
            // 
            // nazwaKategoriiDataGridViewTextBoxColumn
            // 
            this.nazwaKategoriiDataGridViewTextBoxColumn.DataPropertyName = "NazwaKategorii";
            this.nazwaKategoriiDataGridViewTextBoxColumn.HeaderText = "NazwaKategorii";
            this.nazwaKategoriiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nazwaKategoriiDataGridViewTextBoxColumn.Name = "nazwaKategoriiDataGridViewTextBoxColumn";
            this.nazwaKategoriiDataGridViewTextBoxColumn.Width = 150;
            // 
            // nazwaWydawnictwaDataGridViewTextBoxColumn
            // 
            this.nazwaWydawnictwaDataGridViewTextBoxColumn.DataPropertyName = "NazwaWydawnictwa";
            this.nazwaWydawnictwaDataGridViewTextBoxColumn.HeaderText = "NazwaWydawnictwa";
            this.nazwaWydawnictwaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nazwaWydawnictwaDataGridViewTextBoxColumn.Name = "nazwaWydawnictwaDataGridViewTextBoxColumn";
            this.nazwaWydawnictwaDataGridViewTextBoxColumn.Width = 150;
            // 
            // autorzyDataGridViewTextBoxColumn
            // 
            this.autorzyDataGridViewTextBoxColumn.DataPropertyName = "Autorzy";
            this.autorzyDataGridViewTextBoxColumn.HeaderText = "Autorzy";
            this.autorzyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.autorzyDataGridViewTextBoxColumn.Name = "autorzyDataGridViewTextBoxColumn";
            this.autorzyDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataUtworzeniaDataGridViewTextBoxColumn
            // 
            this.dataUtworzeniaDataGridViewTextBoxColumn.DataPropertyName = "DataUtworzenia";
            this.dataUtworzeniaDataGridViewTextBoxColumn.HeaderText = "DataUtworzenia";
            this.dataUtworzeniaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataUtworzeniaDataGridViewTextBoxColumn.Name = "dataUtworzeniaDataGridViewTextBoxColumn";
            this.dataUtworzeniaDataGridViewTextBoxColumn.Width = 150;
            // 
            // vwZasobyPelneBindingSource1
            // 
            this.vwZasobyPelneBindingSource1.DataMember = "vw_Zasoby_Pelne";
            this.vwZasobyPelneBindingSource1.DataSource = this.bindingSource1;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BackgroundImage = global::Ksiegarnia2.Properties.Resources.v807_mynt_03;
            this.bindingNavigator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bindingNavigator1.BindingSource = this.vwZasobyPelneBindingSource1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 538);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1278, 33);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Pozycja";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // txbWyszukiwarka
            // 
            this.txbWyszukiwarka.BackColor = System.Drawing.Color.Pink;
            this.txbWyszukiwarka.Location = new System.Drawing.Point(230, 48);
            this.txbWyszukiwarka.Name = "txbWyszukiwarka";
            this.txbWyszukiwarka.Size = new System.Drawing.Size(291, 26);
            this.txbWyszukiwarka.TabIndex = 2;
            // 
            // cmbKategorie
            // 
            this.cmbKategorie.BackColor = System.Drawing.Color.Pink;
            this.cmbKategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKategorie.FormattingEnabled = true;
            this.cmbKategorie.Location = new System.Drawing.Point(230, 98);
            this.cmbKategorie.Name = "cmbKategorie";
            this.cmbKategorie.Size = new System.Drawing.Size(291, 28);
            this.cmbKategorie.TabIndex = 3;
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.BackColor = System.Drawing.Color.Pink;
            this.btnSzukaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSzukaj.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnSzukaj.Location = new System.Drawing.Point(556, 25);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(203, 38);
            this.btnSzukaj.TabIndex = 4;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = false;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Pink;
            this.btnClose.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1202, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 48);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1089, -1);
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
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 8.999998F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(556, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 51);
            this.button2.TabIndex = 22;
            this.button2.Text = "wyszyść wyszukiwanie";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "wybierz kategorię:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(37, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "wyszukaj frazę:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Pink;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(298, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "ZASOBY";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Pink;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(1066, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 51);
            this.button3.TabIndex = 37;
            this.button3.Text = "Edytuj zasób";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Zasoby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ksiegarnia2.Properties.Resources.v807_mynt_03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1278, 571);
            this.ControlBox = false;
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
            this.Controls.Add(this.dgvZasoby);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "Zasoby";
            this.Text = "Zasoby";
            this.Load += new System.EventHandler(this.Zasoby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zasobyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZasoby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwZasobyPelneBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private Ksiegarnia2.KsiegarniaDataSet ksiegarniaDataSet;
        private System.Windows.Forms.BindingSource zasobyBindingSource;
        private Ksiegarnia2.KsiegarniaDataSet5 ksiegarniaDataSet5;
        private Ksiegarnia2.KsiegarniaDataSet5TableAdapters.vw_Zasoby_PelneTableAdapter vw_Zasoby_PelneTableAdapter;
        private System.Windows.Forms.DataGridView dgvZasoby;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox txbWyszukiwarka;
        private System.Windows.Forms.ComboBox cmbKategorie;
        private System.Windows.Forms.BindingSource vwZasobyPelneBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokWydaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaKategoriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaWydawnictwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorzyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUtworzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}