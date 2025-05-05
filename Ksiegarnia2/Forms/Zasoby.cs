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
using Ksiegarnia2;

namespace Ksiegarnia
{
    public partial class Zasoby : Form
    {
        SqlDataAdapter adapter;
        
        public Zasoby()
        {
            InitializeComponent();
            SchemaDataLoad();
            DataSet ds = ZaładujDane();
            dgvZasoby.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;



        }

        private void Zasoby_Load(object sender, EventArgs e)
        {



            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet5.vw_Zasoby_Pelne' . Możesz go przenieść lub usunąć.
            this.vw_Zasoby_PelneTableAdapter.Fill(this.ksiegarniaDataSet5.vw_Zasoby_Pelne);
            
      

        }
        private void SchemaDataLoad()
        {
            cmbKategorie.Items.Clear();
            

            foreach (DataGridViewColumn column in dgvZasoby.Columns)
            {
                if (column.Visible) // tylko widoczne kolumny
                {
                    cmbKategorie.Items.Add(column.HeaderText); // Uzupełnianie nazwami kolumn ComboBoxa
                }
            }
        }



        private void FiltrujDane()
        {
            if (cmbKategorie.SelectedItem == null || string.IsNullOrWhiteSpace(txbWyszukiwarka.Text))
            {
                vwZasobyPelneBindingSource1.RemoveFilter();
                return;
            }

            string selectedColumn = cmbKategorie.SelectedItem.ToString();
            string searchText = txbWyszukiwarka.Text.Trim().Replace("'", "''");

            // Pobierz typ kolumny
            var columnType = ((DataView)vwZasobyPelneBindingSource1.List).Table.Columns[selectedColumn].DataType;

            string filtr = "";

            if (columnType == typeof(string))
            {
                filtr = $"{selectedColumn} LIKE '%{searchText}%'";
            }
            else if (columnType == typeof(int) || columnType == typeof(long) || columnType == typeof(short))
            {
                if (int.TryParse(searchText, out int liczba))
                {
                    filtr = $"{selectedColumn} = {liczba}";
                }
                else
                {
                    MessageBox.Show("Wprowadź poprawną liczbę.", "Błąd");
                    return;
                }
            }
            else if (columnType == typeof(DateTime))
            {
                if (DateTime.TryParse(searchText, out DateTime data))
                {
                    filtr = $"{selectedColumn} = '#{data:yyyy-MM-dd}#'";
                }
                else
                {
                    MessageBox.Show("Wprowadź poprawną datę.", "Błąd");
                    return;
                }
            }
            else
            {
                filtr = $"{selectedColumn} = '{searchText}'"; // fallback
            }

            vwZasobyPelneBindingSource1.Filter = filtr;
        }








        private DataSet ZaładujDane()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Ksiegarnia;Integrated Security=True"))
            {
                // Używamy widoku vw_Zasoby_Rozszerzone
                string sql = @"SELECT z.Tytul, z.RokWydania, z.Ilosc,
                              z.NazwaKategorii, z.NazwaWydawnictwa,
                              z.Autorzy,
                              z.DataUtworzenia
                       FROM vw_Zasoby_Pelne z";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Zasoby");

                return ds;
                
            }
        }




        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            FiltrujDane();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vwZasobyPelneBindingSource1.RemoveFilter();
            txbWyszukiwarka.Clear();
        }
    }
}


   





