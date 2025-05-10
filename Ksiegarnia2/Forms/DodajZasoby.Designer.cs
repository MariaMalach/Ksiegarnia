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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajZasoby));
            this.label2 = new System.Windows.Forms.Label();
            this.txbTytul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textRokWydania = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textIlosc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxKatergoria = new System.Windows.Forms.ComboBox();
            this.comboBoxWydawnictwo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ksiegarniaDataSet5 = new Ksiegarnia2.KsiegarniaDataSet5();
            this.zasobyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zasobyTableAdapter = new Ksiegarnia2.KsiegarniaDataSet5TableAdapters.ZasobyTableAdapter();
            this.cenyTableAdapter = new Ksiegarnia2.KsiegarniaDataSet5TableAdapters.CenyTableAdapter();
            this.zasoby_AutorzyTableAdapter = new Ksiegarnia2.KsiegarniaDataSet5TableAdapters.Zasoby_AutorzyTableAdapter();
            this.vwZasobyPelneBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.ksiegarniaDataSet = new Ksiegarnia2.KsiegarniaDataSet();
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zasobyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwZasobyPelneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZasoby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwZasobyPelneBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tytuł";
            // 
            // txbTytul
            // 
            this.txbTytul.BackColor = System.Drawing.Color.Pink;
            this.txbTytul.Location = new System.Drawing.Point(202, 87);
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
            this.label1.Location = new System.Drawing.Point(30, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Rok wydania";
            // 
            // textRokWydania
            // 
            this.textRokWydania.BackColor = System.Drawing.Color.Pink;
            this.textRokWydania.Location = new System.Drawing.Point(202, 153);
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
            this.label3.Location = new System.Drawing.Point(30, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ilość";
            // 
            // textIlosc
            // 
            this.textIlosc.BackColor = System.Drawing.Color.Pink;
            this.textIlosc.Location = new System.Drawing.Point(202, 211);
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
            this.label4.Location = new System.Drawing.Point(30, 272);
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
            this.label5.Location = new System.Drawing.Point(30, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Wydwanictwo";
            // 
            // comboBoxKatergoria
            // 
            this.comboBoxKatergoria.FormattingEnabled = true;
            this.comboBoxKatergoria.Location = new System.Drawing.Point(202, 273);
            this.comboBoxKatergoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxKatergoria.Name = "comboBoxKatergoria";
            this.comboBoxKatergoria.Size = new System.Drawing.Size(253, 24);
            this.comboBoxKatergoria.TabIndex = 33;
            this.comboBoxKatergoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxKatergoria_SelectedIndexChanged);
            // 
            // comboBoxWydawnictwo
            // 
            this.comboBoxWydawnictwo.FormattingEnabled = true;
            this.comboBoxWydawnictwo.Location = new System.Drawing.Point(208, 326);
            this.comboBoxWydawnictwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxWydawnictwo.Name = "comboBoxWydawnictwo";
            this.comboBoxWydawnictwo.Size = new System.Drawing.Size(253, 24);
            this.comboBoxWydawnictwo.TabIndex = 34;
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
            this.btnDodaj.Location = new System.Drawing.Point(227, 404);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(209, 30);
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
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.ksiegarniaDataSet5;
            this.bindingSource1.Position = 0;
            // 
            // ksiegarniaDataSet5
            // 
            this.ksiegarniaDataSet5.DataSetName = "KsiegarniaDataSet5";
            this.ksiegarniaDataSet5.Locale = new System.Globalization.CultureInfo("pl");
            this.ksiegarniaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // cenyTableAdapter
            // 
            this.cenyTableAdapter.ClearBeforeFill = true;
            // 
            // zasoby_AutorzyTableAdapter
            // 
            this.zasoby_AutorzyTableAdapter.ClearBeforeFill = true;
            // 
            // vwZasobyPelneBindingSource
            // 
            this.vwZasobyPelneBindingSource.DataSource = this.bindingSource1;
            this.vwZasobyPelneBindingSource.Position = 0;
            // 
            // vw_Zasoby_PelneTableAdapter
            // 
            this.vw_Zasoby_PelneTableAdapter.ClearBeforeFill = true;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.999999F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZasoby.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvZasoby.GridColor = System.Drawing.Color.Crimson;
            this.dgvZasoby.Location = new System.Drawing.Point(496, 87);
            this.dgvZasoby.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvZasoby.Name = "dgvZasoby";
            this.dgvZasoby.RowHeadersWidth = 62;
            this.dgvZasoby.RowTemplate.Height = 28;
            this.dgvZasoby.Size = new System.Drawing.Size(926, 312);
            this.dgvZasoby.TabIndex = 40;
            // 
            // tytulDataGridViewTextBoxColumn
            // 
            this.tytulDataGridViewTextBoxColumn.DataPropertyName = "Tytul";
            this.tytulDataGridViewTextBoxColumn.HeaderText = "Tytul";
            this.tytulDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tytulDataGridViewTextBoxColumn.Name = "tytulDataGridViewTextBoxColumn";
            this.tytulDataGridViewTextBoxColumn.Width = 125;
            // 
            // rokWydaniaDataGridViewTextBoxColumn
            // 
            this.rokWydaniaDataGridViewTextBoxColumn.DataPropertyName = "RokWydania";
            this.rokWydaniaDataGridViewTextBoxColumn.HeaderText = "RokWydania";
            this.rokWydaniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rokWydaniaDataGridViewTextBoxColumn.Name = "rokWydaniaDataGridViewTextBoxColumn";
            this.rokWydaniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // iloscDataGridViewTextBoxColumn
            // 
            this.iloscDataGridViewTextBoxColumn.DataPropertyName = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.HeaderText = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iloscDataGridViewTextBoxColumn.Name = "iloscDataGridViewTextBoxColumn";
            this.iloscDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazwaKategoriiDataGridViewTextBoxColumn
            // 
            this.nazwaKategoriiDataGridViewTextBoxColumn.DataPropertyName = "NazwaKategorii";
            this.nazwaKategoriiDataGridViewTextBoxColumn.HeaderText = "NazwaKategorii";
            this.nazwaKategoriiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazwaKategoriiDataGridViewTextBoxColumn.Name = "nazwaKategoriiDataGridViewTextBoxColumn";
            this.nazwaKategoriiDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazwaWydawnictwaDataGridViewTextBoxColumn
            // 
            this.nazwaWydawnictwaDataGridViewTextBoxColumn.DataPropertyName = "NazwaWydawnictwa";
            this.nazwaWydawnictwaDataGridViewTextBoxColumn.HeaderText = "NazwaWydawnictwa";
            this.nazwaWydawnictwaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazwaWydawnictwaDataGridViewTextBoxColumn.Name = "nazwaWydawnictwaDataGridViewTextBoxColumn";
            this.nazwaWydawnictwaDataGridViewTextBoxColumn.Width = 125;
            // 
            // autorzyDataGridViewTextBoxColumn
            // 
            this.autorzyDataGridViewTextBoxColumn.DataPropertyName = "Autorzy";
            this.autorzyDataGridViewTextBoxColumn.HeaderText = "Autorzy";
            this.autorzyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.autorzyDataGridViewTextBoxColumn.Name = "autorzyDataGridViewTextBoxColumn";
            this.autorzyDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataUtworzeniaDataGridViewTextBoxColumn
            // 
            this.dataUtworzeniaDataGridViewTextBoxColumn.DataPropertyName = "DataUtworzenia";
            this.dataUtworzeniaDataGridViewTextBoxColumn.HeaderText = "DataUtworzenia";
            this.dataUtworzeniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataUtworzeniaDataGridViewTextBoxColumn.Name = "dataUtworzeniaDataGridViewTextBoxColumn";
            this.dataUtworzeniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // vwZasobyPelneBindingSource1
            // 
            this.vwZasobyPelneBindingSource1.DataMember = "vw_Zasoby_Pelne";
            this.vwZasobyPelneBindingSource1.DataSource = this.bindingSource1;
            // 
            // ksiegarniaDataSet
            // 
            this.ksiegarniaDataSet.DataSetName = "KsiegarniaDataSet";
            this.ksiegarniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 451);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1432, 31);
            this.bindingNavigator1.TabIndex = 41;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 28);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Pozycja";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(45, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // DodajZasoby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ksiegarnia2.Properties.Resources.v807_mynt_03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1432, 482);
            this.ControlBox = false;
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dgvZasoby);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxWydawnictwo);
            this.Controls.Add(this.comboBoxKatergoria);
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
            this.Load += new System.EventHandler(this.DodajZasoby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zasobyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwZasobyPelneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZasoby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwZasobyPelneBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBoxKatergoria;
        private System.Windows.Forms.ComboBox comboBoxWydawnictwo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource bindingSource1;
        private KsiegarniaDataSet5 ksiegarniaDataSet5;
        private System.Windows.Forms.BindingSource zasobyBindingSource;
        private KsiegarniaDataSet5TableAdapters.ZasobyTableAdapter zasobyTableAdapter;
        private KsiegarniaDataSet5TableAdapters.CenyTableAdapter cenyTableAdapter;
        private KsiegarniaDataSet5TableAdapters.Zasoby_AutorzyTableAdapter zasoby_AutorzyTableAdapter;
        private System.Windows.Forms.BindingSource vwZasobyPelneBindingSource;
        private KsiegarniaDataSet5TableAdapters.vw_Zasoby_PelneTableAdapter vw_Zasoby_PelneTableAdapter;
        private System.Windows.Forms.DataGridView dgvZasoby;
        private KsiegarniaDataSet ksiegarniaDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokWydaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaKategoriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaWydawnictwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorzyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUtworzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vwZasobyPelneBindingSource1;
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
    }
}