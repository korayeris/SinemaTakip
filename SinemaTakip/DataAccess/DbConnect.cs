using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using SinemaTakip.Models;

namespace SinemaTakip.DataAccess
{
    public class DbConnect
    {
        public void WriteTofilms(Film film)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=hello.db"))
            {
                connection.Open();
                var insertCommand = connection.CreateCommand();
                insertCommand.CommandText = @"
                INSERT INTO films (title, director, release_date, duration, description, created_at) 
                VALUES ($title, $director, $releaseDate, $duration, $description, $createdAt)";


                insertCommand.Parameters.AddWithValue("$title", film.Title);
                insertCommand.Parameters.AddWithValue("$director", film.Director);
                insertCommand.Parameters.AddWithValue("$releaseDate", film.ReleaseDate);
                insertCommand.Parameters.AddWithValue("$duration", film.Duration);
                insertCommand.Parameters.AddWithValue("$description", film.Description);
                insertCommand.Parameters.AddWithValue("$createdAt", film.CreatedAt);

                insertCommand.ExecuteNonQuery();
            }
        }
        public void WriteTosalons(Salon salon)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=hello.db"))
            {
                connection.Open();
                var insertCommand = connection.CreateCommand();
                insertCommand.CommandText = @"
                INSERT INTO salons (name, capacity) 
                VALUES ($name, $capacity)";


                insertCommand.Parameters.AddWithValue("$name", salon.Name);
                insertCommand.Parameters.AddWithValue("$capacity", salon.Capacity);

                insertCommand.ExecuteNonQuery();
            }
        }


        public void WriteTosessions(Seans seans)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=hello.db"))
            {
                connection.Open();
                var insertCommand = connection.CreateCommand();
                insertCommand.CommandText = @"
                INSERT INTO sessions (film_id, salon_id, start_time, duration, price) 
                VALUES ($film_id, $salon_id, $start_time, $duration, $price)";


                insertCommand.Parameters.AddWithValue("$film_id", seans.FilmId);
                insertCommand.Parameters.AddWithValue("$salon_id", seans.SalonId);
                insertCommand.Parameters.AddWithValue("$start_time", seans.StartTime);
                insertCommand.Parameters.AddWithValue("$duration", seans.Duration);
                insertCommand.Parameters.AddWithValue("$price", seans.Price);

                insertCommand.ExecuteNonQuery();
            }
        }
    }
}