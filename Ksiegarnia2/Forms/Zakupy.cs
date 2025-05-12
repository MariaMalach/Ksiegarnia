using Ksiegarnia2;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ksiegarnia.Forms
{
    public partial class Zakupy : Form
    {
        private SqlDataAdapter zakupyAdapter;
        private DataSet zakupyDataSet;

        public Zakupy()
        {
            InitializeComponent();
            dgvZasoby.CellClick += dgvZasoby_CellClick;
        }

        private void OdswiezDane()
        {
            ksiegarniaDataSet2.Tables["Zasoby"].Clear();
            zasobyTableAdapter.Fill(ksiegarniaDataSet2.Zasoby);
        }

        private void Zakupy_Load(object sender, EventArgs e)
        {
            this.historiaZakupowTableAdapter.Fill(this.ksiegarniaDataSet2.HistoriaZakupow);
            this.pracownicyTableAdapter.Fill(this.ksiegarniaDataSet2.Pracownicy);
            this.zasobyTableAdapter.Fill(this.ksiegarniaDataSet2.Zasoby);

            cmbPracownik.DataSource = ksiegarniaDataSet2.Pracownicy;
            cmbPracownik.DisplayMember = "Email";
            cmbPracownik.ValueMember = "Email";
        }

        private void dgvZasoby_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvZasoby.Rows[e.RowIndex];
                txbIDZasobu.Text = row.Cells["IdDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                txbCena.Text = row.Cells["CenaDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
            }
        }

        private int? PobierzIloscDlaZasobu(int idZasobu)
        {
            string connectionString = "Data Source=.;Initial Catalog=Ksiegarnia;Integrated Security=True";
            string sql = "SELECT Ilosc FROM Zasoby WHERE Id = @Id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", idZasobu);
                        object wynik = cmd.ExecuteScalar();
                        return wynik != null && wynik != DBNull.Value ? Convert.ToInt32(wynik) : (int?)null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd przy pobieraniu ilości: " + ex.Message);
                return null;
            }
        }

        private void txbIlosc_TextChanged_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(txbCena.Text, out decimal cena) && int.TryParse(txbIlosc.Text, out int ilosc))
            {
                txbCenaKoncowa.Text = (cena * ilosc).ToString("F2");
            }
            else
            {
                txbCenaKoncowa.Text = string.Empty;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbIDZasobu.Text) || string.IsNullOrWhiteSpace(txbIlosc.Text))
            {
                MessageBox.Show("Proszę wypełnić wszystkie wymagane pola.");
                return;
            }

            if (!int.TryParse(txbIDZasobu.Text, out int idZasobu))
            {
                MessageBox.Show("Nieprawidłowe ID zasobu.");
                return;
            }

            int? ilosc = PobierzIloscDlaZasobu(idZasobu);
            if (!int.TryParse(txbIlosc.Text, out int iloscZamawiana) || !ilosc.HasValue)
            {
                MessageBox.Show("Nieprawidłowa ilość lub brak danych w magazynie.");
                return;
            }

            if (iloscZamawiana > ilosc.Value)
            {
                MessageBox.Show("Podana ilość książek nie jest dostępna w magazynie.");
                return;
            }

            try
            {
                
                DataRow newRow = ksiegarniaDataSet2.Tables["HistoriaZakupow"].NewRow();
                newRow["IDZasobu"] = idZasobu;
                newRow["emailPracownika"] = cmbPracownik.SelectedValue.ToString();
                newRow["DataZakupu"] = DateTime.Now;
                newRow["Ilosc"] = iloscZamawiana;
                newRow["Cena"] = decimal.Parse(txbCenaKoncowa.Text);

                ksiegarniaDataSet2.Tables["HistoriaZakupow"].Rows.Add(newRow);
                historiaZakupowTableAdapter.Update(ksiegarniaDataSet2.HistoriaZakupow);

                // Odjęcie ilości z tabeli Zasoby
                foreach (DataRow zasobRow in ksiegarniaDataSet2.Zasoby.Rows)
                {
                    if ((int)zasobRow["Id"] == idZasobu)
                    {
                        int aktualnaIlosc = (int)zasobRow["Ilosc"];
                        zasobRow["Ilosc"] = aktualnaIlosc - iloscZamawiana;
                        break;
                    }
                }

                zasobyTableAdapter.Update(ksiegarniaDataSet2.Zasoby);

                MessageBox.Show("Zasób został dodany i ilość została zaktualizowana.");
                OdswiezDane();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas dodawania zasobu: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ksiegarnia2.Form1 form1 = new Ksiegarnia2.Form1();
            form1.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
