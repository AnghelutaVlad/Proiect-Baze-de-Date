using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCabinetVeterinar
{
    internal class AnimalDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=cabinetveterinar";

        public List<Animal> getAnimals()
        {
            List<Animal> animale =  new List<Animal>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT AnimalID, ClientID, NumeAnimal, Vârstă, Specie, Rasă  FROM animale", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Animal a = new Animal
                    {
                        ID = reader.GetInt32(0),
                        ClientID = reader.GetInt32(1),
                        Nume = reader.GetString(2),
                        Vârstă = reader.GetInt32(3),
                        Specie = reader.GetString(4),
                        Rasă = reader.IsDBNull(5) ? "NULL":reader.GetString(5),
                    };
                    animale.Add(a);
                }
            }
            connection.Close();
            return animale;

        }
    }
}
