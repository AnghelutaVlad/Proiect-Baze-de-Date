using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieCabinetVeterinar
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //executare query simplu 8
            string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=cabinetveterinar";
            string query = "SELECT S.Denumire AS Denumire, Cat.Denumire AS Categorie, S.Preț AS Preț, S.Detalii AS Detalii " +
                           "FROM servicii S JOIN categoriiservicii Cat ON S.CategorieID = Cat.CategorieID";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView4.DataSource = dataTable;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //executare query complex 5
                string query2 = "SELECT C.Denumire AS Categorie, (SELECT S.Denumire FROM servicii S JOIN consultatii Co ON S.ServiciuID = Co.ServiciuID " +
                                "WHERE S.CategorieID = C.CategorieID GROUP BY S.Denumire ORDER BY COUNT(Co.ConsultatieID) DESC LIMIT 1) " +
                                "AS ServiciuPopular FROM categoriiservicii C ";

                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query2, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView5.DataSource = dataTable;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //executare query simplu 5
            string query = @"SELECT Af.Denumire AS NumeAfecțiune, MAX(Aaf.DataDiagnostic) AS CelMaiRecentDiagnostic
                             FROM afectiunimedicale Af JOIN animale_cu_afectiuni Aaf ON Af.AfectiuneID = Aaf.AfectiuneID
                             GROUP BY Af.Denumire
                             ORDER BY MAX(Aaf.DataDiagnostic) DESC";
            string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=cabinetveterinar";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //executare query simplu 6
            string sel = (comboBox1.SelectedItem == null) ? "Nevindecat" : comboBox1.SelectedItem.ToString();
            string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=cabinetveterinar";
            string query = @"SELECT A.NumeAnimal AS Nume, A.Vârstă AS Vârstă, A.Specie AS Specie, COALESCE(A.Rasă,'Nu are') AS Rasă, Aaf.DataDiagnostic AS DataDiagnostic, Af.Denumire AS Denumire
                             FROM animale_cu_afectiuni Aaf JOIN animale A ON Aaf.AnimalID = A.AnimalID
                                                           JOIN afectiunimedicale Af ON Af.AfectiuneID = Aaf.AfectiuneID
                             WHERE Aaf.Stare = @stare";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@stare", sel);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView2.DataSource = dataTable;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //executare query simplu 7
            string beginDate = txt_begin.Text;
            string endDate = txt_end.Text;

            if (!DateTime.TryParse(beginDate, out DateTime beginDateVal) ||
                !DateTime.TryParse(endDate, out DateTime endDateVal))
            {
                MessageBox.Show("Introduceți datele în formatul YYYY-MM-DD.", "Input invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = @"SELECT Cl.Nume AS NumeClient, A.NumeAnimal AS Nume_Animal, C.DataEfectuare AS Data, S.Denumire AS Serviciu, V.Nume AS NumeVeterinar, V.Prenume AS PrenumeVeterinar
                             FROM consultatii C JOIN animale A ON C.AnimalID = A.AnimalID
		                                        JOIN veterinari V ON V.MedicID = C.MedicID
		                                        JOIN servicii S ON S.ServiciuID = C.ServiciuID
		                                        JOIN clienti Cl ON A.ClientID = Cl.ClientID
                             WHERE C.DataEfectuare >= @BeginDate AND C.DataEfectuare <= @EndDate";
            string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=cabinetveterinar";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@BeginDate", beginDateVal.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@EndDate", endDateVal.ToString("yyyy-MM-dd"));

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView3.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Query Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
