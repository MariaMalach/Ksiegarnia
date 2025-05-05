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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zasoby));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ksiegarniaDataSet = new Ksiegarnia2.KsiegarniaDataSet();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.zasobyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zasobyTableAdapter = new Ksiegarnia2.KsiegarniaDataSetTableAdapters.ZasobyTableAdapter();
            this.zasobyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKZasobyAuIdZas3B75D760BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zasoby_AutorzyTableAdapter = new Ksiegarnia2.KsiegarniaDataSetTableAdapters.Zasoby_AutorzyTableAdapter();
            this.tytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokWydaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUtworzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksiegarniaDataSet5 = new Ksiegarnia2.KsiegarniaDataSet5();
            this.vwZasobyPelneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_Zasoby_PelneTableAdapter = new Ksiegarnia2.KsiegarniaDataSet5TableAdapters.vw_Zasoby_PelneTableAdapter();
            this.vwZasobyRozszerzoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_Zasoby_RozszerzoneTableAdapter = new Ksiegarnia2.KsiegarniaDataSet5TableAdapters.vw_Zasoby_RozszerzoneTableAdapter();
            this.NazwaKategorii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazwaWydawnictwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autorzy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zasobyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zasobyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKZasobyAuIdZas3B75D760BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwZasobyPelneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwZasobyRozszerzoneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tytulDataGridViewTextBoxColumn,
            this.rokWydaniaDataGridViewTextBoxColumn,
            this.iloscDataGridViewTextBoxColumn,
            this.dataUtworzeniaDataGridViewTextBoxColumn,
            this.NazwaKategorii,
            this.NazwaWydawnictwa,
            this.Autorzy});
            this.dataGridView1.DataSource = this.vwZasobyPelneBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1245, 523);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = false;
            this.bindingSource1.DataSource = this.ksiegarniaDataSet5;
            this.bindingSource1.Position = 0;
            // 
            // ksiegarniaDataSet
            // 
            this.ksiegarniaDataSet.DataSetName = "KsiegarniaDataSet";
            this.ksiegarniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.zasobyBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1269, 33);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
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
            // zasobyBindingSource1
            // 
            this.zasobyBindingSource1.DataMember = "Zasoby";
            this.zasobyBindingSource1.DataSource = this.bindingSource1;
            // 
            // fKZasobyAuIdZas3B75D760BindingSource
            // 
            this.fKZasobyAuIdZas3B75D760BindingSource.DataMember = "FK__Zasoby_Au__IdZas__3B75D760";
            this.fKZasobyAuIdZas3B75D760BindingSource.DataSource = this.zasobyBindingSource1;
            // 
            // zasoby_AutorzyTableAdapter
            // 
            this.zasoby_AutorzyTableAdapter.ClearBeforeFill = true;
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
            // dataUtworzeniaDataGridViewTextBoxColumn
            // 
            this.dataUtworzeniaDataGridViewTextBoxColumn.DataPropertyName = "DataUtworzenia";
            this.dataUtworzeniaDataGridViewTextBoxColumn.HeaderText = "DataUtworzenia";
            this.dataUtworzeniaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataUtworzeniaDataGridViewTextBoxColumn.Name = "dataUtworzeniaDataGridViewTextBoxColumn";
            this.dataUtworzeniaDataGridViewTextBoxColumn.Width = 150;
            // 
            // ksiegarniaDataSet5
            // 
            this.ksiegarniaDataSet5.DataSetName = "KsiegarniaDataSet5";
            this.ksiegarniaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwZasobyPelneBindingSource
            // 
            this.vwZasobyPelneBindingSource.DataMember = "vw_Zasoby_Pelne";
            this.vwZasobyPelneBindingSource.DataSource = this.bindingSource1;
            // 
            // vw_Zasoby_PelneTableAdapter
            // 
            this.vw_Zasoby_PelneTableAdapter.ClearBeforeFill = true;
            // 
            // vwZasobyRozszerzoneBindingSource
            // 
            this.vwZasobyRozszerzoneBindingSource.DataMember = "vw_Zasoby_Rozszerzone";
            this.vwZasobyRozszerzoneBindingSource.DataSource = this.bindingSource1;
            // 
            // vw_Zasoby_RozszerzoneTableAdapter
            // 
            this.vw_Zasoby_RozszerzoneTableAdapter.ClearBeforeFill = true;
            // 
            // NazwaKategorii
            // 
            this.NazwaKategorii.DataPropertyName = "NazwaKategorii";
            this.NazwaKategorii.HeaderText = "NazwaKategorii";
            this.NazwaKategorii.MinimumWidth = 8;
            this.NazwaKategorii.Name = "NazwaKategorii";
            this.NazwaKategorii.Width = 150;
            // 
            // NazwaWydawnictwa
            // 
            this.NazwaWydawnictwa.DataPropertyName = "NazwaWydawnictwa";
            this.NazwaWydawnictwa.HeaderText = "NazwaWydawnictwa";
            this.NazwaWydawnictwa.MinimumWidth = 8;
            this.NazwaWydawnictwa.Name = "NazwaWydawnictwa";
            this.NazwaWydawnictwa.Width = 150;
            // 
            // Autorzy
            // 
            this.Autorzy.DataPropertyName = "Autorzy";
            this.Autorzy.HeaderText = "Autorzy";
            this.Autorzy.MinimumWidth = 8;
            this.Autorzy.Name = "Autorzy";
            this.Autorzy.Width = 150;
            // 
            // Zasoby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 571);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Zasoby";
            this.Text = "Zasoby";
            this.Load += new System.EventHandler(this.Zasoby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zasobyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zasobyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKZasobyAuIdZas3B75D760BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwZasobyPelneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwZasobyRozszerzoneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Ksiegarnia2.KsiegarniaDataSet ksiegarniaDataSet;
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
        private System.Windows.Forms.BindingSource zasobyBindingSource;
        private Ksiegarnia2.KsiegarniaDataSetTableAdapters.ZasobyTableAdapter zasobyTableAdapter;
        private System.Windows.Forms.BindingSource zasobyBindingSource1;
        private System.Windows.Forms.BindingSource fKZasobyAuIdZas3B75D760BindingSource;
        private Ksiegarnia2.KsiegarniaDataSetTableAdapters.Zasoby_AutorzyTableAdapter zasoby_AutorzyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokWydaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUtworzeniaDataGridViewTextBoxColumn;
        private Ksiegarnia2.KsiegarniaDataSet5 ksiegarniaDataSet5;
        private System.Windows.Forms.BindingSource vwZasobyPelneBindingSource;
        private Ksiegarnia2.KsiegarniaDataSet5TableAdapters.vw_Zasoby_PelneTableAdapter vw_Zasoby_PelneTableAdapter;
        private System.Windows.Forms.BindingSource vwZasobyRozszerzoneBindingSource;
        private Ksiegarnia2.KsiegarniaDataSet5TableAdapters.vw_Zasoby_RozszerzoneTableAdapter vw_Zasoby_RozszerzoneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwaKategorii;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwaWydawnictwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autorzy;
    }
}