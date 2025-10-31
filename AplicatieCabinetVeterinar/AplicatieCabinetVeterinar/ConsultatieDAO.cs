using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCabinetVeterinar
{
    internal class ConsultatieDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=cabinetveterinar";

        public List<Consultatie> getConsultatii()
        {
            List<Consultatie> consultatii = new List<Consultatie>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT ConsultatieID, DataEfectuare, AnimalID, MedicID, ServiciuID FROM consultatii", connection);

            using(MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Consultatie c = new Consultatie {
                        ID = reader.GetInt32(0),
                        DataEfectuare = reader.GetDateTime(1),
                        AnimalID = reader.GetInt32(2),
                        MedicID = reader.GetInt32(3),
                        ServiciuID = reader.GetInt32(4)
                    };
                    consultatii.Add(c);
                }
            }
            connection.Close();
            return consultatii;

        }
    }
}
