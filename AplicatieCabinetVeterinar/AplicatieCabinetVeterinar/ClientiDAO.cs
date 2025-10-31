using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCabinetVeterinar
{
    internal class ClientiDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=cabinetveterinar";

        public List<Clienti> getClienti()
        {
            List<Clienti> clienti = new List<Clienti>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT Nume, Prenume, CNP, Telefon, Email, Adresă, Oraș, DataNastere  FROM clienti", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Clienti c = new Clienti
                    {
                        //ID = reader.GetInt32(0),
                        Nume = reader.GetString(0),
                        Prenume = reader.GetString(1),
                        CNP = reader.GetString(2),
                        Telefon = reader.GetString(3),
                        Email = reader.GetString(4),
                        Adresă = reader.GetString(5),
                        Oraș = reader.GetString(6),
                        DataNașterii = reader.GetDateTime(7),
                    };
                    clienti.Add(c);
                }
            }
            connection.Close();
            return clienti;
        }

        internal int addCLient(Clienti client)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO `clienti`(`Nume`, `Prenume`, `CNP`, `Telefon`, `Email`, `Adresă`, `Oraș`, `DataNastere`) " +
                "VALUES (@nume,@prenume,@cnp,@telefon,@email,@adresa,@oras,@data)", connection);
            command.Parameters.AddWithValue("@nume", client.Nume);
            command.Parameters.AddWithValue("@prenume", client.Prenume);
            command.Parameters.AddWithValue("@cnp", client.CNP);
            command.Parameters.AddWithValue("@telefon", client.Telefon);
            command.Parameters.AddWithValue("@email", client.Email);
            command.Parameters.AddWithValue("@adresa", client.Adresă);
            command.Parameters.AddWithValue("@oras", client.Oraș);
            command.Parameters.AddWithValue("@data", client.DataNașterii);
            int new_rows = command.ExecuteNonQuery();
            connection.Close();

            return new_rows;
        }

        internal int deleteClient(string cnp)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "DELETE FROM `clienti` WHERE `CNP` = @cnp";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@cnp", cnp);

            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected;
        }

        internal int updateClient(Clienti updatedClient, string cnp)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "UPDATE `clienti` SET `Nume` = @nume, `Prenume` = @prenume, `Telefon` = @telefon, `Email` = @email, " +
                           "`Adresă` = @adresa, `Oraș` = @oras, `DataNastere` = @data WHERE `CNP` = @cnp";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@nume", updatedClient.Nume);
            command.Parameters.AddWithValue("@prenume", updatedClient.Prenume);
            command.Parameters.AddWithValue("@telefon", updatedClient.Telefon);
            command.Parameters.AddWithValue("@email", updatedClient.Email);
            command.Parameters.AddWithValue("@adresa", updatedClient.Adresă);
            command.Parameters.AddWithValue("@oras", updatedClient.Oraș);
            command.Parameters.AddWithValue("@data", updatedClient.DataNașterii);
            command.Parameters.AddWithValue("@cnp", cnp);

            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected;
        }
    }

}
