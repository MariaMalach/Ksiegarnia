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
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet3.vw_PracownicyZeStanowiskiem' . Możesz go przenieść lub usunąć.
            this.vw_PracownicyZeStanowiskiemTableAdapter.Fill(this.ksiegarniaDataSet3.vw_PracownicyZeStanowiskiem);

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
            }
        }
    }
}
