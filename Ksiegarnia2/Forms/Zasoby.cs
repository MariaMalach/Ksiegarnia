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
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet5.vw_Zasoby_Rozszerzone' . Możesz go przenieść lub usunąć.
            this.vw_Zasoby_RozszerzoneTableAdapter.Fill(this.ksiegarniaDataSet5.vw_Zasoby_Rozszerzone);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet5.vw_Zasoby_Pelne' . Możesz go przenieść lub usunąć.
            this.vw_Zasoby_PelneTableAdapter.Fill(this.ksiegarniaDataSet5.vw_Zasoby_Pelne);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet.Zasoby_Autorzy' . Możesz go przenieść lub usunąć.
            this.zasoby_AutorzyTableAdapter.Fill(this.ksiegarniaDataSet.Zasoby_Autorzy);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet.Zasoby' . Możesz go przenieść lub usunąć.
            this.zasobyTableAdapter.Fill(this.ksiegarniaDataSet.Zasoby);

        }
    }
}
