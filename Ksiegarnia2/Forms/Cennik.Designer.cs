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
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ksiegarniaDataSet4 = new Ksiegarnia2.KsiegarniaDataSet4();
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
            this.dgvCennik = new System.Windows.Forms.DataGridView();
            this.cenyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cenyTableAdapter = new Ksiegarnia2.KsiegarniaDataSet4TableAdapters.CenyTableAdapter();
            this.ksiegarniaDataSet6 = new Ksiegarnia2.KsiegarniaDataSet6();
            this.ksiegarniaDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwZasobyRozszerzoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_Zasoby_RozszerzoneTableAdapter = new Ksiegarnia2.KsiegarniaDataSet6TableAdapters.vw_Zasoby_RozszerzoneTableAdapter();
            this.ksiegarniaDataSet7 = new Ksiegarnia2.KsiegarniaDataSet7();
            this.ksiegarniaDataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwCenyRozszerzoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_Ceny_RozszerzoneTableAdapter = new Ksiegarnia2.KsiegarniaDataSet7TableAdapters.vw_Ceny_RozszerzoneTableAdapter();
            this.nazwaZasobuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataZmianyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCennik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwZasobyRozszerzoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCenyRozszerzoneBindingSource)).BeginInit();
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
            this.bindingNavigatorPositionItem.Text = "1";
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
            // dgvCennik
            // 
            this.dgvCennik.AutoGenerateColumns = false;
            this.dgvCennik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCennik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwaZasobuDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.dataZmianyDataGridViewTextBoxColumn});
            this.dgvCennik.DataSource = this.vwCenyRozszerzoneBindingSource;
            this.dgvCennik.Location = new System.Drawing.Point(12, 12);
            this.dgvCennik.Name = "dgvCennik";
            this.dgvCennik.RowHeadersWidth = 62;
            this.dgvCennik.RowTemplate.Height = 28;
            this.dgvCennik.Size = new System.Drawing.Size(1245, 523);
            this.dgvCennik.TabIndex = 2;
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
            // ksiegarniaDataSet7
            // 
            this.ksiegarniaDataSet7.DataSetName = "KsiegarniaDataSet7";
            this.ksiegarniaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ksiegarniaDataSet7BindingSource
            // 
            this.ksiegarniaDataSet7BindingSource.DataSource = this.ksiegarniaDataSet7;
            this.ksiegarniaDataSet7BindingSource.Position = 0;
            // 
            // vwCenyRozszerzoneBindingSource
            // 
            this.vwCenyRozszerzoneBindingSource.DataMember = "vw_Ceny_Rozszerzone";
            this.vwCenyRozszerzoneBindingSource.DataSource = this.ksiegarniaDataSet7;
            // 
            // vw_Ceny_RozszerzoneTableAdapter
            // 
            this.vw_Ceny_RozszerzoneTableAdapter.ClearBeforeFill = true;
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
            // Cennik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 571);
            this.ControlBox = false;
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dgvCennik);
            this.Name = "Cennik";
            this.Text = "Cennik";
            this.Load += new System.EventHandler(this.Cennik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCennik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwZasobyRozszerzoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCenyRozszerzoneBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvCennik;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaZasobuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataZmianyDataGridViewTextBoxColumn;
    }
}