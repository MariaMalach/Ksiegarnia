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
    public partial class Transakcje : Form
    {
        public Transakcje()
        {
            InitializeComponent();
            SchemaDataLoad();
        }

        private void HistoriaZakupow_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet.HistoriaZakupow' . Możesz go przenieść lub usunąć.
            this.historiaZakupowTableAdapter.Fill(this.ksiegarniaDataSet.HistoriaZakupow);
            
        


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ksiegarnia2.Form1 form1 = new Ksiegarnia2.Form1();
            form1.Show();
            this.Close();
        }

        private void SchemaDataLoad()
        {
            cmbKategorie.Items.Clear();


            foreach (DataGridViewColumn column in dgvTransakcje.Columns)
            {
                if (column.Visible)
                {
                    cmbKategorie.Items.Add(column.HeaderText);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            historiaZakupowBindingSource.RemoveFilter();
            txbWyszukiwarka.Clear();
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            FiltrujDane();
        }

        private void FiltrujDane()
        {
            try
            {
                if (cmbKategorie.SelectedItem == null || string.IsNullOrWhiteSpace(txbWyszukiwarka.Text))
                {
                    historiaZakupowBindingSource.RemoveFilter();
                    return;
                }

                string selectedColumn = cmbKategorie.SelectedItem.ToString();
                string searchText = txbWyszukiwarka.Text;

                var columnType = ((DataView)historiaZakupowBindingSource.List).Table.Columns[selectedColumn].DataType;

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

                historiaZakupowBindingSource.Filter = filtr;

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

    }
}
