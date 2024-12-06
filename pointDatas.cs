using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using static LocationTransform.Storage;

namespace LocationTransform
{
    class pointDatas
    {
        private static string dbFile = "pointDatas.db";
        private static string connectionString = $"Data Source={dbFile};Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = @"
                        CREATE TABLE IF NOT EXISTS Points (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            PointName TEXT,
                            Longitude REAL,
                            Latitude REAL,
                            Elevation REAL,
                            Remark TEXT
                        )";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<Coordinate> GetPoints()
        {
            var points = new List<Coordinate>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT PointName, Longitude, Latitude, Elevation, Remark FROM Points";
                using (var command = new SQLiteCommand(selectQuery, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var point = new Coordinate(
                            reader.GetString(0),
                            reader.GetDouble(1),
                            reader.GetDouble(2),
                            reader.GetDouble(3),
                            reader.GetString(4)
                        );
                        points.Add(point);
                    }
                }
            }
            return points;
        }

        public static void AddPoint(Coordinate coordinate)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string insertQuery = @"
                        INSERT INTO Points (PointName, Longitude, Latitude, Elevation, Remark)
                        VALUES (@PointName, @Longitude, @Latitude, @Elevation, @Remark)";
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@PointName", coordinate.PointName);
                    command.Parameters.AddWithValue("@Longitude", coordinate.Longitude);
                    command.Parameters.AddWithValue("@Latitude", coordinate.Latitude);
                    command.Parameters.AddWithValue("@Elevation", coordinate.Elevation);
                    command.Parameters.AddWithValue("@Remark", coordinate.Remark);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeletePoint(Coordinate coordinate)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Points WHERE PointName = @PointName AND Longitude = @Longitude AND Latitude = @Latitude AND Elevation = @Elevation AND Remark = @Remark";
                using (var command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@PointName", coordinate.PointName);
                    command.Parameters.AddWithValue("@Longitude", coordinate.Longitude);
                    command.Parameters.AddWithValue("@Latitude", coordinate.Latitude);
                    command.Parameters.AddWithValue("@Elevation", coordinate.Elevation);
                    command.Parameters.AddWithValue("@Remark", coordinate.Remark);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
