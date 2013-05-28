/* A company has name, address, phone number, fax number, web site and manager. 
 * The manager has first name, last name, age and a phone number. 
 * Write a program that reads the information about a company and its manager and prints them on the console.*/

using System;

class Company
{
    static void Main()
    {
        Console.WriteLine("Company's information:");
        Console.Write("Name: ");
        string companyName = Console.ReadLine();
        Console.Write("Address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string companyFaxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string companyWebSite = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Manager's information:");
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();
        string managerName = firstName + " " + lastName;
        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Phone Number: ");
        string managerPhoneNumber = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Company's information:\nName:         {0}\nAddress:      {1}\nPhone number: {2}\nFax number:   {3}\nWeb site:     {4}\nManager:      {5}\n", companyName, companyAddress, companyPhoneNumber, companyFaxNumber, companyWebSite, managerName);
        Console.WriteLine("Manager's information:\n{0}, {1}г.\n{2}\n", managerName, age, managerPhoneNumber);
    }
}    