using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Ksiegarnia2.Forms
{
    public partial class DodajZasoby : Form
    {
        private SqlDataAdapter zasobyAdapter;
        private DataSet zasobyDataSet;
        private SqlConnection conn;
        private SqlCommandBuilder zasobyCommandBuilder;

        public DodajZasoby()
        {
            InitializeComponent();
            InitAdapter();
            dgvZasoby.CellClick += dgvZasoby_CellClick;

        }

        

        private void InitAdapter()
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=Ksiegarnia;Integrated Security=True");

            string selectQuery = "SELECT * FROM Zasoby";
            zasobyAdapter = new SqlDataAdapter(selectQuery, conn);
            zasobyCommandBuilder = new SqlCommandBuilder(zasobyAdapter);

            zasobyDataSet = new DataSet();
            zasobyAdapter.Fill(zasobyDataSet, "Zasoby");

            dgvZasoby.DataSource = zasobyDataSet.Tables["Zasoby"];
        }

        private void btnDodaj_Click_1(object sender, EventArgs e)
        {
            string tytul = txbTytul.Text.Trim();
            string rokText = textRokWydania.Text.Trim();
            string iloscText = textIlosc.Text.Trim();
            string kategoria = textBoxKategoria.Text.Trim();
            string wydawnictwo = textBoxWydawnictwo.Text.Trim();

            if (string.IsNullOrEmpty(tytul) || string.IsNullOrEmpty(rokText) ||
                string.IsNullOrEmpty(kategoria) || string.IsNullOrEmpty(wydawnictwo) ||
                string.IsNullOrEmpty(iloscText))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.");
                return;
            }

            if (!int.TryParse(rokText, out int rok) || rok < 1800 || rok > DateTime.Now.Year)
            {
                MessageBox.Show("Rok wydania musi być poprawną liczbą.");
                return;
            }

            if (!int.TryParse(iloscText, out int ilosc) || ilosc < 1 || ilosc > 1000)
            {
                MessageBox.Show("Ilość dodawanego zasobu musi wynosić między 1 a 1000.");
                return;
            }

            try
            {
                DataRow newRow = zasobyDataSet.Tables["Zasoby"].NewRow();
                newRow["Tytul"] = tytul;
                newRow["RokWydania"] = rok;
                newRow["Ilosc"] = ilosc;
                newRow["Kategoria"] = kategoria;
                newRow["Wydawnictwo"] = wydawnictwo;
                newRow["DataUtworzenia"] = DateTime.Now;

                zasobyDataSet.Tables["Zasoby"].Rows.Add(newRow);
                zasobyAdapter.Update(zasobyDataSet, "Zasoby");

                MessageBox.Show("Zasób został dodany.");
                OdswiezDane();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas dodawania zasobu: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvZasoby.CurrentRow == null)
            {
                MessageBox.Show("Wybierz zasób do edycji.");
                return;
            }

            try
            {
                int rowIndex = dgvZasoby.CurrentRow.Index;
                DataRow row = zasobyDataSet.Tables["Zasoby"].Rows[rowIndex];

                row["Tytul"] = txbTytul.Text.Trim();
                row["RokWydania"] = int.Parse(textRokWydania.Text.Trim());
                row["Ilosc"] = int.Parse(textIlosc.Text.Trim());
                row["Kategoria"] = textBoxKategoria.Text.Trim();
                row["Wydawnictwo"] = textBoxWydawnictwo.Text.Trim();

                zasobyAdapter.Update(zasobyDataSet, "Zasoby");

                MessageBox.Show("Zasób zaktualizowany.");
                OdswiezDane();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas edycji zasobu: " + ex.Message);
            }
        }

   

        private void OdswiezDane()
        {
            zasobyDataSet.Tables["Zasoby"].Clear();
            zasobyAdapter.Fill(zasobyDataSet, "Zasoby");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxKatergoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nieużywane
        }

     

        private void dgvZasoby_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvZasoby.Rows[e.RowIndex];

                var cellValue = row.Cells["Tytul"].Value;
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    txbTytul.Text = cellValue.ToString();
                }
                else
                {
                    txbTytul.Text = string.Empty;
                }
            }
        }
    }
}
