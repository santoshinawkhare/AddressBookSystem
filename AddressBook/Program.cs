using System;

namespace AddressBook
{
    class Program
    {

        static string fName, lName, state, city, address, zip, phone, email;
        static string Add, Edit, Delete;

        static void Main(string[] args)
        {
            ContactPersons contact = new ContactPersons();

            Console.WriteLine("Welcome to Address Book Program");

            Console.WriteLine("Please select following options\n");
            Console.WriteLine("1.Entry \n 2.Add \n 3.Edit \n 4.Delete \n");
            int Option = Convert.ToInt32(Console.ReadLine());

            switch (Option)
            {
                case 1:
                    var newContact = AddNewContact();
                    contact.AddContact(newContact);
                    contact.DisplayAddressBook();
                    goto case 2;

                case 2:
                    do
                    {
                        contact.AddContact(AddNewContact());
                        Console.WriteLine("Would you like to add a new contact (Y/N)");
                        Add = Convert.ToString(Console.ReadLine());

                    } while (Add == "Y" || Add == "y");

                    contact.DisplayAddressBook();
                    goto case 3;

                case 3:
                    do
                    {
                        Console.WriteLine("Would you like to edit a contact (Y/N)");
                        Edit = Convert.ToString(Console.ReadLine());
                        if (Edit == "Y" || Edit == "y")
                        {
                            Console.WriteLine("Enter contact first name");
                            string firstName = Convert.ToString(Console.ReadLine());
                            var findContact = contact.AddressBook.Find(f => f.FirstName == firstName);
                            if (findContact != null)
                            {
                                contact.EditContact(findContact);
                            }
                            else
                            {
                                Console.Write("Invalid Input");
                            }
                        }
                    } while (Edit == "Y" || Edit == "y");

                    contact.DisplayAddressBook();
                    goto case 4;

                case 4:
                    contact.DeleteContact();
                    contact.DisplayAddressBook();
                    break;
            }
        }

        static ContactPersons AddNewContact()
        {
            Console.WriteLine("Please enter your first name");
            fName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            lName = Console.ReadLine();
            Console.WriteLine("Please enter your state");
            state = Console.ReadLine();
            Console.WriteLine("Please enter your city");
            city = Console.ReadLine();
            Console.WriteLine("Please enter your address");
            address = Console.ReadLine();
            Console.WriteLine("Please enter your zip");
            zip = Console.ReadLine();
            Console.WriteLine("Please enter your phone number");
            phone = Console.ReadLine();
            Console.WriteLine("Please enter your email");
            email = Console.ReadLine();

            ContactPersons person = new ContactPersons
            {
                FirstName = fName,
                LastName = lName,
                State = state,
                City = city,
                Address = address,
                Zip = zip,
                PhoneNumber = phone,
                Email = email
            };
            return person;
        }
    }
}

