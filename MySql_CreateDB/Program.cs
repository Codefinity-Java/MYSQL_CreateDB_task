using MySql.Data.MySqlClient;

public class MySqlCreateDB
{
    // You can modify the connection string here
    public static string connectionString = "server=your_host;port=xxxx;user=your_user;password=your_pass;";

    public static void Main(string[] args)
    {
        CreateDatabase();
    }

    public static void CreateDatabase()
    {
        // Modify code below this line
        MySqlConnection connection = new MySqlConnection(connectionString)
        connection.Open();

        Console.WriteLine("Successfully Connected To The MySQL Server");

        string commandText = "CREATE DATABASE IF NOT EXISTS office";
        var command = ___;
        command.___;
        // Modify code above this line
    }
}