using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCabinetVeterinar
{
    internal class ServiciuDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=cabinetveterinar";

        public List<Serviciu> getServicii()
        {
            List<Serviciu> servicii = new List<Serviciu>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT ServiciuID, CategorieID, Denumire, Detalii, Preț FROM servicii", connection);

            using(MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Serviciu serviciu = new Serviciu { 
                        ServiciuID = reader.GetInt32(0),
                        CategorieID = reader.GetInt32(1),
                        Denumire = reader.GetString(2),
                        Detalii = reader.IsDBNull(3) ? "NULL":reader.GetString(3),
                        Preț = reader.GetInt32(4)
                        
                    };
                    servicii.Add(serviciu);
                }
            }
            connection.Close();
            return servicii;

        }
    }
}
