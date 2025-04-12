using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Ksiegarnia
{
    public partial class Zasoby : Form
    {
        SqlDataAdapter adapter;
        DataSet ds;
        public Zasoby()
        {
            InitializeComponent();
        }

        private void Zasoby_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * From Zasoby");
        }
    }
}
