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
            ZaładujDane();


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
            cmbKategorie.Items.Add("Wszystkie"); // Dodaj opcję "Wszystkie" na początku

            // Zakładam, że masz kolumnę NazwaKategorii w widoku
            foreach (DataGridViewColumn column in dgvZasoby.Columns)
            {
                if (column.Visible) // Jeśli chcesz tylko widoczne kolumny
                {
                    cmbKategorie.Items.Add(column.HeaderText); // Dodaj nazwę kolumny do ComboBox
                }
            }

            if (cmbKategorie.Items.Count > 0)
                cmbKategorie.SelectedIndex = 0; // Ustaw "Wszystkie" na domyślną kategorię
        }


      
        private void FiltrujDane()
        {
            string filtr = "";

            // Filtr po tytule
            if (!string.IsNullOrWhiteSpace(txbWyszukiwarka.Text))
            {
                filtr += $"Tytul LIKE '%{txbWyszukiwarka.Text.Replace("'", "''")}%'"; // Escape apostrofów
            }

            // Filtr po kategorii (jeśli wybrano coś innego niż "Wszystkie")
            if (cmbKategorie.SelectedItem != null && cmbKategorie.SelectedItem.ToString() != "Wszystkie")
            {
                if (!string.IsNullOrEmpty(filtr)) filtr += " AND ";
                filtr += $"NazwaKategorii = '{cmbKategorie.SelectedItem.ToString().Replace("'", "''")}'";
            }

            // Ustawienie filtra w BindingSource
            vwZasobyPelneBindingSource1.Filter = filtr;
        }






        private void ZaładujDane()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Ksiegarnia;Integrated Security=True"))
            {
                // Używamy widoku vw_Zasoby_Rozszerzone
                string sql = @"SELECT z.Tytul, z.RokWydania, z.Ilosc,
                              k.NazwaKategorii, w.Nazwa AS Wydawnictwo,
                              a.Imie + ' ' + a.Nazwisko AS Autor,
                              z.DataUtworzenia
                       FROM vw_Zasoby_Rozszerzone z
                       LEFT JOIN Kategoria k ON z.IDKategoria = k.IDKategoria
                       LEFT JOIN Wydawnictwo w ON z.IDWydawnictwo = w.IDWydawnictwo
                       LEFT JOIN Zasoby_Autorzy za ON z.Id = za.IdZasobu
                       LEFT JOIN Autorzy a ON za.IdAutora = a.Id";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Zasoby");

                // Przypisujemy dane z DataSet do BindingSource
                vwZasobyPelneBindingSource1.DataSource = ds.Tables["Zasoby"];
                dgvZasoby.DataSource = vwZasobyPelneBindingSource1; // Powiązanie z DataGridView
            }
        }




        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            FiltrujDane();

        }

       
    }
}


   





