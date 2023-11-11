using System;
using System.Collections.Generic;

class User
{
    public int ID { get; set; }
    public string Name { get; set; }
    public char Gender { get; set; }
}

class Program
{
    static List<User> users = new List<User>();

    static void Main()
    {
        int numUsers;
        while (true)
        {
            try
            {
                Console.Write("Enter the number of users: ");
                numUsers = int.Parse(Console.ReadLine());
                if (numUsers < 0)
                {
                    throw new ArgumentException("Number of users cannot be negative.");
                }
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        for (int i = 1; i <= numUsers; i++)
        {
            User user = new User();
            Console.WriteLine($"User {i}:");
            user.ID = i;

            try
            {
                Console.Write("Enter Name: ");
                user.Name = Console.ReadLine();

                Console.Write("Enter Gender (M/F): ");
                user.Gender = char.Parse(Console.ReadLine());

                if (user.Gender != 'M' && user.Gender != 'F')
                {
                    throw new ArgumentException("Gender must be 'M' or 'F'.");
                }
                users.Add(user);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid value.");
                i--;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                i--;
            }
        }

        while (true)
        {
            Console.WriteLine("Choose an operation: ");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Delete User");
            Console.WriteLine("3. Update User");
            Console.WriteLine("4. Search User");
            Console.WriteLine("5. Exit");

            try
            {
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddUser();
                        break;
                    case 2:
                        DeleteUser();
                        break;
                    case 3:
                        UpdateUser();
                        break;
                    case 4:
                        SearchUser();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose a valid option.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    static void AddUser()
    {
        User user = new User();
        Console.WriteLine("Add User:");
        user.ID = users.Count + 1;

        try
        {
            Console.Write("Enter Name: ");
            user.Name = Console.ReadLine();

            Console.Write("Enter Gender (M/F): ");
            user.Gender = char.Parse(Console.ReadLine());

            if (user.Gender != 'M' && user.Gender != 'F')
            {
                throw new ArgumentException("Gender must be 'M' or 'F'.");
            }
            users.Add(user);
            Console.WriteLine("User added successfully.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid value.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void DeleteUser()
    {
        Console.WriteLine("Enter the ID of the user to delete: ");
        int id;
        if (int.TryParse(Console.ReadLine(), out id))
        {
            User userToDelete = users.Find(u => u.ID == id);
            if (userToDelete != null)
            {
                users.Remove(userToDelete);
                Console.WriteLine("User deleted successfully.");
            }
            else
            {
                Console.WriteLine("User with that ID does not exist.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static void UpdateUser()
    {
        Console.WriteLine("Enter the ID of the user to update: ");
        int id;
        if (int.TryParse(Console.ReadLine(), out id))
        {
            User userToUpdate = users.Find(u => u.ID == id);
            if (userToUpdate != null)
            {
                Console.WriteLine("Update User:");
                Console.Write("Enter Name: ");
                userToUpdate.Name = Console.ReadLine();
                Console.Write("Enter Gender (M/F): ");
                userToUpdate.Gender = char.Parse(Console.ReadLine());

                if (userToUpdate.Gender != 'M' && userToUpdate.Gender != 'F')
                {
                    Console.WriteLine("Invalid input. Gender must be 'M' or 'F'.");
                }
                else
                {
                    Console.WriteLine("User updated successfully.");
                }
            }
            else
            {
                Console.WriteLine("User with that ID does not exist.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static void SearchUser()
    {
        Console.WriteLine("Enter the ID of the user to search: ");
        int id;
        if (int.TryParse(Console.ReadLine(), out id))
        {
            User userToSearch = users.Find(u => u.ID == id);
            if (userToSearch != null)
            {
                Console.WriteLine($"User ID: {userToSearch.ID}");
                Console.WriteLine($"User Name: {userToSearch.Name}");
                Console.WriteLine($"User Gender: {userToSearch.Gender}");
            }
            else
            {
                Console.WriteLine("User with that ID does not exist.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}