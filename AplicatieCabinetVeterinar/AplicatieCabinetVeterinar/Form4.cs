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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //afișare veterinari
            BindingSource veterinariBindingSource = new BindingSource();
            MediciDAO veterinariDAO = new MediciDAO();
            dataGridView1.DataSource = veterinariDAO.getVeterinari();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //executare query simplu 1
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string selectedCNP = selectedRow.Cells["CNP"].Value.ToString(); 
                Query1(selectedCNP);
            }
            else
            {
                MessageBox.Show("Alegeți un medic.", "Selecție eșuată", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Query1(string cnp)
        {
            string query = @"
        SELECT 
            Cl.Nume AS NumeClient,
            Cl.Prenume AS PrenumeClient,                
            A.NumeAnimal AS Nume_Animal, 
            C.DataEfectuare AS Data, 
            S.Denumire AS Serviciu
        FROM consultatii C 
        JOIN animale A ON C.AnimalID = A.AnimalID
        JOIN veterinari V ON V.MedicID = C.MedicID
        JOIN servicii S ON S.ServiciuID = C.ServiciuID
        JOIN clienti Cl ON A.ClientID = Cl.ClientID
        WHERE V.CNP = @CNP"
            ;

            string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=cabinetveterinar";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CNP", cnp);
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

        private void button2_Click(object sender, EventArgs e)
        {
            //executare query simplu 2
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string selectedCNP = selectedRow.Cells["CNP"].Value.ToString(); 

                Query2(selectedCNP);
            }
            else
            {
                MessageBox.Show("Alegeți un medic.", "Selecție eșuată", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Query2(string cnp)
        {
            string query = @"SELECT AVG(R.Scor) AS Recenzie_medie, V.Nume AS NumeMedic, V.Prenume AS PrenumeMedic
                             FROM reviews R JOIN consultatii C ON C.ConsultatieID = R.ConsultatieID
	                                        JOIN veterinari V ON V.MedicID = C.MedicID
                             WHERE V.CNP = @CNP
                             GROUP BY V.Nume, V.Prenume";
            string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=cabinetveterinar";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CNP", cnp);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView3.DataSource = dataTable;
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
            //executare query complex 3
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string selectedCNP = selectedRow.Cells["CNP"].Value.ToString();

                Query3C(selectedCNP);
            }
            else
            {
                MessageBox.Show("Alegeți un medic.", "Selecție eșuată", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Query3C(string cnp)
        {
            string query = @"SELECT V.Nume, V.Prenume, SUM(S.Preț) AS Total
                             FROM veterinari V JOIN consultatii Co ON V.MedicID = Co.MedicID JOIN servicii S ON Co.ServiciuID = S.ServiciuID
                             GROUP BY V.Nume, V.Prenume
                             HAVING SUM(S.Preț) > 
                             (SELECT SUM(S2.Preț) FROM servicii S2 JOIN consultatii Co2 ON S2.ServiciuID = Co2.ServiciuID JOIN veterinari V2 ON Co2.MedicID = V2.MedicID
                              WHERE V2.CNP = @CNP)";
            string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=cabinetveterinar";
            string query2 = "SELECT SUM(S.Preț) FROM servicii S JOIN consultatii Co ON S.ServiciuID = Co.ServiciuID JOIN veterinari V ON Co.MedicID = V.MedicID WHERE V.CNP = @CNP";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CNP", cnp);
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
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query2, connection);
                    command.Parameters.AddWithValue("@CNP", cnp);
                    object result = command.ExecuteScalar();
                    txtTotal.Text = (result != DBNull.Value) ? result.ToString() : "0";
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
