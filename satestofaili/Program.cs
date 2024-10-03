using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, string> contacts = new Dictionary<string, string>();

    static void Main(string[] args)
    {
        Task1();
        Task2();
        Task4();
    }

    static void Task1()
    {
        Console.WriteLine("Please enter the size of the array:");
        var x = Convert.ToInt32(Console.ReadLine());    
        int[] size = new int[x];
        

    
        for (int i = 0; i < x; i++)
        {
            Console.WriteLine($"Enter number {i + 1}:");
            while (!int.TryParse(Console.ReadLine(), out size[i]))
            {
                Console.WriteLine("Invalid input. Please enter an integer:");
            }
        }

        List<int> evenNumbers = new List<int>();
        List<int> oddNumbers = new List<int>();

        foreach (var number in size)
        {
            if (number % 2 == 0)
                evenNumbers.Add(number);
            else
                oddNumbers.Add(number);
        }

        Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
        Console.WriteLine("Odd numbers: " + string.Join(", ", oddNumbers));
    }

    static void Task2()
    {
        while (true)
        {
            Console.WriteLine("Contact Management Application");
            Console.WriteLine("1. Add New Contact");
            Console.WriteLine("2. Remove Existing Contact");
            Console.WriteLine("3. Update Existing Contact");
            Console.WriteLine("4. Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddContact();
                    break;
                case "2":
                    RemoveContact();
                    break;
                case "3":
                    UpdateContact();
                    break;
                case "4":
                    return;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddContact()
    {
        Console.Write("Enter contact name: ");
        string name = Console.ReadLine();
        Console.Write("Enter contact phone number: ");
        string phoneNumber = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phoneNumber))
        {
            Console.WriteLine("Name and phone number cannot be empty.");
            return;
        }

        if (contacts.ContainsKey(name))
        {
            Console.WriteLine("Contact already exists.");
        }
        else
        {
            contacts[name] = phoneNumber;
            Console.WriteLine("Contact added successfully.");
        }
    }

    static void RemoveContact()
    {
        Console.Write("Enter contact name to remove: ");
        string name = Console.ReadLine();

        if (contacts.Remove(name))
        {
            Console.WriteLine("Contact removed successfully.");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    static void UpdateContact()
    {
        Console.Write("Enter contact name to update: ");
        string name = Console.ReadLine();

        if (contacts.ContainsKey(name))
        {
            Console.Write("Enter new phone number: ");
            string newPhoneNumber = Console.ReadLine();
            contacts[name] = newPhoneNumber;
            Console.WriteLine("Contact updated successfully.");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    static void DisplayContacts()
    {
        Console.WriteLine("Contacts:");
        foreach (var contact in contacts)
        {
            Console.WriteLine($"Name: {contact.Key}, Phone: {contact.Value}");
        }
    }

    static void Task4()
    {
        Console.WriteLine("Please enter the number of elements in the array:");

     
        if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }

        int[] arr2 = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Enter number {i + 1}:");
            while (!int.TryParse(Console.ReadLine(), out arr2[i]))
            {
                Console.WriteLine("Invalid input. Please enter an integer:");
            }
        }

       
        int max = arr2[0];
        for (int i = 1; i < arr2.Length; i++)
        {
            if (arr2[i] > max)
            {
                max = arr2[i];
            }
        }

        string maxString = max.ToString();

 
        string firstTwoDigits = maxString.Length >= 2 ? maxString.Substring(0, 2) : maxString;

        Console.WriteLine($"First two digits of maximum value: {firstTwoDigits}");
    }
}
