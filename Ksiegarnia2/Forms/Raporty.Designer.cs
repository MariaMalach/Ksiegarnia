namespace Ksiegarnia.Forms
{
    partial class Raporty
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.chartSprzedaz = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvRaport = new System.Windows.Forms.DataGridView();
            this.tytulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miesiacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaSprzedanychDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widokSprzedazNaMiesiacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ksiegarniaDataSet4 = new Ksiegarnia2.KsiegarniaDataSet4();
            this.widok_SprzedazNaMiesiacTableAdapter = new Ksiegarnia2.KsiegarniaDataSet4TableAdapters.Widok_SprzedazNaMiesiacTableAdapter();
            this.btnGeneruj2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ksiegarniaDataSet5 = new Ksiegarnia2.KsiegarniaDataSet5();
            this.widokSprzedazNaMiesiacBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.widok_SprzedazNaMiesiacTableAdapter1 = new Ksiegarnia2.KsiegarniaDataSet5TableAdapters.Widok_SprzedazNaMiesiacTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chartSprzedaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widokSprzedazNaMiesiacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widokSprzedazNaMiesiacBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Pink;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(388, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(506, 39);
            this.label6.TabIndex = 55;
            this.label6.Text = "Statystyki dotyczące Księgarni";
            // 
            // chartSprzedaz
            // 
            this.chartSprzedaz.BackColor = System.Drawing.Color.Pink;
            this.chartSprzedaz.BorderlineColor = System.Drawing.Color.MistyRose;
            chartArea1.Name = "ChartArea1";
            this.chartSprzedaz.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSprzedaz.Legends.Add(legend1);
            this.chartSprzedaz.Location = new System.Drawing.Point(29, 70);
            this.chartSprzedaz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartSprzedaz.Name = "chartSprzedaz";
            this.chartSprzedaz.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSprzedaz.Series.Add(series1);
            this.chartSprzedaz.Size = new System.Drawing.Size(1292, 404);
            this.chartSprzedaz.TabIndex = 56;
            this.chartSprzedaz.Text = "chart1";
            this.chartSprzedaz.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // dgvRaport
            // 
            this.dgvRaport.AutoGenerateColumns = false;
            this.dgvRaport.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvRaport.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRaport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRaport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tytulDataGridViewTextBoxColumn,
            this.miesiacDataGridViewTextBoxColumn,
            this.sumaSprzedanychDataGridViewTextBoxColumn});
            this.dgvRaport.DataSource = this.widokSprzedazNaMiesiacBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.999999F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRaport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRaport.GridColor = System.Drawing.Color.Crimson;
            this.dgvRaport.Location = new System.Drawing.Point(256, 480);
            this.dgvRaport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRaport.Name = "dgvRaport";
            this.dgvRaport.RowHeadersWidth = 62;
            this.dgvRaport.RowTemplate.Height = 28;
            this.dgvRaport.Size = new System.Drawing.Size(822, 384);
            this.dgvRaport.TabIndex = 65;
            this.dgvRaport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZasoby_CellContentClick);
            // 
            // tytulDataGridViewTextBoxColumn
            // 
            this.tytulDataGridViewTextBoxColumn.DataPropertyName = "Tytul";
            this.tytulDataGridViewTextBoxColumn.HeaderText = "Tytul";
            this.tytulDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tytulDataGridViewTextBoxColumn.Name = "tytulDataGridViewTextBoxColumn";
            this.tytulDataGridViewTextBoxColumn.Width = 125;
            // 
            // miesiacDataGridViewTextBoxColumn
            // 
            this.miesiacDataGridViewTextBoxColumn.DataPropertyName = "Miesiac";
            this.miesiacDataGridViewTextBoxColumn.HeaderText = "Miesiac";
            this.miesiacDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.miesiacDataGridViewTextBoxColumn.Name = "miesiacDataGridViewTextBoxColumn";
            this.miesiacDataGridViewTextBoxColumn.Width = 125;
            // 
            // sumaSprzedanychDataGridViewTextBoxColumn
            // 
            this.sumaSprzedanychDataGridViewTextBoxColumn.DataPropertyName = "SumaSprzedanych";
            this.sumaSprzedanychDataGridViewTextBoxColumn.HeaderText = "SumaSprzedanych";
            this.sumaSprzedanychDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sumaSprzedanychDataGridViewTextBoxColumn.Name = "sumaSprzedanychDataGridViewTextBoxColumn";
            this.sumaSprzedanychDataGridViewTextBoxColumn.Width = 125;
            // 
            // widokSprzedazNaMiesiacBindingSource
            // 
            this.widokSprzedazNaMiesiacBindingSource.DataMember = "Widok_SprzedazNaMiesiac";
            this.widokSprzedazNaMiesiacBindingSource.DataSource = this.bindingSource1;
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
            // widok_SprzedazNaMiesiacTableAdapter
            // 
            this.widok_SprzedazNaMiesiacTableAdapter.ClearBeforeFill = true;
            // 
            // btnGeneruj2
            // 
            this.btnGeneruj2.BackColor = System.Drawing.Color.Pink;
            this.btnGeneruj2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGeneruj2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGeneruj2.Location = new System.Drawing.Point(1120, 161);
            this.btnGeneruj2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeneruj2.Name = "btnGeneruj2";
            this.btnGeneruj2.Size = new System.Drawing.Size(188, 82);
            this.btnGeneruj2.TabIndex = 66;
            this.btnGeneruj2.Text = "Generuj wykres";
            this.btnGeneruj2.UseVisualStyleBackColor = false;
            this.btnGeneruj2.Click += new System.EventHandler(this.btnGeneruj2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1263, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(107, 48);
            this.button1.TabIndex = 68;
            this.button1.Text = "Wróć";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Pink;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1376, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 48);
            this.btnClose.TabIndex = 67;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ksiegarniaDataSet5
            // 
            this.ksiegarniaDataSet5.DataSetName = "KsiegarniaDataSet5";
            this.ksiegarniaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // widokSprzedazNaMiesiacBindingSource1
            // 
            this.widokSprzedazNaMiesiacBindingSource1.DataMember = "Widok_SprzedazNaMiesiac";
            this.widokSprzedazNaMiesiacBindingSource1.DataSource = this.ksiegarniaDataSet5;
            // 
            // widok_SprzedazNaMiesiacTableAdapter1
            // 
            this.widok_SprzedazNaMiesiacTableAdapter1.ClearBeforeFill = true;
            // 
            // Raporty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Ksiegarnia2.Properties.Resources.v807_mynt_03;
            this.ClientSize = new System.Drawing.Size(1457, 959);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGeneruj2);
            this.Controls.Add(this.dgvRaport);
            this.Controls.Add(this.chartSprzedaz);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Raporty";
            this.Text = "Raporty";
            this.Load += new System.EventHandler(this.Raporty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSprzedaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widokSprzedazNaMiesiacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widokSprzedazNaMiesiacBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSprzedaz;
        private System.Windows.Forms.DataGridView dgvRaport;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Ksiegarnia2.KsiegarniaDataSet4 ksiegarniaDataSet4;
        private System.Windows.Forms.BindingSource widokSprzedazNaMiesiacBindingSource;
        private Ksiegarnia2.KsiegarniaDataSet4TableAdapters.Widok_SprzedazNaMiesiacTableAdapter widok_SprzedazNaMiesiacTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miesiacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaSprzedanychDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGeneruj2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
        private Ksiegarnia2.KsiegarniaDataSet5 ksiegarniaDataSet5;
        private System.Windows.Forms.BindingSource widokSprzedazNaMiesiacBindingSource1;
        private Ksiegarnia2.KsiegarniaDataSet5TableAdapters.Widok_SprzedazNaMiesiacTableAdapter widok_SprzedazNaMiesiacTableAdapter1;
        //private System.Windows.Forms.Button btnGeneruj;
    }
}