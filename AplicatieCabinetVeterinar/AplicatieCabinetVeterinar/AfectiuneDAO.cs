using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCabinetVeterinar
{
    internal class AfectiuneDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=cabinetveterinar";

        public List<Afectiune> getAfectiuni()
        {
            List<Afectiune> afectiuni = new List<Afectiune>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT AfectiuneID, Denumire, Simptome, Recomandare FROM afectiunimedicale", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Afectiune a = new Afectiune { 
                    ID = reader.GetInt32(0),
                    Denumire = reader.GetString(1),
                    Simptome = reader.GetString(2),
                    Recomandare = reader.GetString(3),
                    };
                    afectiuni.Add(a);

                }
            }
            connection.Close();
            return afectiuni;
        }
    }
}