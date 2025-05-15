using Ksiegarnia2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ksiegarnia.Forms
{
    public partial class Raporty : Form
    {
        //private Button btnGeneruj;


        public Raporty()
        {
            InitializeComponent();

        }
     
        private void Raporty_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet5.Widok_SprzedazNaMiesiac' . Możesz go przenieść lub usunąć.
            this.widok_SprzedazNaMiesiacTableAdapter.Fill(this.ksiegarniaDataSet5.Widok_SprzedazNaMiesiac);
      
            dgvRaport.AutoResizeColumns();
            dgvRaport.AutoResizeRows();

        }

        private void dgvZasoby_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                string header = dgvRaport.Columns[e.ColumnIndex].HeaderText;
                MessageBox.Show("Kliknięto kolumnę: " + header);
            }
        }

        private void btnGeneruj2_Click(object sender, EventArgs e)
        {
            chartSprzedaz.Series.Clear();
            chartSprzedaz.Titles.Clear();

            var area = chartSprzedaz.ChartAreas[0];
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9f);
            area.AxisX.Interval = 1;
            area.AxisX.MajorGrid.Enabled = false;

            Series seria = new Series("Sprzedaż")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            int licznik = 0;

            foreach (DataGridViewRow row in dgvRaport.Rows)
            {
                if (row.IsNewRow) continue;

                string tytul = row.Cells["TytulDataGridViewTextBoxColumn"].Value?.ToString() ?? "(brak)";
                var sprzedaneCell = row.Cells["SumaSprzedanychDataGridViewTextBoxColumn"];
                if (sprzedaneCell.Value == null || sprzedaneCell.Value == DBNull.Value) continue;

                int sprzedane = Convert.ToInt32(sprzedaneCell.Value);

                seria.Points.AddXY(tytul, sprzedane);
                licznik++;
            }

            if (licznik == 0)
            {
                MessageBox.Show("Brak danych do wyświetlenia.");
                return;
            }

            chartSprzedaz.Series.Add(seria);
            chartSprzedaz.Titles.Add("Sprzedaż – wszystkie miesiące");
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}