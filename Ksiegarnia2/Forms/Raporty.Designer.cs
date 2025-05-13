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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.chartSprzedaz = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbMiesiace = new System.Windows.Forms.ComboBox();
            this.dgvZasoby = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.chartSprzedaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZasoby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widokSprzedazNaMiesiacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Pink;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(345, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(441, 33);
            this.label6.TabIndex = 55;
            this.label6.Text = "Statystyki dotyczące Księgarni";
            // 
            // chartSprzedaz
            // 
            this.chartSprzedaz.BackColor = System.Drawing.Color.Pink;
            this.chartSprzedaz.BorderlineColor = System.Drawing.Color.MistyRose;
            chartArea3.Name = "ChartArea1";
            this.chartSprzedaz.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartSprzedaz.Legends.Add(legend3);
            this.chartSprzedaz.Location = new System.Drawing.Point(26, 56);
            this.chartSprzedaz.Name = "chartSprzedaz";
            this.chartSprzedaz.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartSprzedaz.Series.Add(series3);
            this.chartSprzedaz.Size = new System.Drawing.Size(1148, 323);
            this.chartSprzedaz.TabIndex = 56;
            this.chartSprzedaz.Text = "chart1";
            this.chartSprzedaz.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // cmbMiesiace
            // 
            this.cmbMiesiace.BackColor = System.Drawing.Color.Pink;
            this.cmbMiesiace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMiesiace.FormattingEnabled = true;
            this.cmbMiesiace.Location = new System.Drawing.Point(119, 480);
            this.cmbMiesiace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMiesiace.Name = "cmbMiesiace";
            this.cmbMiesiace.Size = new System.Drawing.Size(259, 24);
            this.cmbMiesiace.TabIndex = 64;
            // 
            // dgvZasoby
            // 
            this.dgvZasoby.AutoGenerateColumns = false;
            this.dgvZasoby.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvZasoby.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZasoby.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvZasoby.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZasoby.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tytulDataGridViewTextBoxColumn,
            this.miesiacDataGridViewTextBoxColumn,
            this.sumaSprzedanychDataGridViewTextBoxColumn});
            this.dgvZasoby.DataSource = this.widokSprzedazNaMiesiacBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.999999F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZasoby.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvZasoby.GridColor = System.Drawing.Color.Crimson;
            this.dgvZasoby.Location = new System.Drawing.Point(686, 384);
            this.dgvZasoby.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvZasoby.Name = "dgvZasoby";
            this.dgvZasoby.RowHeadersWidth = 62;
            this.dgvZasoby.RowTemplate.Height = 28;
            this.dgvZasoby.Size = new System.Drawing.Size(519, 307);
            this.dgvZasoby.TabIndex = 65;
            this.dgvZasoby.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZasoby_CellContentClick);
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
            this.btnGeneruj2.Location = new System.Drawing.Point(119, 527);
            this.btnGeneruj2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeneruj2.Name = "btnGeneruj2";
            this.btnGeneruj2.Size = new System.Drawing.Size(209, 42);
            this.btnGeneruj2.TabIndex = 66;
            this.btnGeneruj2.Text = "Generuj";
            this.btnGeneruj2.UseVisualStyleBackColor = false;
            this.btnGeneruj2.Click += new System.EventHandler(this.btnGeneruj2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1123, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(95, 38);
            this.button1.TabIndex = 68;
            this.button1.Text = "Wróć";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Pink;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1223, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 38);
            this.btnClose.TabIndex = 67;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Raporty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ksiegarnia2.Properties.Resources.v807_mynt_03;
            this.ClientSize = new System.Drawing.Size(1295, 767);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGeneruj2);
            this.Controls.Add(this.dgvZasoby);
            this.Controls.Add(this.cmbMiesiace);
            this.Controls.Add(this.chartSprzedaz);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Raporty";
            this.Text = "Raporty";
            this.Load += new System.EventHandler(this.Raporty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSprzedaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZasoby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widokSprzedazNaMiesiacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiegarniaDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSprzedaz;
        private System.Windows.Forms.ComboBox cmbMiesiace;
        private System.Windows.Forms.DataGridView dgvZasoby;
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
        //private System.Windows.Forms.Button btnGeneruj;
    }
}