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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //afișare clienți
            BindingSource clientiBindingSource = new BindingSource();
            ClientiDAO clientiDAO = new ClientiDAO();
            dataGridView1.DataSource = clientiDAO.getClienti();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource clientiBindingSource = new BindingSource();
            ClientiDAO clientiDAO = new ClientiDAO();
            dataGridView1.DataSource = clientiDAO.getClienti();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            //adaugă client
            Clienti client = new Clienti
            {
                Nume = txt_nume.Text,
                Prenume = txt_prenume.Text,
                CNP = txt_cnp.Text,
                Telefon = txt_telefon.Text,
                Email = txt_email.Text,
                Adresă = txt_adresa.Text,
                Oraș = txt_oras.Text,
                DataNașterii = DateTime.Parse(txt_data.Text),
            };

            ClientiDAO clientiDAO = new ClientiDAO();
            int result = clientiDAO.addCLient(client);
            MessageBox.Show(result + " row(s) affected");
            dataGridView1.DataSource = clientiDAO.getClienti();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //update client
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }
            string selectedCNP = dataGridView1.SelectedRows[0].Cells["CNP"].Value.ToString();

            Clienti updatedClient = new Clienti
            {
                Nume = txt_nume.Text,
                Prenume = txt_prenume.Text,
                CNP = selectedCNP, // CNP neschimbat
                Telefon = txt_telefon.Text,
                Email = txt_email.Text,
                Adresă = txt_adresa.Text,
                Oraș = txt_oras.Text,
                DataNașterii = DateTime.Parse(txt_data.Text)
            };

            ClientiDAO clientiDAO = new ClientiDAO();
            int result = clientiDAO.updateClient(updatedClient, selectedCNP);

            if (result > 0)
            {
                MessageBox.Show("Client actualizat!");

                dataGridView1.DataSource = clientiDAO.getClienti();
            }
            else
            {
                MessageBox.Show("Actualizare nereușită");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //șterge client
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            string selectedCNP = dataGridView1.SelectedRows[0].Cells["CNP"].Value.ToString();
            ClientiDAO clientiDAO = new ClientiDAO();
            int result = clientiDAO.deleteClient(selectedCNP);
            if (result > 0)
            {
                MessageBox.Show("Client șters!");
                dataGridView1.DataSource = clientiDAO.getClienti();
            }
            else
            {
                MessageBox.Show("Delete failed. Please try again.");
            }
        }
    }
}
