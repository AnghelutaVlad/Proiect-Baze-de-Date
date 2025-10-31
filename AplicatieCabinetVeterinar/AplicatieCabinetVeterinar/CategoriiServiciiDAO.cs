using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCabinetVeterinar
{
    internal class CategoriiServiciiDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=cabinetveterinar";

        public List<CategoriiServicii> getCategorii()
        {
            List<CategoriiServicii> categorii = new List<CategoriiServicii>();
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT CategorieID, Denumire, Detalii FROM categoriiservicii", connection);

            using(MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    CategoriiServicii c = new CategoriiServicii { 
                        ID = reader.GetInt32(0),
                        Denumire = reader.GetString(1),
                        Detalii = reader.GetString(2),
                    };
                    categorii.Add(c);
                }
            }
            connection.Close();
            return categorii;
        }
    }
}
