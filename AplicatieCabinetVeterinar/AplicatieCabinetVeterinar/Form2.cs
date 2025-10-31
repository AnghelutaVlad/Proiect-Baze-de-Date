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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //afișare veterinari
            BindingSource veterinariBindingSource = new BindingSource();
            MediciDAO veterinariDAO = new MediciDAO();
            dataGridView1.DataSource = veterinariDAO.getVeterinari();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            //insert veterinar
            Medici medic = new Medici
            {
                Nume = txt_nume.Text,
                Prenume = txt_prenume.Text,
                CNP = txt_cnp.Text,
                Telefon = txt_telefon.Text,
                Email = txt_email.Text,
                Adresă = txt_adresa.Text,
                Oraș = txt_oras.Text,
                DataNașterii = DateTime.Parse(txt_datanastere.Text),
                Specializare = txt_specializare.Text
            };

            MediciDAO mediciDAO = new MediciDAO();
            int result = mediciDAO.addMedic(medic);
            MessageBox.Show(result + " row(s) affected");
            dataGridView1.DataSource = mediciDAO.getVeterinari();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //refresh tabel veterinari
            BindingSource veterinariBindingSource = new BindingSource();
            MediciDAO veterinariDAO = new MediciDAO();
            dataGridView1.DataSource = veterinariDAO.getVeterinari();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //update veterinar
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }
            string selectedCNP = dataGridView1.SelectedRows[0].Cells["CNP"].Value.ToString();

            Medici updatedMedic = new Medici
            {
                Nume = txt_nume.Text,
                Prenume = txt_prenume.Text,
                CNP = selectedCNP, // CNP neschimbat
                Telefon = txt_telefon.Text,
                Email = txt_email.Text,
                Adresă = txt_adresa.Text,
                Oraș = txt_oras.Text,
                DataNașterii = DateTime.Parse(txt_datanastere.Text),
                Specializare = txt_specializare.Text
            };

            MediciDAO mediciDAO = new MediciDAO();
            int result = mediciDAO.updateMedic(updatedMedic, selectedCNP);

            if (result > 0)
            {
                MessageBox.Show("Veterinar actualizat!");

                dataGridView1.DataSource = mediciDAO.getVeterinari();
            }
            else
            {
                MessageBox.Show("Actualizare nereușită");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //delete veterinar
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            string selectedCNP = dataGridView1.SelectedRows[0].Cells["CNP"].Value.ToString();
            MediciDAO mediciDAO = new MediciDAO();
            int result = mediciDAO.deleteMedic(selectedCNP);
            if (result > 0)
            {
               MessageBox.Show("Veterinar șters!");
               dataGridView1.DataSource = mediciDAO.getVeterinari();
            }
            else
            {
               MessageBox.Show("Delete failed. Please try again.");
            }
            
        }
    }
}
