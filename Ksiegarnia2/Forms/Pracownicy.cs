﻿using Ksiegarnia2;
using Ksiegarnia2.Forms;
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

namespace Ksiegarnia.Forms
{
    public partial class Pracownicy : Form
    {
        public Pracownicy()
        {
            InitializeComponent();
            SchemaDataLoad();
            dgvPracownicy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPracownicy.AutoResizeColumns();
            dgvPracownicy.AutoResizeRows();
        }

        private void SchemaDataLoad()
        {
            cmbKategorie.Items.Clear();


            foreach (DataGridViewColumn column in dgvPracownicy.Columns)
            {
                
                
                    cmbKategorie.Items.Add(column.HeaderText); // Uzupełnianie nazwami kolumn ComboBoxa
                
            }
        }
        private void Pracownicy_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ksiegarniaDataSet.vw_PracownicyZeStanowiskiem' . Możesz go przenieść lub usunąć.
            this.vw_PracownicyZeStanowiskiemTableAdapter.Fill(this.ksiegarniaDataSet.vw_PracownicyZeStanowiskiem);
            

         
          


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

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            FiltrujDane();
        }

        private DataSet ZaładujDane()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Ksiegarnia;Integrated Security=True"))
                {
                    string sql = @"SELECT p.IDPracownika, p.Imie, p.Nazwisko,
                              p.DataZatrudnienia, p.Email,
                              p.Telefon,
                              p.NazwaStanowiska
                           FROM vwPracownicy p";

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "vwPracownicy");


                    vwPracownicyZeStanowiskiemBindingSource.DataSource = ds.Tables["vwPracownicy"];
                    dgvPracownicy.DataSource = vwPracownicyZeStanowiskiemBindingSource;

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

        private void FiltrujDane()
        {
            try
            {
                if (cmbKategorie.SelectedItem == null || string.IsNullOrWhiteSpace(txbWyszukiwarka.Text))
                {
                    vwPracownicyZeStanowiskiemBindingSource.RemoveFilter();
                    return;
                }

                string selectedColumn = cmbKategorie.SelectedItem.ToString();
                string searchText = txbWyszukiwarka.Text.Trim().Replace("'", "''");

                var columnType = ((DataView)vwPracownicyZeStanowiskiemBindingSource.List).Table.Columns[selectedColumn].DataType;

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

                vwPracownicyZeStanowiskiemBindingSource.Filter = filtr;
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

        private void button2_Click(object sender, EventArgs e)
        {
            vwPracownicyZeStanowiskiemBindingSource.RemoveFilter();
            txbWyszukiwarka.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajPracownika dodajPracownika = new DodajPracownika();
            dodajPracownika.Show();
            this.Close();
        }
    }
}
