using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AddressBook
{
	class Program
	{
		static void Main(string[] args)	{ Initialize(); }

		private static void Initialize()
		{
			int contactID = 1;
			if (File.Exists("contacts.txt"))
			{
				Console.WriteLine("File found.\n");
				
				string[] contents = File.ReadAllLines(@"contacts.txt");
				foreach (string line in contents)
				{
					
					Console.WriteLine(contactID + "\t" + line);
					contactID++;
				}
			}
			else if (!File.Exists("contacts.txt"))
			{
				Console.WriteLine("File not found. Creating one.");
				File.Create("contacts.txt");
			}
			Menu();
		}

		private static void Menu()
		{
			Console.Write(
				"\n\n1 - Add" +
				"\n2 - Remove" +
				"\n\nOption: ");

			var option = Convert.ToInt32(Console.ReadLine());

			switch (option)
			{
				case 1: AddContact(); break;
				case 2: RemoveContact(); break;
				default: Console.WriteLine("Select a valid number (1 or 2)"); break;
			}
		}

		private static void AddContact()
		{
			List<List<Contact>> Contacts = new List<List<Contact>>();

			Contact contact = new Contact();

			Console.Write("Name: "); var name = Console.ReadLine();
			contact.name = name;

			Console.Write("Email address: "); var email = Console.ReadLine();
			contact.email = email;

			Console.Write("Mobile No.: "); var mobile = Console.ReadLine();
			contact.mobile = mobile;

			Contacts.Add(new List<Contact> { contact });

			File.AppendAllText("contacts.txt", $"{contact.name}\t{contact.email}\t{contact.mobile}\n");
			Console.WriteLine("Your contact has been saved!");

			Initialize();
		}

		private static void RemoveContact()
		{
			Console.WriteLine("Enter the ID of the contact to be removed: ");
			int ID = Convert.ToInt32(Console.ReadLine());

			var contacts = File.ReadAllLines("contacts.txt").ToList();
			
			contacts.RemoveAt(ID - 1);
			Console.WriteLine("Contact removed!");

			File.WriteAllLines("contacts.txt", contacts);

			Initialize();
		}
	}
}

public class Contact
{
	public string name { get; set; }
	public string email { get; set; }
	public string mobile { get; set; }
}