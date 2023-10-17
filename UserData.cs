using System;
using System.Collections.Generic;

class User
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
}

class Program
{
    static void Main()
    {
        List<User> users = new List<User>();

        try
        {
            Console.Write("Enter the number of users: ");
            int numberOfUsers = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numberOfUsers; i++)
            {
                User user = new User();

                bool isUniqueId = false;
                do
                {
                    Console.Write($"Enter ID for User {i}: ");
                    user.ID = Convert.ToInt32(Console.ReadLine());
                    isUniqueId = !users.Exists(u => u.ID == user.ID);

                    if (!isUniqueId)
                    {
                        Console.WriteLine("User ID already exists. Please enter a unique ID.");
                    }
                } while (!isUniqueId);

                Console.Write($"Enter Name for User {i}: ");
                user.Name = Console.ReadLine();

                Console.Write($"Enter Gender for User {i}: ");
                user.Gender = Console.ReadLine();

                users.Add(user);
            }
            Console.WriteLine("\nAvailable Operations:");
            Console.WriteLine("1. ADD User");
            Console.WriteLine("2. DELETE User");
            Console.WriteLine("3. UPDATE User");
            Console.WriteLine("4. SEARCH User");

            Console.Write("Enter the operation number: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    // ADD User
                    User newUser = new User();
                    bool isUnique = false;
                    do
                    {
                        Console.Write("Enter ID for the new user: ");
                        newUser.ID = Convert.ToInt32(Console.ReadLine());
                        isUnique = !users.Exists(u => u.ID == newUser.ID);

                        if (!isUnique)
                        {
                            Console.WriteLine("User ID already exists. Please enter a unique ID.");
                        }
                    } while (!isUnique);

                    Console.Write("Enter Name for the new user: ");
                    newUser.Name = Console.ReadLine();
                    Console.Write("Enter Gender for the new user: ");
                    newUser.Gender = Console.ReadLine();
                    users.Add(newUser);
                    Console.WriteLine("User added successfully.");
                    break;

                case 2:
                    Console.Write("Enter ID of the user to delete: ");
                    int deleteID = Convert.ToInt32(Console.ReadLine());
                    User userToDelete = users.Find(u => u.ID == deleteID);
                    if (userToDelete != null)
                    {
                        users.Remove(userToDelete);
                        Console.WriteLine("User deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("User not found.");
                    }
                    break;

                case 3:
                    Console.Write("Enter ID of the user to update: ");
                    int updateID = Convert.ToInt32(Console.ReadLine());
                    User userToUpdate = users.Find(u => u.ID == updateID);
                    if (userToUpdate != null)
                    {
                        Console.Write("Enter new Name: ");
                        userToUpdate.Name = Console.ReadLine();
                        Console.Write("Enter new Gender: ");
                        userToUpdate.Gender = Console.ReadLine();
                        Console.WriteLine("User updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("User not found.");
                    }
                    break;

                case 4:
                    Console.Write("Enter ID of the user to search: ");
                    int searchID = Convert.ToInt32(Console.ReadLine());
                    User foundUser = users.Find(u => u.ID == searchID);
                    if (foundUser != null)
                    {
                        Console.WriteLine($"User found - ID: {foundUser.ID}, Name: {foundUser.Name}, Gender: {foundUser.Gender}");
                    }
                    else
                    {
                        Console.WriteLine("User not found.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operation number.");
                    break;
            }
            Console.WriteLine("\nList of Users:");
            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.ID}, Name: {user.Name}, Gender: {user.Gender}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter valid integers.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred : {ex.Message}");
        }
    }
}
