using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksiegarnia2.Forms
{
    public partial class DodajZasoby : Form
    {
        public DodajZasoby()
        {
            InitializeComponent();
            SqlDataAdapter adapter;
            //DataTable daneKategori = PobierzKategorieZBazy();
            DataSet ds = ZaładujDane();

        }
        private void FormDodawaniaZasobu_Load(object sender, EventArgs e)
        {
            var daneKategori = PobierzKategorieZBazy();
            WyswietlKategorie(daneKategori);
        }


        private DataTable PobierzKategorieZBazy()
        {
            DataTable dtKategorie = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Ksiegarnia;Integrated Security=True"))
                {
                    string sql = "SELECT IDKategoria, NazwaKategorii FROM Kategorie";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    adapter.Fill(dtKategorie);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobierania kategorii: " + ex.Message);
            }

            return dtKategorie;
        }


        private void WyswietlKategorie(DataTable dt)
        {
            comboBoxKatergoria.DataSource = dt;
            comboBoxKatergoria.DisplayMember = "NazwaKategorii"; // co użytkownik widzi
            comboBoxKatergoria.ValueMember = "IDKategoria";      // co my odczytujemy w kodzie
            comboBoxKatergoria.SelectedIndex = -1;               // brak wybranej pozycji na starcie
        }



        private void btnDodaj_Click_1(object sender, EventArgs e)
        {
            string tytul = txbTytul.Text.Trim();
            string rokText = textRokWydania.Text.Trim();
            string iloscText = textIlosc.Text.Trim();
            string kategoria = comboBoxKatergoria.SelectedItem?.ToString();
            string wydawnictwo = comboBoxWydawnictwo.SelectedItem?.ToString();

            // WALIDACJA
            if (string.IsNullOrEmpty(tytul))
            {
                MessageBox.Show("Tytuł nie może być pusty.");
                return;
            }

            if (!int.TryParse(rokText, out int rok) || rok < 1000 || rok > DateTime.Now.Year)
            {
                MessageBox.Show("Rok wydania musi być liczbą z zakresu 1000 - bieżący rok.");
                return;
            }

            if (!int.TryParse(iloscText, out int ilosc) || ilosc < 1 || ilosc > 1000)
            {
                MessageBox.Show("Ilość musi być liczbą od 1 do 1000.");
                return;
            }

            if (string.IsNullOrEmpty(kategoria))
            {
                MessageBox.Show("Wybierz kategorię.");
                return;
            }

            if (string.IsNullOrEmpty(wydawnictwo))
            {
                MessageBox.Show("Wybierz wydawnictwo.");
                return;
            }

            // MAPOWANIE KATEGORII
            Dictionary<string, int> mapaKategorii = new Dictionary<string, int>
    {
        { "Literatura", 1 },
        { "Nauka", 2 },
        { "Historia", 3 },
        { "Fantasy", 4 },
        { "Technologia", 5 }
    };

            Dictionary<string, int> mapaWydawnictw = new Dictionary<string, int>
    {
        { "Nowa Era", 1 },
        { "PWN", 2 },
        { "Znak", 3 }
    };

            if (!mapaKategorii.TryGetValue(kategoria, out int idKategoria) ||
                !mapaWydawnictw.TryGetValue(wydawnictwo, out int idWydawnictwo))
            {
                MessageBox.Show("Nieprawidłowa kategoria lub wydawnictwo.");
                return;
            }

            // DODAWANIE DO BAZY
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Ksiegarnia;Integrated Security=True"))
                {
                    conn.Open();

                    string sql = @"INSERT INTO Zasoby (Tytul, RokWydania, Ilosc, IDKategoria, IDWydawnictwo)
                           VALUES (@Tytul, @RokWydania, @Ilosc, @IDKategoria, @IDWydawnictwo)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Tytul", tytul);
                        cmd.Parameters.AddWithValue("@RokWydania", rok);
                        cmd.Parameters.AddWithValue("@Ilosc", ilosc);
                        cmd.Parameters.AddWithValue("@IDKategoria", idKategoria);
                        cmd.Parameters.AddWithValue("@IDWydawnictwo", idWydawnictwo);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                            MessageBox.Show("Dodano zasób pomyślnie.");
                        else
                            MessageBox.Show("Nie udało się dodać zasobu.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas dodawania do bazy: " + ex.Message);
            }
        
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxKatergoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DodajZasoby_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet5.vw_Zasoby_Pelne' . Możesz go przenieść lub usunąć.
            //this.vw_Zasoby_PelneTableAdapter.Fill(this.ksiegarniaDataSet5.vw_Zasoby_Pelne);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet5.Zasoby_Autorzy' . Możesz go przenieść lub usunąć.
            //this.zasoby_AutorzyTableAdapter.Fill(this.ksiegarniaDataSet5.Zasoby_Autorzy);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet5.Ceny' . Możesz go przenieść lub usunąć.
            //this.cenyTableAdapter.Fill(this.ksiegarniaDataSet5.Ceny);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet5.Zasoby' . Możesz go przenieść lub usunąć.
            //his.zasobyTableAdapter.Fill(this.ksiegarniaDataSet5.Zasoby);

        }

        private DataSet ZaładujDane()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Ksiegarnia;Integrated Security=True"))
                {
                    string sql = @"SELECT z.Tytul, z.RokWydania, z.Ilosc,
                              z.NazwaKategorii, z.NazwaWydawnictwa,
                              z.Autorzy,
                              z.DataUtworzenia
                           FROM vw_Zasoby_Pelne z";

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Zasoby");


                    vwZasobyPelneBindingSource1.DataSource = ds.Tables["Zasoby"];
                    dgvZasoby.DataSource = vwZasobyPelneBindingSource1;

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
    }
}
