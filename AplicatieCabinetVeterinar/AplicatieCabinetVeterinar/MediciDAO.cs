using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCabinetVeterinar
{
    internal class MediciDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=cabinetveterinar";

        public List<Medici> getVeterinari()
        {
            List<Medici> medici = new List<Medici>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT Nume, Prenume, CNP, Telefon, Email, Adresă, Oraș, DataNastere, Specializare  FROM veterinari", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    Medici m = new Medici
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
                        Specializare = reader.GetString(8),
                    };
                    medici.Add(m);
                }
            }
            connection.Close();
            return medici;
        }

        internal int addMedic(Medici medic)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO `veterinari`(`Nume`, `Prenume`, `CNP`, `Telefon`, `Email`, `Adresă`, `Oraș`, `DataNastere`, `Specializare`) " +
                "VALUES (@nume,@prenume,@cnp,@telefon,@email,@adresa,@oras,@data,@specializare)", connection);
            command.Parameters.AddWithValue("@nume", medic.Nume);
            command.Parameters.AddWithValue("@prenume", medic.Prenume);
            command.Parameters.AddWithValue("@cnp", medic.CNP);
            command.Parameters.AddWithValue("@telefon", medic.Telefon);
            command.Parameters.AddWithValue("@email", medic.Email);
            command.Parameters.AddWithValue("@adresa", medic.Adresă);
            command.Parameters.AddWithValue("@oras", medic.Oraș);
            command.Parameters.AddWithValue("@data", medic.DataNașterii);
            command.Parameters.AddWithValue("@specializare", medic.Specializare);
            int new_rows = command.ExecuteNonQuery();
            connection.Close();

            return new_rows;
        }
        internal int updateMedic(Medici medic, string cnp)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "UPDATE `veterinari` SET `Nume` = @nume, `Prenume` = @prenume, `Telefon` = @telefon, `Email` = @email, " +
                           "`Adresă` = @adresa, `Oraș` = @oras, `DataNastere` = @data, `Specializare` = @specializare WHERE `CNP` = @cnp";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@nume", medic.Nume);
            command.Parameters.AddWithValue("@prenume", medic.Prenume);
            command.Parameters.AddWithValue("@telefon", medic.Telefon);
            command.Parameters.AddWithValue("@email", medic.Email);
            command.Parameters.AddWithValue("@adresa", medic.Adresă);
            command.Parameters.AddWithValue("@oras", medic.Oraș);
            command.Parameters.AddWithValue("@data", medic.DataNașterii);
            command.Parameters.AddWithValue("@specializare", medic.Specializare);
            command.Parameters.AddWithValue("@cnp", cnp);

            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected;
        }

        internal int deleteMedic(string cnp)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "DELETE FROM `veterinari` WHERE `CNP` = @cnp";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@cnp", cnp);

            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected;
        }
    }
}
