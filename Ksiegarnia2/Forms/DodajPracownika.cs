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
        public DodajPracownika()
        {
            InitializeComponent();
            dgvPracownicy.CellClick += dgvPracownicy_CellClick_1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DodajPracownika_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet3.Pracownicy' . Możesz go przenieść lub usunąć.
            this.pracownicyTableAdapter.Fill(this.ksiegarniaDataSet3.Pracownicy);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet3.Stanowiska' . Możesz go przenieść lub usunąć.
            this.stanowiskaTableAdapter.Fill(this.ksiegarniaDataSet3.Stanowiska);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet3.vw_PracownicyZeStanowiskiem' . Możesz go przenieść lub usunąć.
            this.vw_PracownicyZeStanowiskiemTableAdapter.Fill(this.ksiegarniaDataSet3.vw_PracownicyZeStanowiskiem);


            this.stanowiskaTableAdapter.Fill(this.ksiegarniaDataSet3.Stanowiska);


            cmbStanowisko.DataSource = ksiegarniaDataSet3.Stanowiska;
            cmbStanowisko.DisplayMember = "NazwaStanowiska";
            cmbStanowisko.ValueMember = "IDStanowisko";

        }



        private void dgvPracownicy_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPracownicy.Rows[e.RowIndex];
                txbImie.Text = row.Cells["ImieDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                txbNazwisko.Text = row.Cells["NazwiskoDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                txbEmail.Text = row.Cells["EmailDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                txbTelefon.Text = row.Cells["TelefonDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                dtpZatrudnienie.Text = row.Cells["DataZatrudnieniaDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
                cmbStanowisko.Text = row.Cells["NazwaStanowiskaDataGridViewTextBoxColumn"].Value?.ToString() ?? string.Empty;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string Imie = txbImie.Text.Trim();
            string Nazwisko = txbNazwisko.Text.Trim();
            string Email = txbEmail.Text.Trim();
            string Telefon = txbTelefon.Text.Trim();
            DateTime DataZatrudnienia = dtpZatrudnienie.Value;
            object selectedStanowisko = cmbStanowisko.SelectedValue;

            if (string.IsNullOrEmpty(Imie) || string.IsNullOrEmpty(Nazwisko) ||
                string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Telefon) ||
                selectedStanowisko == null)
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.");
                return;
            }

            try
            {
                DataRow newRow = ksiegarniaDataSet3.Tables["Pracownicy"].NewRow();
                newRow["Imie"] = Imie;
                newRow["Nazwisko"] = Nazwisko;
                newRow["Email"] = Email;
                newRow["Telefon"] = Telefon;
                newRow["DataZatrudnienia"] = DataZatrudnienia;
                newRow["IDStanowisko"] = selectedStanowisko;
                


                ksiegarniaDataSet3.Tables["Pracownicy"].Rows.Add(newRow);
                pracownicyTableAdapter.Update(ksiegarniaDataSet3.Pracownicy);

                MessageBox.Show("Pracownik został dodany.");
                OdswiezDane();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas dodawania pracownika: " + ex.Message);
            }
        }

        private void OdswiezDane()
        {
            ksiegarniaDataSet3.Tables["vw_PracownicyZeStanowiskiem"].Clear();
            vw_PracownicyZeStanowiskiemTableAdapter.Fill(ksiegarniaDataSet3.vw_PracownicyZeStanowiskiem);
        }
    }
}
