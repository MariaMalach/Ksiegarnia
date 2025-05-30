using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Ksiegarnia2.Forms
{
    public partial class DodajZasoby : Form
    {
        private SqlDataAdapter zasobyAdapter;
        private SqlCommandBuilder zasobyCommandBuilder;

        private SqlDataAdapter autorzyAdapter;
        private SqlCommandBuilder autorzyCommandBuilder;

        private SqlDataAdapter zasobyAutorzyAdapter;
        private SqlCommandBuilder zasobyAutorzyCommandBuilder;

        private DataSet zasobyDataSet;
        private SqlConnection conn;

        public DodajZasoby()
        {
            InitializeComponent();
            InitAdapter();
            InitAutorzyAdapter();
            InitZasobyAutorzyAdapter();
            dgvZasoby.CellClick += dgvZasoby_CellContentClick;
        }

        private void InitAdapter()
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=Ksiegarnia;Integrated Security=True");

            string selectZasoby = "SELECT * FROM vw_Zasoby_Autorzy_Szcegoly";
            zasobyAdapter = new SqlDataAdapter(selectZasoby, conn);
            zasobyAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            zasobyCommandBuilder = new SqlCommandBuilder(zasobyAdapter);

            zasobyDataSet = new DataSet();
            zasobyAdapter.Fill(zasobyDataSet, "vw_Zasoby_Autorzy_Szcegoly");
            dgvZasoby.DataSource = zasobyDataSet.Tables["vw_Zasoby_Autorzy_Szcegoly"];
        }

        private void InitAutorzyAdapter()
        {
            string selectAutorzy = "SELECT * FROM Autorzy";
            autorzyAdapter = new SqlDataAdapter(selectAutorzy, conn);
            autorzyAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            autorzyCommandBuilder = new SqlCommandBuilder(autorzyAdapter);

            autorzyAdapter.Fill(zasobyDataSet, "Autorzy");
        }

        private void InitZasobyAutorzyAdapter()
        {
            string selectZA = "SELECT * FROM Zasoby_Autorzy";
            zasobyAutorzyAdapter = new SqlDataAdapter(selectZA, conn);
            zasobyAutorzyAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            zasobyAutorzyCommandBuilder = new SqlCommandBuilder(zasobyAutorzyAdapter);

            zasobyAutorzyAdapter.Fill(zasobyDataSet, "Zasoby_Autorzy");
        }

        private void btnDodaj_Click_1(object sender, EventArgs e)
        {
            string tytul = txbTytul.Text.Trim();
            string rokText = textRokWydania.Text.Trim();
            string iloscText = textIlosc.Text.Trim();
            string cenaText = textBoxCena.Text.Trim();
            string kategoria = textBoxKategoria.Text.Trim();
            string wydawnictwo = textBoxWydawnictwo.Text.Trim();
            string autorzyText = textBoxAutorzy.Text.Trim();

            if (new[] { tytul, rokText, iloscText, cenaText, kategoria, wydawnictwo, autorzyText }
                .Any(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.");
                return;
            }

            if (!int.TryParse(rokText, out int rok) || rok < 1800 || rok > DateTime.Now.Year)
            {
                MessageBox.Show("Rok wydania musi być liczbą z przedziału 1800-aktualny rok.");
                return;
            }

            if (!int.TryParse(iloscText, out int ilosc) || ilosc < 1 || ilosc > 1000)
            {
                MessageBox.Show("Ilość dodawanego zasobu musi wynosić między 1 a 1000.");
                return;
            }

            if (!decimal.TryParse(cenaText, out decimal cena) || cena < 0)
            {
                MessageBox.Show("Cena musi być prawidłową, nieujemną wartością liczbową.");
                return;
            }

            var autorzyLista = autorzyText.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(a => a.Trim())
                                           .ToList();
            if (!autorzyLista.Any())
            {
                MessageBox.Show("Proszę podać przynajmniej jednego autora.");
                return;
            }

            List<int> autorIds = new List<int>();

            foreach (var pelne in autorzyLista)
            {
                var czesci = pelne.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (czesci.Length < 2)
                {
                    MessageBox.Show($"Niepoprawny format autora: '{pelne}'. Użyj 'Imię Nazwisko'.");
                    return;
                }
                string imie = czesci[0];
                string nazwisko = string.Join(" ", czesci.Skip(1));

                var existing = zasobyDataSet.Tables["Autorzy"].AsEnumerable()
                    .FirstOrDefault(r => r.Field<string>("Imie") == imie && r.Field<string>("Nazwisko") == nazwisko);

                int idAutora;
                if (existing != null)
                {
                    idAutora = existing.Field<int>("Id");
                }
                else
                {
                    DataRow newAutor = zasobyDataSet.Tables["Autorzy"].NewRow();
                    newAutor["Imie"] = imie;
                    newAutor["Nazwisko"] = nazwisko;
                    zasobyDataSet.Tables["Autorzy"].Rows.Add(newAutor);
                    autorzyAdapter.Update(zasobyDataSet, "Autorzy");

                    zasobyDataSet.Tables["Autorzy"].Clear();
                    autorzyAdapter.Fill(zasobyDataSet, "Autorzy");
                    existing = zasobyDataSet.Tables["Autorzy"].AsEnumerable()
                        .First(r => r.Field<string>("Imie") == imie && r.Field<string>("Nazwisko") == nazwisko);
                    idAutora = existing.Field<int>("Id");
                }

                autorIds.Add(idAutora);
            }

            try
            {
                var tblZasoby = zasobyDataSet.Tables["Zasoby"];
                DataRow newZasob = tblZasoby.NewRow();
                newZasob["Tytul"] = tytul;
                newZasob["RokWydania"] = rok;
                newZasob["Ilosc"] = ilosc;
                newZasob["Kategoria"] = kategoria;
                newZasob["Wydawnictwo"] = wydawnictwo;
                newZasob["DataUtworzenia"] = DateTime.Now;
                newZasob["Cena"] = cena;
                tblZasoby.Rows.Add(newZasob);
                zasobyAdapter.Update(zasobyDataSet, "Zasoby");

                tblZasoby.Clear();
                zasobyAdapter.Fill(zasobyDataSet, "Zasoby");
                int newIdZasobu = tblZasoby.AsEnumerable()
                    .OrderByDescending(r => r.Field<int>("Id"))
                    .First()
                    .Field<int>("Id");

                var tblZA = zasobyDataSet.Tables["Zasoby_Autorzy"];
                foreach (var aid in autorIds)
                {
                    DataRow newZA = tblZA.NewRow();
                    newZA["IdZasobu"] = newIdZasobu;
                    newZA["IdAutora"] = aid;
                    tblZA.Rows.Add(newZA);
                }
                zasobyAutorzyAdapter.Update(zasobyDataSet, "Zasoby_Autorzy");

                MessageBox.Show("Zasób oraz autorzy zostały dodani.");
                OdswiezDane();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas dodawania: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvZasoby.CurrentRow == null)
            {
                MessageBox.Show("Wybierz zasób do edycji.");
                return;
            }

            int idx = dgvZasoby.CurrentRow.Index;
            DataRow row = zasobyDataSet.Tables["Zasoby"].Rows[idx];
            int idZasobu = row.Field<int>("Id");

            string tytul = txbTytul.Text.Trim();
            string rokText = textRokWydania.Text.Trim();
            string iloscText = textIlosc.Text.Trim();
            string cenaText = textBoxCena.Text.Trim();
            string kategoria = textBoxKategoria.Text.Trim();
            string wydawnictwo = textBoxWydawnictwo.Text.Trim();
            string autorzyText = textBoxAutorzy.Text.Trim();

            if (new[] { tytul, rokText, iloscText, cenaText, kategoria, wydawnictwo, autorzyText }
                .Any(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.");
                return;
            }
            if (!int.TryParse(rokText, out int rok) || rok < 1800 || rok > DateTime.Now.Year)
            {
                MessageBox.Show("Rok wydania musi być liczbą z przedziału 1800-aktualny rok.");
                return;
            }
            if (!int.TryParse(iloscText, out int ilosc) || ilosc < 1 || ilosc > 1000)
            {
                MessageBox.Show("Ilość musi być między 1 a 1000.");
                return;
            }
            if (!decimal.TryParse(cenaText, out decimal cena) || cena < 0)
            {
                MessageBox.Show("Cena musi być prawidłową, nieujemną wartością.");
                return;
            }

            
            row["Tytul"] = tytul;
            row["RokWydania"] = rok;
            row["Ilosc"] = ilosc;
            row["Kategoria"] = kategoria;
            row["Wydawnictwo"] = wydawnictwo;
            row["Cena"] = cena;

            var autorzyLista = autorzyText.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                           .Select(a => a.Trim()).ToList();
            List<int> autorIds = new List<int>();
            foreach (var pelne in autorzyLista)
            {
                var parts = pelne.Split(' ');
                if (parts.Length < 2)
                {
                    MessageBox.Show($"Niepoprawny format autora: {pelne}.");
                    return;
                }
                string imie = parts[0];
                string nazwisko = string.Join(" ", parts.Skip(1));
                var existing = zasobyDataSet.Tables["Autorzy"].AsEnumerable()
                    .FirstOrDefault(r => r.Field<string>("Imie") == imie && r.Field<string>("Nazwisko") == nazwisko);
                int idAutora;
                if (existing != null) idAutora = existing.Field<int>("Id");
                else
                {
                    var newAutor = zasobyDataSet.Tables["Autorzy"].NewRow();
                    newAutor["Imie"] = imie;
                    newAutor["Nazwisko"] = nazwisko;
                    zasobyDataSet.Tables["Autorzy"].Rows.Add(newAutor);
                    autorzyAdapter.Update(zasobyDataSet, "Autorzy");
                    zasobyDataSet.Tables["Autorzy"].Clear(); autorzyAdapter.Fill(zasobyDataSet, "Autorzy");
                    existing = zasobyDataSet.Tables["Autorzy"].AsEnumerable()
                        .First(r => r.Field<string>("Imie") == imie && r.Field<string>("Nazwisko") == nazwisko);
                    idAutora = existing.Field<int>("Id");
                }
                autorIds.Add(idAutora);
            }

            try
            {
                
                zasobyAdapter.Update(zasobyDataSet, "Zasoby");

                var tblZA = zasobyDataSet.Tables["Zasoby_Autorzy"];
                var toDelete = tblZA.AsEnumerable().Where(r => r.Field<int>("IdZasobu") == idZasobu).ToList();
                foreach (var d in toDelete) d.Delete();
                zasobyAutorzyAdapter.Update(zasobyDataSet, "Zasoby_Autorzy");

                foreach (var aid in autorIds)
                {
                    var newZA = tblZA.NewRow();
                    newZA["IdZasobu"] = idZasobu;
                    newZA["IdAutora"] = aid;
                    tblZA.Rows.Add(newZA);
                }
                zasobyAutorzyAdapter.Update(zasobyDataSet, "Zasoby_Autorzy");

                MessageBox.Show("Zasób i autorzy zostali zaktualizowani.");
                OdswiezDane();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd przy aktualizacji: " + ex.Message);
            }
        }

        private void OdswiezDane()
        {
            var tbl = zasobyDataSet.Tables["Zasoby"];
            tbl.Clear();
            zasobyAdapter.Fill(zasobyDataSet, "Zasoby");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvZasoby_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = zasobyDataSet.Tables["Zasoby"].Rows[e.RowIndex];
            txbTytul.Text = row.Field<string>("Tytul");
            textRokWydania.Text = row.Field<int>("RokWydania").ToString();
            textIlosc.Text = row.Field<int>("Ilosc").ToString();
            textBoxCena.Text = row.Field<decimal>("Cena").ToString();
            textBoxKategoria.Text = row.Field<string>("Kategoria");
            textBoxWydawnictwo.Text = row.Field<string>("Wydawnictwo");

            int idZasobu = row.Field<int>("Id");
            var powiazania = zasobyDataSet.Tables["Zasoby_Autorzy"].AsEnumerable()
                .Where(r => r.Field<int>("IdZasobu") == idZasobu);

            var imionaNazwiska = new List<string>();
            foreach (var p in powiazania)
            {
                int idAutora = p.Field<int>("IdAutora");
                var autorRow = zasobyDataSet.Tables["Autorzy"].AsEnumerable()
                    .FirstOrDefault(a => a.Field<int>("Id") == idAutora);
                if (autorRow != null)
                {
                    string imie = autorRow.Field<string>("Imie");
                    string nazwisko = autorRow.Field<string>("Nazwisko");
                    imionaNazwiska.Add($"{imie} {nazwisko}");
                }
            }
            textBoxAutorzy.Text = string.Join(", ", imionaNazwiska);


        }

        private void dgvZasoby_CellContentClick2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                string header = dgvZasoby.Columns[e.ColumnIndex].HeaderText;
                MessageBox.Show("Kliknięto kolumnę: " + header);
            }
        }

        private void DodajZasoby_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet.vw_Zasoby_Autorzy_Szcegoly' . Możesz go przenieść lub usunąć.
            this.vw_Zasoby_Autorzy_SzcegolyTableAdapter.Fill(this.ksiegarniaDataSet.vw_Zasoby_Autorzy_Szcegoly);

        }
    }
}
