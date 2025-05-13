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
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMiesiace.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cmbMiesiace.Items.Add(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i));
            }

            foreach (DataGridViewColumn col in dgvZasoby.Columns)
            {
                Console.WriteLine(col.HeaderText); // wypisze w konsoli
                                                   // Lub:
                MessageBox.Show(col.HeaderText);
            }
        }
        private void cmbMiesiace_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void Raporty_Load(object sender, EventArgs e)
        {
            // Załaduj dane z widoku
            this.widok_SprzedazNaMiesiacTableAdapter.Fill(this.ksiegarniaDataSet4.Widok_SprzedazNaMiesiac);

            // Wyciągnij unikalne miesiące z danych
            var miesiace = ksiegarniaDataSet4.Widok_SprzedazNaMiesiac
                .AsEnumerable()
                .Select(r => r.Miesiac)
                .Distinct()
                .OrderBy(m => m)
                .ToList();

            cmbMiesiace.Items.Clear();
            foreach (int m in miesiace)
            {
                string nazwa = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(m);
                cmbMiesiace.Items.Add(nazwa);
            }

            if (cmbMiesiace.Items.Count > 0)
                cmbMiesiace.SelectedIndex = 0;
        }

        private void dgvZasoby_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                string header = dgvZasoby.Columns[e.ColumnIndex].HeaderText;
                MessageBox.Show("Kliknięto kolumnę: " + header);
            }
        }

        private void btnGeneruj2_Click(object sender, EventArgs e)
        {
            if (cmbMiesiace.SelectedIndex < 0)
            {
                MessageBox.Show("Wybierz miesiąc z listy.");
                return;
            }

            //int wybranyMiesiac = cmbMiesiace.SelectedIndex + 1;

            // Wyczyszczenie wykresu
            chartSprzedaz.Series.Clear();
            chartSprzedaz.Titles.Clear();

            // Konfiguracja obszaru wykresu (oś X)
            var area = chartSprzedaz.ChartAreas[0];
            area.AxisX.LabelStyle.Angle = -45;                           // pochyl o 45 stopni
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9f);       // mniejsza czcionka
            //area.AxisX.LabelStyle.IsStaggered = true;                    // naprzemienne przesunięcie etykiet
            area.AxisX.Interval = 1;                                     // pokazuj każdą etykietę
            area.AxisX.MajorGrid.Enabled = false;                        // opcjonalnie wyłącz siatkę poziomą

            Series seria = new Series("Sprzedaż")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true                                 // pokaż wartość nad słupkiem
            };

            int licznik = 0;

            foreach (DataGridViewRow row in dgvZasoby.Rows)
            {
                if (row.IsNewRow) continue;

                var miesiacCell = row.Cells["MiesiacDataGridViewTextBoxColumn"];
                if (miesiacCell.Value == null || miesiacCell.Value == DBNull.Value) continue;
                int miesiac = Convert.ToInt32(miesiacCell.Value);
                //if (miesiac != wybranyMiesiac) continue;

                string tytul = row.Cells["TytulDataGridViewTextBoxColumn"].Value?.ToString() ?? "(brak)";
                var sprzedaneCell = row.Cells["SumaSprzedanychDataGridViewTextBoxColumn"];
                if (sprzedaneCell.Value == null || sprzedaneCell.Value == DBNull.Value) continue;

                int sprzedane = Convert.ToInt32(sprzedaneCell.Value);

                seria.Points.AddXY(tytul, sprzedane);
                licznik++;
            }

            if (licznik == 0)
            {
                MessageBox.Show("Brak danych dla wybranego miesiąca.");
                return;
            }

            chartSprzedaz.Series.Add(seria);
            chartSprzedaz.Titles.Add($"Sprzedaż – {CultureInfo.CurrentCulture.DateTimeFormat}");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}