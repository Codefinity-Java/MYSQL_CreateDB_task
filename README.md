# Description
Your task is to:
1. Create a `MySqlCommand` object using the `commandText` command and the `connection` object;
2. Execute the command using the appropriate method;
3. Close the connection after executing the command;
4. Enclose the code into a try-catch block to make it safer;

**Note:** The test cases related to the datebase tasks will only pass if it connects to an actual database so for this task you need to have the MySql database installed on your device. You can modify the connection string to your local database details for testing purposes. Alternatively, you can compare your code with the given solution code.

### Hints
> **Hint 1:** The command is a non-query so the suitable method for executing it will be `ExecuteNonQuery`;

> **Hint 2:** You can either use the `Close` method of the `MySqlConnection` object to close the connection, or you can utilize the `using` statement.
