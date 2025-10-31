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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //afișare clienți
            BindingSource clientiBindingSource = new BindingSource();
            ClientiDAO clientiDAO = new ClientiDAO();
            dataGridView1.DataSource = clientiDAO.getClienti();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //executare query simplu 3
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string selectedCNP = selectedRow.Cells["CNP"].Value.ToString();

                Query3(selectedCNP);
            }
            else
            {
                MessageBox.Show("Alegeți un client.", "Selecție eșuată", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Query3(string cnp)
        {
            string query = @"SELECT SUM(S.Preț) AS Total, Cl.Nume AS NumeClient, Cl.Prenume AS PrenumeClient
                             FROM servicii S JOIN consultatii C ON S.ServiciuID = C.ServiciuID
		                     JOIN animale A ON C.AnimalID = A.AnimalID
		                     JOIN clienti Cl ON A.ClientID = Cl.ClientID
                             WHERE Cl.CNP = @CNP
                             GROUP BY Cl.Nume,Cl.Prenume ";
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

        private void button1_Click(object sender, EventArgs e)
        {
            //executare query simplu 4
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string selectedCNP = selectedRow.Cells["CNP"].Value.ToString();

                Query4(selectedCNP);
            }
            else
            {
                MessageBox.Show("Alegeți un client.", "Selecție eșuată", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Query4(string cnp)
        {
            string query = @"SELECT A.NumeAnimal AS Nume, A.Vârstă AS Vârstă, A.Specie AS Specie, COALESCE(A.Rasă, 'Nu are') AS Rasă
                             FROM animale A JOIN clienti Cl ON A.ClientID = Cl.ClientID
                             WHERE Cl.CNP = @CNP";
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

        private void button3_Click(object sender, EventArgs e)
        {
            //executare query complex 4
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string selectedCNP = selectedRow.Cells["CNP"].Value.ToString();

                Query5C(selectedCNP);
            }
            else
            {
                MessageBox.Show("Alegeți un client.", "Selecție eșuată", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Query5C(string cnp)
        {
            string query = @"SELECT CONCAT(Cl.Nume,' ',Cl.Prenume) AS Nume, AVG(R.Scor) AS Medie
                             FROM clienti Cl JOIN reviews R ON Cl.ClientID = R.ClientID
                             WHERE Cl.CNP != @CNP1
                             GROUP BY Cl.Nume, Cl.Prenume
                             HAVING ABS(AVG(R.Scor) - (SELECT AVG(R2.Scor) FROM reviews R2 JOIN clienti Cl2 ON R2.ClientID=Cl2.ClientID WHERE Cl2.CNP = @CNP2)) <= 0.5";
            string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=cabinetveterinar";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CNP1", cnp);
                    command.Parameters.AddWithValue("@CNP2", cnp);
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
            string query2 = @"SELECT AVG(R.Scor) FROM reviews R JOIN clienti Cl ON R.ClientID=Cl.ClientID WHERE Cl.CNP = @CNP";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query2, connection);
                    command.Parameters.AddWithValue("@CNP", cnp);
                    object result = command.ExecuteScalar();
                    txtMedie.Text = (result != DBNull.Value) ? result.ToString() : "0";
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
