using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JenkinsCRUD.Models
{
    public class MusicContext
    {
        public string ConnectionString { get; set; }

        public MusicContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Track> GetAllAlbums()
        {
            List<Track> list = new List<Track>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from Track where id < 10", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Track()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Title = reader["Name"].ToString(),
                            Artist = reader["ArtistName"].ToString(),
                            Price = reader["Price"].ToString(),
                            Genre = reader["genre"].ToString()
                        });
                    }
                }
            }
            return list;
        }
    }
}
