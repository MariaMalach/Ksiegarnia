using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksiegarnia2.Forms
{
    public partial class DodajPracownika : Form
    {
        private int? selectedPracownikId = null;

        public DodajPracownika()
        {
            InitializeComponent();
            dgvPracownicy.CellClick += dgvPracownicy_CellClick_1;
        }

        private void DodajPracownika_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet.vw_PracownicyZeStanowiskiem' . Możesz go przenieść lub usunąć.
            this.vw_PracownicyZeStanowiskiemTableAdapter.Fill(this.ksiegarniaDataSet.vw_PracownicyZeStanowiskiem);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet.Stanowiska' . Możesz go przenieść lub usunąć.
            this.stanowiskaTableAdapter.Fill(this.ksiegarniaDataSet.Stanowiska);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet.Pracownicy' . Możesz go przenieść lub usunąć.
            this.pracownicyTableAdapter.Fill(this.ksiegarniaDataSet.Pracownicy);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet5.Pracownicy' . Możesz go przenieść lub usunąć.
          
          
            
            

            cmbStanowisko.DataSource = ksiegarniaDataSet.Stanowiska;
            cmbStanowisko.DisplayMember = "NazwaStanowiska";
            cmbStanowisko.ValueMember = "IDStanowisko";
        }

        private void dgvPracownicy_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvPracownicy.Rows[e.RowIndex];

           

            object idValue = row.Cells["IDPracownika"].Value;
            selectedPracownikId = idValue != DBNull.Value ? Convert.ToInt32(idValue) : 0;

            txbImie.Text = row.Cells["dataGridViewTextBoxColumn2"].Value?.ToString() ?? string.Empty;
            txbNazwisko.Text = row.Cells["dataGridViewTextBoxColumn3"].Value?.ToString() ?? string.Empty;
            txbEmail.Text = row.Cells["dataGridViewTextBoxColumn5"].Value?.ToString() ?? string.Empty;
            txbTelefon.Text = row.Cells["dataGridViewTextBoxColumn6"].Value?.ToString() ?? string.Empty;

            
            object dataZatrValue = row.Cells["dataGridViewTextBoxColumn4"].Value;
            if (dataZatrValue != DBNull.Value)
            {
                dtpZatrudnienie.Value = Convert.ToDateTime(dataZatrValue);
            }
            else
            {
                dtpZatrudnienie.Value = DateTime.Now; 
            }

            cmbStanowisko.Text = row.Cells["dataGridViewTextBoxColumn4"].Value?.ToString() ?? string.Empty;
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string Imie = txbImie.Text.Trim();
            string Nazwisko = txbNazwisko.Text.Trim();
            string Email = txbEmail.Text.Trim();
            string Telefon = txbTelefon.Text.Trim();
            DateTime DataZatrudnienia = dtpZatrudnienie.Value;
            object selectedStanowisko = cmbStanowisko.SelectedValue;

            if (string.IsNullOrEmpty(Imie) ||
                string.IsNullOrEmpty(Nazwisko) ||
                string.IsNullOrEmpty(Email) ||
                string.IsNullOrEmpty(Telefon) ||
                selectedStanowisko == null)
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.");
                return;
            }

            DataRow[] existingRows = ksiegarniaDataSet.Tables["Pracownicy"]
                .Select($"Email = '{Email.Replace("'", "''")}'"); 

            if (existingRows.Length > 0)
            {
                MessageBox.Show("Pracownik z podanym adresem e-mail już istnieje.");
                return;
            }

            try
            {
                DataRow newRow = ksiegarniaDataSet.Tables["Pracownicy"].NewRow();
                newRow["Imie"] = Imie;
                newRow["Nazwisko"] = Nazwisko;
                newRow["Email"] = Email;
                newRow["Telefon"] = Telefon;
                newRow["DataZatrudnienia"] = DataZatrudnienia;
                newRow["IDStanowisko"] = selectedStanowisko;

                ksiegarniaDataSet.Tables["Pracownicy"].Rows.Add(newRow);
                pracownicyTableAdapter.Update(ksiegarniaDataSet.Pracownicy);

                MessageBox.Show("Pracownik został dodany.");
                OdswiezDane();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas dodawania pracownika: " + ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (!selectedPracownikId.HasValue)
            {
                MessageBox.Show("Wybierz pracownika do edycji.");
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txbImie.Text) || string.IsNullOrWhiteSpace(txbNazwisko.Text)
                || string.IsNullOrWhiteSpace(txbEmail.Text) || string.IsNullOrWhiteSpace(txbTelefon.Text)
                || cmbStanowisko.SelectedValue == null)
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.");
                return;
            }
            try
            {
                var row = ksiegarniaDataSet.Pracownicy.FindByIDPracownika(selectedPracownikId.Value);
                row.Imie = txbImie.Text.Trim();
                row.Nazwisko = txbNazwisko.Text.Trim();
                row.Email = txbEmail.Text.Trim();
                row.Telefon = txbTelefon.Text.Trim();
                row.DataZatrudnienia = dtpZatrudnienie.Value;
                row.IDStanowisko = (int)cmbStanowisko.SelectedValue;

                pracownicyTableAdapter.Update(ksiegarniaDataSet.Pracownicy);
                MessageBox.Show("Dane pracownika zostały zaktualizowane.");
                OdswiezDane();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas edycji pracownika: " + ex.Message);
            }
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (!selectedPracownikId.HasValue)
            {
                MessageBox.Show("Wybierz pracownika do usunięcia.");
                return;
            }
            var confirm = MessageBox.Show("Czy na pewno usunąć pracownika?", "Potwierdź", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;
            try
            {
                var row = ksiegarniaDataSet.Pracownicy.FindByIDPracownika(selectedPracownikId.Value);
                row.Delete();
                pracownicyTableAdapter.Update(ksiegarniaDataSet.Pracownicy);
                MessageBox.Show("Pracownik został usunięty.");
                ClearForm();
                OdswiezDane();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas usuwania pracownika: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            selectedPracownikId = null;
            txbImie.Clear();
            txbNazwisko.Clear();
            txbEmail.Clear();
            txbTelefon.Clear();
            dtpZatrudnienie.Value = DateTime.Now;
            cmbStanowisko.SelectedIndex = -1;
        }

        private void OdswiezDane()
        {
            ksiegarniaDataSet.vw_PracownicyZeStanowiskiem.Clear();
            vw_PracownicyZeStanowiskiemTableAdapter.Fill(ksiegarniaDataSet.vw_PracownicyZeStanowiskiem);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
