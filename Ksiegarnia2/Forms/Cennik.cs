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
        }

        private void Cennik_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet4.Ceny' . Możesz go przenieść lub usunąć.
            this.cenyTableAdapter.Fill(this.ksiegarniaDataSet4.Ceny);

        }
    }
}
