namespace ContactManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact[] contacts = new Contact[10]; // Array with space for 10 contacts
            int contactCount = 0; // Keeps track of the number of contacts

            while (true)
            {
                Console.WriteLine("\nContact Management System Menu:");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. View All Contacts");
                Console.WriteLine("3. Search Contact by Name");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (contactCount < contacts.Length)
                        {
                            Console.Write("Enter Name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter Phone Number: ");
                            string phoneNumber = Console.ReadLine();

                            Console.Write("Enter Email: ");
                            string email = Console.ReadLine();

                            Contact newContact = new Contact
                            {
                                Name = name,
                                PhoneNumber = phoneNumber,
                                Email = email
                            };

                            contacts[contactCount] = newContact; // Add contact to array
                            contactCount++;
                            Console.WriteLine("Contact added successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Contact list is full. Cannot add more contacts.");
                        }
                        break;

                    case "2":
                        if (contactCount > 0)
                        {
                            Console.WriteLine("\nAll Contacts:");
                            for (int i = 0; i < contactCount; i++)
                            {
                                contacts[i].DisplayContact();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No contacts to display.");
                        }
                        break;

                    case "3":
                        Console.Write("Enter the name to search: ");
                        string searchName = Console.ReadLine();
                        bool found = false;

                        for (int i = 0; i < contactCount; i++)
                        {
                            if (contacts[i].Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                            {
                                contacts[i].DisplayContact();
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine("Contact not found.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
