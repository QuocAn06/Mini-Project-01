using ContactManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagerApp.Services
{
    public class ContactManager
    {
        private List<Contact> contacts = new List<Contact>();

        public List<Contact> listContacts => contacts;

        // Add Contact method
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
            Console.WriteLine("Contact added successfully.");
        }

        // Search Contact method
        public List<Contact> SearchByName(string keyword)
        {
            var results = contacts.Where(c => c.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
            return results;
        }

        public List<Contact> SearchByPhone(string keyword)
        {
            var results = contacts.Where(c => c.Phone.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
            return results;
        }

        public List<Contact> SearchByEmail(string keyword)
        {
            var results = contacts.Where(c => c.Email.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
            return results;
        }

        // Delete Contact method
        public bool DeleteContact(string name)
        {
            var contactToRemove = contacts.FirstOrDefault(c=>c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (contactToRemove != null)
            {
                contacts.Remove(contactToRemove);
                return true;
            }

            return false;
        }

        // Save Contacts To File CSV method (string path)
        public void SaveToCsv(string filePath)
        {
            using(var writer = new StreamWriter(filePath))
            {
                foreach (var contact in contacts)
                {
                    writer.WriteLine($"{contact.Name}, {contact.Phone}, {contact.Email}");
                }
            }
        }

        // Load Contacts From File CSV method (string path)
        public void LoadFromCsv(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            contacts.Clear();

            using (var reader = new StreamReader(filePath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        contacts.Add(new Contact
                        {
                            Name = parts[0].Trim(),
                            Phone = parts[1].Trim(),
                            Email = parts[2].Trim()
                        });
                    }
                }
            }
        }

        // Async Save Contacts To File CSV method (string path)
        public async Task SaveToCsvAsync(string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                foreach (var contact in contacts)
                {
                    await writer.WriteLineAsync($"{contact.Name}, {contact.Phone}, {contact.Email}");
                }
            }
        }

        // Async Load Contacts From File CSV method (string path)
        public async Task LoadFromCsvAsync(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            contacts.Clear();
            
            using (var reader = new StreamReader(filePath))
            {
                string? line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        contacts.Add(new Contact
                        {
                            Name = parts[0].Trim(),
                            Phone = parts[1].Trim(),
                            Email = parts[2].Trim()
                        });
                    }
                }
            }
        }

    }
}
