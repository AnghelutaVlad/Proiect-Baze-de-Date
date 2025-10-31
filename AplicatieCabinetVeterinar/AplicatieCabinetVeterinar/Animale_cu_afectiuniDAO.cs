using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCabinetVeterinar
{
    internal class Animale_cu_afectiuniDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=cabinetveterinar";

        public List<Animale_cu_afectiuni> getAllAnAfec()
        {
            List<Animale_cu_afectiuni> anafec = new List<Animale_cu_afectiuni>();
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT AnimalID, AfectiuneID, DataDiagnostic, Stare FROM animale_cu_afectiuni", connection);

            using(MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Animale_cu_afectiuni a = new Animale_cu_afectiuni
                    {
                        AnimalID = reader.GetInt32(0),
                        AfectiuneID = reader.GetInt32(1),
                        DataDiagnostic = reader.GetDateTime(2),
                        Stare = reader.GetString(3),
                    };
                    anafec.Add(a);
                }
            }
            connection.Close();
            return anafec;
        }
    }
}

