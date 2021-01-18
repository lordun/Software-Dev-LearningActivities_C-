using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity1_ContactList
{
    public class ContactList
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public void ContactDisplay()
        {
            Console.WriteLine("Name: " + Name + ", Phone: " + Phone);
        }
    }
    class Program
    {
        static void Display(List<ContactList> myContact)
        {
            Console.WriteLine("Contact Name and Numbers: ");
            foreach (var contact in myContact)
            {
                contact.ContactDisplay();
            }
            Console.WriteLine();
        }
        static void Display(List<ContactList> myContact, string name)
        {
            Console.WriteLine("All records of: " + name);
            foreach (var record in myContact)
            {
                record.ContactDisplay();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<ContactList> contactList = new List<ContactList>();
            string input;
            string[] split;

            do
            {
                Console.WriteLine("Please enter a command");
                input = Console.ReadLine();
                input = input.ToLower();

                while (input.Contains("  ")) input = input.Replace("  ", " ");
                input = input.Trim();
                split = input.Split(' ');

                if (input.Length == 0) continue;
                else if (split[0].CompareTo("display") == 0)
                {
                    Display(contactList);
                }
                else if (split[0].CompareTo("add") == 0)
                {
                    string phone = split[split.Length - 1];
                    string name = string.Join(" ", split, 1, split.Length - 2);
                    contactList.Add(new ContactList() { Name = name, Phone = phone });
                }
                else if (split[0].CompareTo("delete") == 0)
                {
                    string phone = split[1];
                    ContactList delNum = contactList.Find(a => a.Phone == phone);
                    contactList.Remove(delNum);
                }
                else if (split[0].CompareTo("update") == 0)
                {
                    string oldPhone = split[1];
                    string newPhone = split[split.Length - 1];
                    string newName = string.Join(" ", split, 2, split.Length - 3);
                    ContactList delNum = contactList.Find(a => a.Phone == oldPhone);
                    contactList.Remove(delNum);
                    contactList.Add(new ContactList() { Name = newName, Phone = newPhone });
                }
                else if (split[0].CompareTo("find") == 0)
                {
                    string name = string.Join(" ", split, 1, split.Length - 1);
                    List<ContactList> findContact = contactList.FindAll(a => a.Name == name);
                    Display(findContact, name);
                }
                else
                {
                    Console.WriteLine("\nUnknown command entered. Please try again.");
                }

            } while(input.CompareTo("exit") != 0);

            Console.Read();
        }
    }
}
