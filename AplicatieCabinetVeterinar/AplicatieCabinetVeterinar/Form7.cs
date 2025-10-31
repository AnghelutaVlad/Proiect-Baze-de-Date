using MySql.Data.MySqlClient;
using System;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //executare query complex 1
            string query = @"SELECT A.NumeAnimal, A.Vârstă, A.Specie, COALESCE(A.Rasă,'Nu are') AS Rasă, CONCAT(C.Nume,' ',C.Prenume) AS NumeClient FROM animale A 
                             JOIN clienti C ON A.ClientID=C.ClientID
                             WHERE AnimalID NOT IN (SELECT AnimalID FROM animale_cu_afectiuni)";
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
            //executare query complex 2
            string query = @"SELECT A.NumeAnimal, A.Vârstă, A.Specie, COALESCE(A.Rasă,'Nu are') AS Rasă, CONCAT(C.Nume,' ',C.Prenume) AS NumeClient, COUNT(Co.ConsultatieID) AS NrConsultatii
                             FROM animale A JOIN clienti C ON A.ClientID=C.ClientID JOIN consultatii Co ON Co.AnimalID = A.AnimalID
                             GROUP BY A.NumeAnimal, A.Vârstă, A.Specie, A.Rasă, C.Nume, C.Prenume
                             HAVING COUNT(Co.ConsultatieID) > (SELECT AVG(NrCon) FROM (SELECT COUNT(C2.ConsultatieID) AS NrCon FROM consultatii C2 GROUP BY C2.AnimalID) AS Subquery)";
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
                    dataGridView2.DataSource = dataTable;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
