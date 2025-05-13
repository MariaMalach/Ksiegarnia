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
            // Wczytanie danych
            this.stanowiskaTableAdapter.Fill(this.ksiegarniaDataSet3.Stanowiska);
            this.pracownicyTableAdapter.Fill(this.ksiegarniaDataSet3.Pracownicy);
            this.vw_PracownicyZeStanowiskiemTableAdapter.Fill(this.ksiegarniaDataSet3.vw_PracownicyZeStanowiskiem);

            cmbStanowisko.DataSource = ksiegarniaDataSet3.Stanowiska;
            cmbStanowisko.DisplayMember = "NazwaStanowiska";
            cmbStanowisko.ValueMember = "IDStanowisko";
        }

        private void dgvPracownicy_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvPracownicy.Rows[e.RowIndex];
            selectedPracownikId = Convert.ToInt32(row.Cells["IDPracownikaDataGridViewTextBoxColumn"].Value);
            txbImie.Text = row.Cells["ImieDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
            txbNazwisko.Text = row.Cells["NazwiskoDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
            txbEmail.Text = row.Cells["EmailDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
            txbTelefon.Text = row.Cells["TelefonDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
            dtpZatrudnienie.Value = Convert.ToDateTime(row.Cells["DataZatrudnieniaDataGridViewTextBoxColumn"].Value);
            cmbStanowisko.SelectedValue = row.Cells["IDStanowisko"].Value;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            // istniejąca implementacja dodawania
            // ...
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!selectedPracownikId.HasValue)
            {
                MessageBox.Show("Wybierz pracownika do edycji.");
                return;
            }
            // Walidacja
            if (string.IsNullOrWhiteSpace(txbImie.Text) || string.IsNullOrWhiteSpace(txbNazwisko.Text)
                || string.IsNullOrWhiteSpace(txbEmail.Text) || string.IsNullOrWhiteSpace(txbTelefon.Text)
                || cmbStanowisko.SelectedValue == null)
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.");
                return;
            }
            try
            {
                var row = ksiegarniaDataSet3.Pracownicy.FindByIDPracownika(selectedPracownikId.Value);
                row.Imie = txbImie.Text.Trim();
                row.Nazwisko = txbNazwisko.Text.Trim();
                row.Email = txbEmail.Text.Trim();
                row.Telefon = txbTelefon.Text.Trim();
                row.DataZatrudnienia = dtpZatrudnienie.Value;
                row.IDStanowisko = (int)cmbStanowisko.SelectedValue;

                pracownicyTableAdapter.Update(ksiegarniaDataSet3.Pracownicy);
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
                var row = ksiegarniaDataSet3.Pracownicy.FindByIDPracownika(selectedPracownikId.Value);
                row.Delete();
                pracownicyTableAdapter.Update(ksiegarniaDataSet3.Pracownicy);
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
            ksiegarniaDataSet3.vw_PracownicyZeStanowiskiem.Clear();
            vw_PracownicyZeStanowiskiemTableAdapter.Fill(ksiegarniaDataSet3.vw_PracownicyZeStanowiskiem);
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
