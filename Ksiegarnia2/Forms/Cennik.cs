using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksiegarnia.Forms
{
    public partial class Cennik : Form
    {
        public Cennik()
        {
            InitializeComponent();
            dgvCennik.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCennik.AutoResizeColumns();
            dgvCennik.AutoResizeRows();
        }

        private void Cennik_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet7.vw_Ceny_Rozszerzone' . Możesz go przenieść lub usunąć.
            this.vw_Ceny_RozszerzoneTableAdapter.Fill(this.ksiegarniaDataSet7.vw_Ceny_Rozszerzone);
           

        }
    }
}
