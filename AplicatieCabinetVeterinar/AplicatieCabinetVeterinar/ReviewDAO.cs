using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCabinetVeterinar
{
    internal class ReviewDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=cabinetveterinar";

        public List<Review> getReviews()
        {
            List<Review> reviews = new List<Review>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT ConsultatieID, ClientID, Scor, Recenzie FROM reviews", connection);

            using(MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Review review = new Review { 
                        ConsultatieID = reader.GetInt32(0),
                        ClientID = reader.GetInt32(1),
                        Scor = reader.GetInt32(2),
                        Recenzie = reader.IsDBNull(3) ? "NULL":reader.GetString(3)
                    };
                    reviews.Add(review);
                }
            }
            connection.Close();
            return reviews;
        }
    }
}
