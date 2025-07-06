using ContactManagerApp.Models;
using ContactManagerApp.Services;
using ContactManagerApp.Utils;

class Program
{
    static void Main(string[] args)
    {
        ContactManager manager = new ContactManager();
        string filePath = "contacts.csv";

        manager.LoadFromCsv(filePath); // Load data at startup

        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== Contact Manager Application ====");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Search Contact by Name");
            Console.WriteLine("3. Delete Contact");
            Console.WriteLine("4. Save Contacts to File");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1–5): ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    {
                        AddContact(manager);
                        break;
                    }

                case "2":
                    {
                        SearchContact(manager);
                        break;
                    }

                case "3":
                    {
                        DeleteContact(manager);
                        break;
                    }

                case "4":
                    {
                        manager.SaveToCsv(filePath);
                        Console.WriteLine("Contacts saved successfully.");
                        Pause();
                        break;
                    }

                case "5":
                    {
                        Console.WriteLine("Exiting program...");
                        return;
                    }

                default:
                    {
                        Console.WriteLine("Invalid choice. Please select 1–5.");
                        Pause();
                        break;
                    }
            }

        }
    }

    static void AddContact(ContactManager manager)
    {
        Console.WriteLine("\n=== Add New Contact ===");
        string name = InputHelper.GetNonEmptyString("Enter Name: ");
        string phone = InputHelper.GetValidPhone("Enter Phone (10–11 digits): ");
        string email = InputHelper.GetValidEmail("Enter Email: ");

        manager.AddContact(new Contact { Name = name, Phone = phone, Email = email });

        Console.WriteLine("Contact added successfully. Press any key to continue...");
        Pause();
    }

    static void SearchContact(ContactManager manager)
    {
        Console.WriteLine("\n--- Search Contact ---");
        string keyword = InputHelper.GetNonEmptyString("Enter name to search: ");

        var results = manager.SearchByName(keyword);

        if (results.Count == 0)
        {
            Console.WriteLine("No contacts found.");
        }
        else
        {
            Console.WriteLine("Found contacts:");
            foreach (var contact in results)
            {
                Console.WriteLine($"Name: {contact.Name}, Phone: {contact.Phone}, Email: {contact.Email}");
            }
        }

        Pause();
    }

    static void DeleteContact(ContactManager manager)
    {
        Console.WriteLine("\n--- Delete Contact ---");
        string name = InputHelper.GetNonEmptyString("Enter name to delete: ");
        bool success = manager.DeleteContact(name);

        Console.WriteLine(success ? "Contact deleted." : "Contact not found.");
        Pause();
    }

    static void Pause()
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}


