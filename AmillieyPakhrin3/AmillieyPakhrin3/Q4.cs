using MySql.Data.MySqlClient;
using System;

namespace DatabaseEditDelete
{
    class Program
    {
        static void Main()
        {
            string connectionString = "SERVER=localhost;DATABASE=db_dotnet;UID=root;PASSWORD=;";

            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                try
                {
                    connect.Open();

                    Console.WriteLine("Choose an operation: ");
                    Console.WriteLine("1 = Edit Student");
                    Console.WriteLine("2 = Delete Student");
                    Console.Write("Your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                    {
                        // EDIT operation
                        Console.Write("Enter roll number of student to edit: ");
                        int roll = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter new name: ");
                        string newName = Console.ReadLine();

                        Console.Write("Enter new email: ");
                        string newEmail = Console.ReadLine();

                        Console.Write("Enter new phone: ");
                        string newPhone = Console.ReadLine();

                        Console.Write("Enter new course: ");
                        string newCourse = Console.ReadLine();

                        string updateQuery = "UPDATE students SET name=@name, email=@email, phone=@phone, course=@course WHERE roll=@roll";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, connect);
                        updateCmd.Parameters.AddWithValue("@name", newName);
                        updateCmd.Parameters.AddWithValue("@email", newEmail);
                        updateCmd.Parameters.AddWithValue("@phone", newPhone);
                        updateCmd.Parameters.AddWithValue("@course", newCourse);
                        updateCmd.Parameters.AddWithValue("@roll", roll);

                        int rows = updateCmd.ExecuteNonQuery();
                        if (rows > 0)
                            Console.WriteLine("Student record updated successfully.");
                        else
                            Console.WriteLine("Update failed. No student found with that roll number.");
                    }
                    else if (choice == 2)
                    {
                        // DELETE operation
                        Console.Write("Enter roll number of student to delete: ");
                        int roll = Convert.ToInt32(Console.ReadLine());

                        string deleteQuery = "DELETE FROM students WHERE roll=@roll";
                        MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connect);
                        deleteCmd.Parameters.AddWithValue("@roll", roll);

                        int rows = deleteCmd.ExecuteNonQuery();
                        if (rows > 0)
                            Console.WriteLine("Student record deleted successfully.");
                        else
                            Console.WriteLine("Delete failed. No student found with that roll number.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
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
}

