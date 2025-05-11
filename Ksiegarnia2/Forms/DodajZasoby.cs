using Ksiegarnia;
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
            dgvZasoby.CellClick += dgvZasoby_CellClick;

        }

        public void OdswiezDane()
        {
            DataSet ds = ZaładujDane(); // lub jakikolwiek reload danych
            dgvZasoby.DataSource = ds.Tables["Zasoby"];
            dgvZasoby.Refresh(); // nie zawsze konieczne, ale może pomóc
        }


        private void btnDodaj_Click_1(object sender, EventArgs e)
        {
            string tytul = txbTytul.Text.Trim();
            string rokText = textRokWydania.Text.Trim();
            string iloscText = textIlosc.Text.Trim();
            string kategoria = textBoxKategoria.Text.Trim();
            string wydawnictwo = textBoxWydawnictwo.Text.Trim();
            string autorzyText = textBoxAutorzy.Text.Trim();
            string cenaText = textBoxCena.Text.Trim();

            if (string.IsNullOrEmpty(tytul) || string.IsNullOrEmpty(rokText) ||
                string.IsNullOrEmpty(kategoria) || string.IsNullOrEmpty(wydawnictwo) ||
                string.IsNullOrEmpty(autorzyText) || string.IsNullOrEmpty(cenaText) ||
                    string.IsNullOrEmpty(iloscText))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.");
                return;
            }

            if (!int.TryParse(rokText, out int rok) || rok < 1800 || rok > DateTime.Now.Year)
            {
                MessageBox.Show("Rok wydania musi być poprawną liczbą.");
                return;
            }
            if (!int.TryParse(iloscText, out int ilosc) || ilosc < 1 || ilosc > 1000)
            {
                MessageBox.Show("Ilość dodawanego zasobu musi wynosić między 1 a 1000.");
                return;
            }

            if (!decimal.TryParse(cenaText, out decimal cena) || cena <= 0)
            {
                MessageBox.Show("Cena musi być poprawną dodatnią liczbą.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Ksiegarnia;Integrated Security=True"))
                {
                    conn.Open();

                    // Dodaj zasób
                    string insertZasob = @"INSERT INTO Zasoby (Tytul, RokWydania,Ilosc, Kategoria, Wydawnictwo, DataUtworzenia)
                                   VALUES (@Tytul, @RokWydania, @Ilosc, @Kategoria, @Wydawnictwo, @DataUtworzenia);
                                   SELECT SCOPE_IDENTITY();";

                    int idZasobu;
                    using (SqlCommand cmd = new SqlCommand(insertZasob, conn))
                    {
                        cmd.Parameters.AddWithValue("@Tytul", tytul);
                        cmd.Parameters.AddWithValue("@RokWydania", rok);
                        cmd.Parameters.AddWithValue("@Ilosc", ilosc);
                        cmd.Parameters.AddWithValue("@Kategoria", kategoria);
                        cmd.Parameters.AddWithValue("@Wydawnictwo", wydawnictwo);
                        cmd.Parameters.AddWithValue("@DataUtworzenia", DateTime.Now);


                        idZasobu = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Dodaj cenę
                    string insertCena = @"INSERT INTO Ceny (IdZasobu, Cena) VALUES (@IdZasobu, @Cena)";
                    using (SqlCommand cmdCena = new SqlCommand(insertCena, conn))
                    {
                        cmdCena.Parameters.AddWithValue("@IdZasobu", idZasobu);
                        cmdCena.Parameters.AddWithValue("@Cena", cena);
                        cmdCena.ExecuteNonQuery();
                    }

                    // Dodaj autorów
                    string[] autorzy = autorzyText.Split(',');
                    foreach (string autor in autorzy)
                    {
                        string[] imieNazwisko = autor.Trim().Split(' ');

                        if (imieNazwisko.Length < 2)
                        {
                            MessageBox.Show($"Niepoprawny format autora: {autor}. Wymagany format: Imię Nazwisko");
                            continue;
                        }

                        string imie = imieNazwisko[0].Trim();
                        string nazwisko = string.Join(" ", imieNazwisko.Skip(1)).Trim();

                        int idAutora;

                        // Sprawdź, czy autor już istnieje
                        string checkAutor = @"SELECT Id FROM Autorzy WHERE Imie = @Imie AND Nazwisko = @Nazwisko";
                        using (SqlCommand checkCmd = new SqlCommand(checkAutor, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@Imie", imie);
                            checkCmd.Parameters.AddWithValue("@Nazwisko", nazwisko);
                            object result = checkCmd.ExecuteScalar();

                            if (result != null)
                            {
                                idAutora = Convert.ToInt32(result);
                            }
                            else
                            {
                                // Dodaj autora
                                string insertAutor = @"INSERT INTO Autorzy (Imie, Nazwisko) VALUES (@Imie, @Nazwisko);
                                               SELECT SCOPE_IDENTITY();";
                                using (SqlCommand insertCmd = new SqlCommand(insertAutor, conn))
                                {
                                    insertCmd.Parameters.AddWithValue("@Imie", imie);
                                    insertCmd.Parameters.AddWithValue("@Nazwisko", nazwisko);
                                    idAutora = Convert.ToInt32(insertCmd.ExecuteScalar());
                                }
                            }
                        }

                        // Dodaj relację zasób-autor
                        string insertZA = @"INSERT INTO Zasoby_Autorzy (IdZasobu, IdAutora) VALUES (@IdZasobu, @IdAutora)";
                        using (SqlCommand cmdZA = new SqlCommand(insertZA, conn))
                        {
                            cmdZA.Parameters.AddWithValue("@IdZasobu", idZasobu);
                            cmdZA.Parameters.AddWithValue("@IdAutora", idAutora);
                            cmdZA.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Zasób został dodany pomyślnie.");
                    // Załaduj dane ponownie (w formularzu głównym)
            var formZasoby = Application.OpenForms["Zasoby"] as Zasoby;
            //formZasoby?.OdswiezDane(); // metoda do odświeżania tabeli
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas dodawania zasobu: " + ex.Message);
            }

            
        }
        private void dgvZasoby_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvZasoby.Rows[e.RowIndex];

                txbTytul.Text = row.Cells["Tytul"].Value?.ToString();
                textBoxAutorzy.Text = row.Cells["Autorzy"].Value?.ToString();
                textBoxCena.Text = row.Cells["Cena"].Value?.ToString();
                textRokWydania.Text = row.Cells["RokWydania"].Value?.ToString();
                textBoxKategoria.Text = row.Cells["Kategoria"].Value?.ToString();
                textBoxWydawnictwo.Text = row.Cells["Wydawnictwo"].Value?.ToString();
                // Załóżmy, że 'Ilosc' to ukryta kolumna lub nie jest w widoku – pomijasz ją, chyba że dodasz do zapytania SQL
                aktualnieEdytowanyId = Convert.ToInt32(row.Cells["Id"].Value);

            }
        }

        private int? aktualnieEdytowanyId = null;


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
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet9.vw_ZasobyAutorzyCeny' . Możesz go przenieść lub usunąć.
            this.vw_ZasobyAutorzyCenyTableAdapter.Fill(this.ksiegarniaDataSet9.vw_ZasobyAutorzyCeny);
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
                    dgvZasoby.DataSource = vwZasobyAutorzyCenyBindingSource;

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (aktualnieEdytowanyId == null)
            {
                MessageBox.Show("Wybierz zasób do edycji.");
                return;
            }

            string tytul = txbTytul.Text.Trim();
            string rokText = textRokWydania.Text.Trim();
            string iloscText = textIlosc.Text.Trim();
            string kategoria = textBoxKategoria.Text.Trim();
            string wydawnictwo = textBoxWydawnictwo.Text.Trim();
            string autorzyText = textBoxAutorzy.Text.Trim();
            string cenaText = textBoxCena.Text.Trim();

            // Walidacja identyczna jak przy dodawaniu...

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Ksiegarnia;Integrated Security=True"))
                {
                    conn.Open();

                    // 1. Edytuj zasób
                    string updateZasob = @"UPDATE Zasoby SET Tytul=@Tytul, RokWydania=@RokWydania, Kategoria=@Kategoria, Wydawnictwo=@Wydawnictwo WHERE Id=@IdZasobu";
                    using (SqlCommand cmd = new SqlCommand(updateZasob, conn))
                    {
                        cmd.Parameters.AddWithValue("@Tytul", tytul);
                        cmd.Parameters.AddWithValue("@RokWydania", int.Parse(rokText));
                        cmd.Parameters.AddWithValue("@Kategoria", kategoria);
                        cmd.Parameters.AddWithValue("@Wydawnictwo", wydawnictwo);
                        cmd.Parameters.AddWithValue("@IdZasobu", aktualnieEdytowanyId.Value);
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Edytuj cenę
                    string updateCena = @"UPDATE Ceny SET Cena=@Cena WHERE IdZasobu=@IdZasobu";
                    using (SqlCommand cmd = new SqlCommand(updateCena, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cena", decimal.Parse(cenaText));
                        cmd.Parameters.AddWithValue("@IdZasobu", aktualnieEdytowanyId.Value);
                        cmd.ExecuteNonQuery();
                    }

                    // 3. (Opcjonalnie) usuń i dodaj autorów od nowa
                    string deleteAutorzy = "DELETE FROM Zasoby_Autorzy WHERE IdZasobu = @IdZasobu";
                    using (SqlCommand cmd = new SqlCommand(deleteAutorzy, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdZasobu", aktualnieEdytowanyId.Value);
                        cmd.ExecuteNonQuery();
                    }

                    string[] autorzy = autorzyText.Split(',');
                    foreach (string autor in autorzy)
                    {
                        string[] imNaz = autor.Trim().Split(' ');
                        if (imNaz.Length < 2) continue;
                        string imie = imNaz[0];
                        string nazwisko = string.Join(" ", imNaz.Skip(1));

                        int idAutora;
                        string checkAutor = @"SELECT Id FROM Autorzy WHERE Imie = @Imie AND Nazwisko = @Nazwisko";
                        using (SqlCommand cmd = new SqlCommand(checkAutor, conn))
                        {
                            cmd.Parameters.AddWithValue("@Imie", imie);
                            cmd.Parameters.AddWithValue("@Nazwisko", nazwisko);
                            object result = cmd.ExecuteScalar();

                            if (result != null)
                                idAutora = Convert.ToInt32(result);
                            else
                            {
                                string insertAutor = "INSERT INTO Autorzy (Imie, Nazwisko) VALUES (@Imie, @Nazwisko); SELECT SCOPE_IDENTITY();";
                                using (SqlCommand cmd2 = new SqlCommand(insertAutor, conn))
                                {
                                    cmd2.Parameters.AddWithValue("@Imie", imie);
                                    cmd2.Parameters.AddWithValue("@Nazwisko", nazwisko);
                                    idAutora = Convert.ToInt32(cmd2.ExecuteScalar());
                                }
                            }
                        }

                        string insertZA = @"INSERT INTO Zasoby_Autorzy (IdZasobu, IdAutora) VALUES (@IdZasobu, @IdAutora)";
                        using (SqlCommand cmd = new SqlCommand(insertZA, conn))
                        {
                            cmd.Parameters.AddWithValue("@IdZasobu", aktualnieEdytowanyId.Value);
                            cmd.Parameters.AddWithValue("@IdAutora", idAutora);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Zasób zaktualizowany.");
                    OdswiezDane();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas edycji: " + ex.Message);
            }
        }
    }
}
