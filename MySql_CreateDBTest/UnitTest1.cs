using MySql.Data.MySqlClient;

namespace MySql_CreateDBTest
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestDatabaseCreation()
        {
            MySqlCreateDB.CreateDatabase();

            bool isDatabaseCreated = databaseExists(MySqlCreateDB.connectionString, "office");
            Assert.IsTrue(isDatabaseCreated);
        }

        private bool databaseExists(string connectionString, string databaseName)
        {
            bool result = false;
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = '{databaseName}'", connection);
                object databaseExists = cmd.ExecuteScalar();
                if (databaseExists != null && databaseExists.ToString() == databaseName)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
