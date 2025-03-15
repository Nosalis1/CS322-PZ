using MySql.Data.MySqlClient;

namespace AutoService.Database
{
    internal static class Database
    {
        private static MySqlConnection? connection;
        public static MySqlConnection Connection => connection;

        const string CONNECTION_STRING = "Server=localhost;Database=auto_service;Uid=admin;Pwd=admin";
        const string TABLE_QUERY = @"
            CREATE TABLE IF NOT EXISTS Korisnici (
                ID INT AUTO_INCREMENT PRIMARY KEY,
                Ime VARCHAR(100) NOT NULL,
                Lozinka VARCHAR(100) NOT NULL,
                Email VARCHAR(100) NOT NULL UNIQUE,
                Telefon VARCHAR(100) NOT NULL,
                Rola VARCHAR(100) NOT NULL
            );

            CREATE TABLE IF NOT EXISTS Servisi (
                ID INT AUTO_INCREMENT PRIMARY KEY,
                Ime VARCHAR(100) NOT NULL UNIQUE,
                Opis VARCHAR(255) NOT NULL,
                Trajanje INT NOT NULL,
                Cena DECIMAL(10,2) NOT NULL
            );

            CREATE TABLE IF NOT EXISTS Termini (
                ID INT AUTO_INCREMENT PRIMARY KEY,
                ServisID INT NOT NULL,
                DostupanDatum DATE NOT NULL,
                DostupnoVreme TIME NOT NULL,
                Status VARCHAR(100) NOT NULL,
                CONSTRAINT FK_ServisTermin FOREIGN KEY (ServisID)
                    REFERENCES Servisi(ID) ON DELETE CASCADE,
                INDEX Servis_Index (ServisID)
            );
        ";

        public static void InitializeDatabase()
        {
            Database.connection = new MySqlConnection(CONNECTION_STRING);
            if (connection == null)
                throw new DBException("Failed to establish database connection!");

            Database.connection.Open();
            using (var command = new MySqlCommand(TABLE_QUERY, Database.connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public static void Dispose()
        {
            if (Database.connection == null) return;
            Database.connection.Close();
        }
    }
}
