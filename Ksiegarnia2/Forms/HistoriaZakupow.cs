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
    public partial class HistoriaZakupow : Form
    {
        public HistoriaZakupow()
        {
            InitializeComponent();
        }

        private void HistoriaZakupow_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet3.HistoriaZakupow' . Możesz go przenieść lub usunąć.
            this.historiaZakupowTableAdapter.Fill(this.ksiegarniaDataSet3.HistoriaZakupow);

        }
    }
}
