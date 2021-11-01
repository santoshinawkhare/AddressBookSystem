using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
     class ContactPersons : ContactAddress
    {
        public string FirstName;
        public string LastName;
        public string PhoneNumber;
        public string Email;

        public List<ContactPersons> AddressBook = new List<ContactPersons>();

        public void AddContact(ContactPersons contactPerson)
        {
            AddressBook.Add(contactPerson);
        }
        public void EditContact(ContactPersons contactPerson)
        {
            Console.WriteLine("Please select following options to change\n");
            Console.WriteLine("1.First Name \n 2.Last Name \n 3.Phone Number \n 4.Email \n");
            int chooseOption = Convert.ToInt32(Console.ReadLine());
            switch (chooseOption)
            {
                case 1:
                    Console.WriteLine("Please enter first name");
                    contactPerson.FirstName = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Please enter last name");
                    contactPerson.LastName = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Please enter phone number");
                    contactPerson.PhoneNumber = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Please enter email");
                    contactPerson.Email = Console.ReadLine();
                    break;
            }
        }
        public void DeleteContact()
        {
            string Delete;
            do
            {
                Console.WriteLine("Would you like to delete a contact (Y/N)");
                Delete = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter contact first name");
                string firstName = Convert.ToString(Console.ReadLine());
                var findContact = AddressBook.Find(f => f.FirstName == firstName);
                if (findContact != null)
                {
                    AddressBook.Remove(findContact);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

            } while (Delete == "Y" || Delete == "y");
        }

        public void DisplayAddressBook()
        {
            foreach (var sn in AddressBook)
            {
                Console.WriteLine("{0}\n {1}\n {2}\n {3}\n {4}\n {5}\n {6}\n {7}\n",
                    sn.FirstName, sn.LastName, sn.State, sn.City, sn.Address, sn.Zip,sn.PhoneNumber, sn.Email);
            }
        }
    }
}
