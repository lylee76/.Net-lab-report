using MySql.Data.MySqlClient;
using System;

namespace LINQ
{
    class DatabaseInsertSelect
    {
        static void Main(string[] args)
        {
            try
            {
                string connectionString = "SERVER=localhost;DATABASE=db_dotnet;UID=root;PASSWORD=;";
                using (MySqlConnection connect = new MySqlConnection(connectionString))
                {
                    connect.Open();

                    // Input student data
                    Console.Write("Enter rollno: ");
                    int roll = int.Parse(Console.ReadLine());

                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter email: ");
                    string email = Console.ReadLine();

                    Console.Write("Enter phone: ");
                    string phone = Console.ReadLine();

                    Console.Write("Enter course: ");
                    string course = Console.ReadLine();

                    // INSERT operation
                    string insertQuery = "INSERT INTO students (roll, name, email, phone, course) VALUES (@roll, @name, @email, @phone, @course)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, connect);
                    insertCmd.Parameters.AddWithValue("@roll", roll);
                    insertCmd.Parameters.AddWithValue("@name", name);
                    insertCmd.Parameters.AddWithValue("@email", email);
                    insertCmd.Parameters.AddWithValue("@phone", phone);
                    insertCmd.Parameters.AddWithValue("@course", course);

                    int rows = insertCmd.ExecuteNonQuery();
                    if (rows == 1)
                        Console.WriteLine("Student added successfully.\n");
                    else
                        Console.WriteLine("Student addition failed.\n");

                    // SELECT operation
                    string selectQuery = "SELECT roll, name, email, phone, course FROM students";
                    MySqlCommand selectCmd = new MySqlCommand(selectQuery, connect);
                    MySqlDataReader reader = selectCmd.ExecuteReader();

                    Console.WriteLine("Student Records:");
                    Console.WriteLine("Roll\tName\tEmail\t\tPhone\t\tCourse");                   
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["roll"]}\t{reader["name"]}\t{reader["email"]}\t{reader["phone"]}\t{reader["course"]}");
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
