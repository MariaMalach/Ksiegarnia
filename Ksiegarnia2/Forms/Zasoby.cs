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
using Ksiegarnia2.Forms;

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
            dgvZasoby.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvZasoby.AutoResizeColumns();
            dgvZasoby.AutoResizeRows();




        }

        private void Zasoby_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet9.vw_ZasobyAutorzyCeny' . Możesz go przenieść lub usunąć.
            this.vw_ZasobyAutorzyCenyTableAdapter.Fill(this.ksiegarniaDataSet9.vw_ZasobyAutorzyCeny);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet5.vw_Zasoby_Rozszerzone' . Możesz go przenieść lub usunąć.
            //this.vw_Zasoby_RozszerzoneTableAdapter.Fill(this.ksiegarniaDataSet5.vw_Zasoby_Rozszerzone);



            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet5.vw_Zasoby_Pelne' . Możesz go przenieść lub usunąć.
            //this.vw_Zasoby_PelneTableAdapter.Fill(this.ksiegarniaDataSet5.vw_Zasoby_Pelne);



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
            try
            {
                if (cmbKategorie.SelectedItem == null || string.IsNullOrWhiteSpace(txbWyszukiwarka.Text))
                {
                    vwZasobyPelneBindingSource1.RemoveFilter();
                    return;
                }

                string selectedColumn = cmbKategorie.SelectedItem.ToString();
                string searchText = txbWyszukiwarka.Text;

                var columnType = ((DataView)vwZasobyAutorzyCenyBindingSource.List).Table.Columns[selectedColumn].DataType;

                string filtr = "";

                if (columnType == typeof(string))
                {
                    filtr = $"{selectedColumn} LIKE '%{searchText}%'";
                }
                else if (columnType == typeof(int) || columnType == typeof(long) || columnType == typeof(short))
                {
                    if (int.TryParse(searchText, out int liczba))
                        filtr = $"{selectedColumn} = {liczba}";
                    else
                        throw new FormatException("Wprowadź poprawną liczbę.");
                }
                else if (columnType == typeof(DateTime))
                {
                    if (DateTime.TryParse(searchText, out DateTime data))
                        filtr = $"{selectedColumn} = '#{data:yyyy-MM-dd}#'";
                    else
                        throw new FormatException("Wprowadź poprawną datę.");
                }
                else
                {
                    filtr = $"{selectedColumn} = '{searchText}'";
                }

                vwZasobyAutorzyCenyBindingSource.Filter = filtr;

            }
            catch (EvaluateException)
            {
                MessageBox.Show("Nie można filtrować tej kolumny.", "Błąd filtrowania");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Nieprawidłowy format danych");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd");
            }
        }









        private DataSet ZaładujDane()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Ksiegarnia;Integrated Security=True"))
                {
                    string sql = @"SELECT 
    z.Tytul,
    STRING_AGG(a.Imie + ' ' + a.Nazwisko, ', ') AS Autorzy,
    c.Cena,
    z.RokWydania,
    z.Kategoria,
    z.Wydawnictwo
FROM Zasoby z
LEFT JOIN Zasoby_Autorzy za ON z.Id = za.IdZasobu
LEFT JOIN Autorzy a ON za.IdAutora = a.Id
LEFT JOIN Ceny c ON z.Id = c.IdZasobu
GROUP BY 
    z.Tytul,
    c.Cena,
    z.RokWydania,
    z.Kategoria,
    z.Wydawnictwo";

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Zasoby");


                    vwZasobyAutorzyCenyBindingSource.DataSource = ds.Tables["Zasoby"];
                    dgvZasoby.DataSource = vwZasobyAutorzyCenyBindingSource.DataSource;

                    return ds;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Błąd SQL: {ex.Message}", "Błąd połączenia z bazą danych");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd");
            }

            return null;
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
            vwZasobyAutorzyCenyBindingSource.RemoveFilter();
            txbWyszukiwarka.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajZasoby edycjaZasoby = new DodajZasoby();
            edycjaZasoby.Show();
        }
    }
}


   





