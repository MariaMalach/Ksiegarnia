using Ksiegarnia;
using Ksiegarnia.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksiegarnia2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZasoby_Click(object sender, EventArgs e)
        {
            Zasoby zasoby = new Zasoby();
            zasoby.Show();
            this.Hide();

        }

        
        
        private void btnZakupy_Click(object sender, EventArgs e)
        {
            Zakupy zakupy = new Zakupy();
            zakupy.Show();
            this.Hide();

        }



        private void btnHistoriaZakupow_Click(object sender, EventArgs e)
        {
            Transakcje historiaZakupow = new Transakcje();
            historiaZakupow.Show();
            this.Hide();

        }

        private void btnRaporty_Click(object sender, EventArgs e)
        {
            Raporty raporty = new Raporty();
            raporty.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pracownicy pracownicy = new Pracownicy();
            pracownicy.Show();
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
