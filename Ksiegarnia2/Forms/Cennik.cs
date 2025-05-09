using Ksiegarnia2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksiegarnia.Forms
{
    public partial class Cennik : Form
    {
        public Cennik()
        {
            InitializeComponent();
            dgvCennik.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCennik.AutoResizeColumns();
            dgvCennik.AutoResizeRows();
            SchemaDataLoad();
        }

        private void Cennik_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet7.vw_Ceny_Rozszerzone' . Możesz go przenieść lub usunąć.
            this.vw_Ceny_RozszerzoneTableAdapter.Fill(this.ksiegarniaDataSet7.vw_Ceny_Rozszerzone);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vwCenyRozszerzoneBindingSource.RemoveFilter();
            txbWyszukiwarkaCeny.Clear();
        }

        private void FiltrujDane()
        {
            try
            {
                if (cmbKategorieCeny.SelectedItem == null || string.IsNullOrWhiteSpace(txbWyszukiwarkaCeny.Text))
                {
                    vwCenyRozszerzoneBindingSource.RemoveFilter();
                    return;
                }

                string selectedColumn = cmbKategorieCeny.SelectedItem.ToString();
                string searchText = txbWyszukiwarkaCeny.Text;

                var columnType = ((DataView)vwCenyRozszerzoneBindingSource.List).Table.Columns[selectedColumn].DataType;

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

                vwCenyRozszerzoneBindingSource.Filter = filtr;
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

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            FiltrujDane();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void SchemaDataLoad()
        {
            cmbKategorieCeny.Items.Clear();


            foreach (DataGridViewColumn column in dgvCennik.Columns)
            {
                if (column.Visible)
                {
                    cmbKategorieCeny.Items.Add(column.HeaderText); 
                }
            }
        }
    }
}
