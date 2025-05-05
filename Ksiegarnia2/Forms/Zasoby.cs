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
            SchemaDataLoad();


        }

        private void Zasoby_Load(object sender, EventArgs e)
        {



            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet5.vw_Zasoby_Pelne' . Możesz go przenieść lub usunąć.
            this.vw_Zasoby_PelneTableAdapter.Fill(this.ksiegarniaDataSet5.vw_Zasoby_Pelne);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet.Zasoby_Autorzy' . Możesz go przenieść lub usunąć.
            this.zasoby_AutorzyTableAdapter.Fill(this.ksiegarniaDataSet.Zasoby_Autorzy);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet.Zasoby' . Możesz go przenieść lub usunąć.
            this.zasobyTableAdapter.Fill(this.ksiegarniaDataSet.Zasoby);

        }
        private void SchemaDataLoad()
        {

            cmbKategorie.Items.Clear();

            foreach (DataGridViewColumn column in dgvZasoby.Columns)
            {
                if (column.Visible) // jeśli chcesz tylko widoczne kolumny
                {
                    cmbKategorie.Items.Add(column.HeaderText); // lub column.DataPropertyName
                }
            }

            if (cmbKategorie.Items.Count > 0)
                cmbKategorie.SelectedIndex = 0;
        }

    

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.
        }
    }

}
   





