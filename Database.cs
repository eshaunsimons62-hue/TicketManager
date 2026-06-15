using Microsoft.Data.Sqlite;

namespace TicketManager
{
    public class Database
    {
        private static string dbPath = "tickets.db";

        public static void Initialize()
        {
            using var connection = new SqliteConnection($"Data Source={dbPath}");
            connection.Open();

            string createTable = @"
                CREATE TABLE IF NOT EXISTS Tickets (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ClientName TEXT NOT NULL,
                    Issue TEXT NOT NULL,
                    Severity TEXT NOT NULL,
                    Status TEXT NOT NULL,
                    CreatedAt TEXT NOT NULL
                )";

            using var command = new SqliteCommand(createTable, connection);
            command.ExecuteNonQuery();
        }

        public static void AddTicket(string clientName, string issue, string severity)
        {
            using var connection = new SqliteConnection($"Data Source={dbPath}");
            connection.Open();

            string insert = @"
                INSERT INTO Tickets (ClientName, Issue, Severity, Status, CreatedAt)
                VALUES (@name, @issue, @severity, 'Open', @date)";

            using var command = new SqliteCommand(insert, connection);
            command.Parameters.AddWithValue("@name", clientName);
            command.Parameters.AddWithValue("@issue", issue);
            command.Parameters.AddWithValue("@severity", severity);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
            command.ExecuteNonQuery();
        }

        public static void ResolveTicket(int id)
        {
            using var connection = new SqliteConnection($"Data Source={dbPath}");
            connection.Open();

            string update = "UPDATE Tickets SET Status='Resolved' WHERE Id=@id";
            using var command = new SqliteCommand(update, connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }

        public static List<Ticket> GetAllTickets()
        {
            var tickets = new List<Ticket>();

            using var connection = new SqliteConnection($"Data Source={dbPath}");
            connection.Open();

            string select = "SELECT * FROM Tickets ORDER BY CreatedAt DESC";
            using var command = new SqliteCommand(select, connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                tickets.Add(new Ticket
                {
                    Id = reader.GetInt32(0),
                    ClientName = reader.GetString(1),
                    Issue = reader.GetString(2),
                    Severity = reader.GetString(3),
                    Status = reader.GetString(4),
                    CreatedAt = reader.GetString(5)
                });
            }

            return tickets;
        }
    }

    public class Ticket
    {
        public int Id { get; set; }
        public string ClientName { get; set; } = "";
        public string Issue { get; set; } = "";
        public string Severity { get; set; } = "";
        public string Status { get; set; } = "";
        public string CreatedAt { get; set; } = "";
    }
}