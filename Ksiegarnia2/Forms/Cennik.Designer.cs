namespace Ksiegarnia.Forms
{
    partial class Cennik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cennik));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.vwCenyRozszerzoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ksiegarniaDataSet7 = new Ksiegarnia2.KsiegarniaDataSet7();
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ksiegarniaDataSet4 = new Ksiegarnia2.KsiegarniaDataSet4();
            this.cenyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cenyTableAdapter = new Ksiegarnia2.KsiegarniaDataSet4TableAdapters.CenyTableAdapter();
            this.ksiegarniaDataSet6 = new Ksiegarnia2.KsiegarniaDataSet6();
            this.ksiegarniaDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwZasobyRozszerzoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_Zasoby_RozszerzoneTableAdapter = new Ksiegarnia2.KsiegarniaDataSet6TableAdapters.vw_Zasoby_RozszerzoneTableAdapter();
            this.ksiegarniaDataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_Ceny_RozszerzoneTableAdapter = new Ksiegarnia2.KsiegarniaDataSet7TableAdapters.vw_Ceny_RozszerzoneTableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvCennik = new System.Windows.Forms.DataGridView();
            this.nazwaZasobuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataZmianyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.cmbKategorieCeny = new System.Windows.Forms.ComboBox();
            this.txbWyszukiwarkaCeny = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwCenyRozszerzoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwZasobyRozszerzoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCennik)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.vwCenyRozszerzoneBindingSource;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(1269, 33);
            this.bindingNavigator1.TabIndex = 3;
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
            // vwCenyRozszerzoneBindingSource
            // 
            this.vwCenyRozszerzoneBindingSource.DataMember = "vw_Ceny_Rozszerzone";
            this.vwCenyRozszerzoneBindingSource.DataSource = this.ksiegarniaDataSet7;
            // 
            // ksiegarniaDataSet7
            // 
            this.ksiegarniaDataSet7.DataSetName = "KsiegarniaDataSet7";
            this.ksiegarniaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 33);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.ksiegarniaDataSet4;
            this.bindingSource1.Position = 0;
            // 
            // ksiegarniaDataSet4
            // 
            this.ksiegarniaDataSet4.DataSetName = "KsiegarniaDataSet4";
            this.ksiegarniaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cenyBindingSource
            // 
            this.cenyBindingSource.DataMember = "Ceny";
            this.cenyBindingSource.DataSource = this.bindingSource1;
            // 
            // cenyTableAdapter
            // 
            this.cenyTableAdapter.ClearBeforeFill = true;
            // 
            // ksiegarniaDataSet6
            // 
            this.ksiegarniaDataSet6.DataSetName = "KsiegarniaDataSet6";
            this.ksiegarniaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ksiegarniaDataSet6BindingSource
            // 
            this.ksiegarniaDataSet6BindingSource.DataSource = this.ksiegarniaDataSet6;
            this.ksiegarniaDataSet6BindingSource.Position = 0;
            // 
            // vwZasobyRozszerzoneBindingSource
            // 
            this.vwZasobyRozszerzoneBindingSource.DataMember = "vw_Zasoby_Rozszerzone";
            this.vwZasobyRozszerzoneBindingSource.DataSource = this.ksiegarniaDataSet6BindingSource;
            // 
            // vw_Zasoby_RozszerzoneTableAdapter
            // 
            this.vw_Zasoby_RozszerzoneTableAdapter.ClearBeforeFill = true;
            // 
            // ksiegarniaDataSet7BindingSource
            // 
            this.ksiegarniaDataSet7BindingSource.DataSource = this.ksiegarniaDataSet7;
            this.ksiegarniaDataSet7BindingSource.Position = 0;
            // 
            // vw_Ceny_RozszerzoneTableAdapter
            // 
            this.vw_Ceny_RozszerzoneTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Pink;
            this.btnClose.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1190, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 48);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Pink;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 11F);
            this.button3.Location = new System.Drawing.Point(943, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 51);
            this.button3.TabIndex = 38;
            this.button3.Text = "Dodaj cenę";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 11F);
            this.button1.Location = new System.Drawing.Point(727, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 51);
            this.button1.TabIndex = 39;
            this.button1.Text = "Edytuj Cenę";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvCennik
            // 
            this.dgvCennik.AutoGenerateColumns = false;
            this.dgvCennik.BackgroundColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Modern No. 20", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCennik.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCennik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCennik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwaZasobuDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.dataZmianyDataGridViewTextBoxColumn});
            this.dgvCennik.DataSource = this.vwCenyRozszerzoneBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Modern No. 20", 9.999999F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCennik.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCennik.GridColor = System.Drawing.Color.Crimson;
            this.dgvCennik.Location = new System.Drawing.Point(101, 159);
            this.dgvCennik.Name = "dgvCennik";
            this.dgvCennik.RowHeadersWidth = 62;
            this.dgvCennik.RowTemplate.Height = 28;
            this.dgvCennik.Size = new System.Drawing.Size(1045, 266);
            this.dgvCennik.TabIndex = 40;
            // 
            // nazwaZasobuDataGridViewTextBoxColumn
            // 
            this.nazwaZasobuDataGridViewTextBoxColumn.DataPropertyName = "NazwaZasobu";
            this.nazwaZasobuDataGridViewTextBoxColumn.HeaderText = "NazwaZasobu";
            this.nazwaZasobuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nazwaZasobuDataGridViewTextBoxColumn.Name = "nazwaZasobuDataGridViewTextBoxColumn";
            this.nazwaZasobuDataGridViewTextBoxColumn.Width = 150;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataZmianyDataGridViewTextBoxColumn
            // 
            this.dataZmianyDataGridViewTextBoxColumn.DataPropertyName = "DataZmiany";
            this.dataZmianyDataGridViewTextBoxColumn.HeaderText = "DataZmiany";
            this.dataZmianyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataZmianyDataGridViewTextBoxColumn.Name = "dataZmianyDataGridViewTextBoxColumn";
            this.dataZmianyDataGridViewTextBoxColumn.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Pink;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(554, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "CENNIK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(293, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "wyszukaj frazę:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(264, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "wybierz kategorię:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Pink;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 8.999998F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(812, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 51);
            this.button2.TabIndex = 44;
            this.button2.Text = "wyszyść wyszukiwanie";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.BackColor = System.Drawing.Color.Pink;
            this.btnSzukaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSzukaj.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnSzukaj.Location = new System.Drawing.Point(812, 42);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(203, 38);
            this.btnSzukaj.TabIndex = 43;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = false;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // cmbKategorieCeny
            // 
            this.cmbKategorieCeny.BackColor = System.Drawing.Color.Pink;
            this.cmbKategorieCeny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKategorieCeny.FormattingEnabled = true;
            this.cmbKategorieCeny.Location = new System.Drawing.Point(486, 115);
            this.cmbKategorieCeny.Name = "cmbKategorieCeny";
            this.cmbKategorieCeny.Size = new System.Drawing.Size(291, 28);
            this.cmbKategorieCeny.TabIndex = 42;
            // 
            // txbWyszukiwarkaCeny
            // 
            this.txbWyszukiwarkaCeny.BackColor = System.Drawing.Color.Pink;
            this.txbWyszukiwarkaCeny.Location = new System.Drawing.Point(486, 65);
            this.txbWyszukiwarkaCeny.Name = "txbWyszukiwarkaCeny";
            this.txbWyszukiwarkaCeny.Size = new System.Drawing.Size(291, 26);
            this.txbWyszukiwarkaCeny.TabIndex = 41;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Pink;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(1077, 12);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button4.Size = new System.Drawing.Size(107, 48);
            this.button4.TabIndex = 48;
            this.button4.Text = "Wróć";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Cennik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ksiegarnia2.Properties.Resources.v807_mynt_03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1269, 571);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.cmbKategorieCeny);
            this.Controls.Add(this.txbWyszukiwarkaCeny);
            this.Controls.Add(this.dgvCennik);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "Cennik";
            this.Text = "Cennik";
            this.Load += new System.EventHandler(this.Cennik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwCenyRozszerzoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwZasobyRozszerzoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCennik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.BindingSource bindingSource1;
        private Ksiegarnia2.KsiegarniaDataSet4 ksiegarniaDataSet4;
        private System.Windows.Forms.BindingSource cenyBindingSource;
        private Ksiegarnia2.KsiegarniaDataSet4TableAdapters.CenyTableAdapter cenyTableAdapter;
        private System.Windows.Forms.BindingSource ksiegarniaDataSet6BindingSource;
        private Ksiegarnia2.KsiegarniaDataSet6 ksiegarniaDataSet6;
        private System.Windows.Forms.BindingSource vwZasobyRozszerzoneBindingSource;
        private Ksiegarnia2.KsiegarniaDataSet6TableAdapters.vw_Zasoby_RozszerzoneTableAdapter vw_Zasoby_RozszerzoneTableAdapter;
        private System.Windows.Forms.BindingSource ksiegarniaDataSet7BindingSource;
        private Ksiegarnia2.KsiegarniaDataSet7 ksiegarniaDataSet7;
        private System.Windows.Forms.BindingSource vwCenyRozszerzoneBindingSource;
        private Ksiegarnia2.KsiegarniaDataSet7TableAdapters.vw_Ceny_RozszerzoneTableAdapter vw_Ceny_RozszerzoneTableAdapter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvCennik;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaZasobuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataZmianyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.ComboBox cmbKategorieCeny;
        private System.Windows.Forms.TextBox txbWyszukiwarkaCeny;
        private System.Windows.Forms.Button button4;
    }
}