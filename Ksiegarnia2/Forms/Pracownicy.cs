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
    public partial class Pracownicy : Form
    {
        public Pracownicy()
        {
            InitializeComponent();
        }

        private void Pracownicy_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet1.Pracownicy' . Możesz go przenieść lub usunąć.
            this.pracownicyTableAdapter.Fill(this.ksiegarniaDataSet1.Pracownicy);

        }
    }
}
