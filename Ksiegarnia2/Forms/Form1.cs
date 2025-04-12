using Ksiegarnia;
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
        }
    }
}
