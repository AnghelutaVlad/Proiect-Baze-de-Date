namespace AplicatieCabinetVeterinar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BindingSource veterinariBindingSource = new BindingSource();
        BindingSource clientiBindingSource = new BindingSource();
        BindingSource animaleBindingSource = new BindingSource();
        BindingSource afectiuniBindingSource = new BindingSource();
        BindingSource animalecuafectiuniBindingSource = new BindingSource();
        BindingSource categoriiBindingSource = new BindingSource();
        BindingSource serviciiBindingSource = new BindingSource();
        BindingSource consultatiiBindingSource = new BindingSource();
        BindingSource reviewsBindingSource = new BindingSource();

        private void button1_Click(object sender, EventArgs e)
        {
            //creare de obiecte pentru afișarea tabelelor
            MediciDAO veterinariDAO = new MediciDAO();
            ClientiDAO clientiDAO = new ClientiDAO();
            AnimalDAO animalDAO = new AnimalDAO();
            AfectiuneDAO afectiuneDAO = new AfectiuneDAO();
            Animale_cu_afectiuniDAO anafecDAO = new Animale_cu_afectiuniDAO();
            CategoriiServiciiDAO categoriiDAO = new CategoriiServiciiDAO();
            ServiciuDAO serviciiDAO = new ServiciuDAO();
            ConsultatieDAO consultatiiDAO = new ConsultatieDAO();
            ReviewDAO reviewsDAO = new ReviewDAO();
            veterinariBindingSource.DataSource = veterinariDAO.getVeterinari();
            clientiBindingSource.DataSource = clientiDAO.getClienti();
            animaleBindingSource.DataSource = animalDAO.getAnimals();
            afectiuniBindingSource.DataSource = afectiuneDAO.getAfectiuni();
            animalecuafectiuniBindingSource.DataSource = anafecDAO.getAllAnAfec();
            categoriiBindingSource.DataSource = categoriiDAO.getCategorii();
            serviciiBindingSource.DataSource = serviciiDAO.getServicii();
            consultatiiBindingSource.DataSource = consultatiiDAO.getConsultatii();
            reviewsBindingSource.DataSource = reviewsDAO.getReviews();
            //dataGridView1.DataSource = reviewsBindingSource;
        }

        private void button2_click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = reviewsBindingSource;

            string sel = (comboBox1.SelectedItem == null) ? "Medici" : comboBox1.SelectedItem.ToString();
            //afișare tabele 
            switch (sel)
            {
                case "Medici":
                    dataGridView1.DataSource = veterinariBindingSource;
                    break;
                case "Clienți":
                    dataGridView1.DataSource = clientiBindingSource;
                    break;
                case "Animale":
                    dataGridView1.DataSource = animaleBindingSource;
                    break;
                case "CategoriiServicii":
                    dataGridView1.DataSource = categoriiBindingSource;
                    break;
                case "Servicii":
                    dataGridView1.DataSource = serviciiBindingSource;
                    break;
                case "Afecțiuni":
                    dataGridView1.DataSource = afectiuniBindingSource;
                    break;
                case "AnimaleCuAfecțiuni":
                    dataGridView1.DataSource = animalecuafectiuniBindingSource;
                    break;
                case "Consultații":
                    dataGridView1.DataSource = consultatiiBindingSource;
                    break;
                case "Reviews":
                    dataGridView1.DataSource = reviewsBindingSource;
                    break;

            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void button3_click(object sender, EventArgs e)
        {
            //trecere în forms-ul de edit veterinari
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void button4_click(object sender, EventArgs e)
        {
            //trecere în forms-ul de edit clienti
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //trecere în forms-ul de statistici veterinari
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //trecere în forms-ul de statistici clienti
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //trecere în forms-ul de statistici boli
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //trecere în forms-ul de statistici animale
            Form7 form7 = new Form7();
            form7.Show();
        }
    }
}
