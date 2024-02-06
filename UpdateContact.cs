using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class UpdateContact
    {
     public   void Update()
        {
            Console.WriteLine("Enter first name...");
            string fn = Console.ReadLine();

            Console.WriteLine("Enter last name...");
            string ln = Console.ReadLine();

            Contact con = null;

            foreach (Contact c1 in Program.contacts)
            {
                if (c1.FirstName.Equals(fn) && c1.LastName.Equals(ln))
                {
                    con = c1;

                    Console.WriteLine("1.Firstname \n2.Lastname \n3.Address \n4.City \n5.State \n6.Zip \n7.Phone \n8.Email");
                    Console.WriteLine("Enter option...");
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter new first name...");
                            con.FirstName = Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("Enter new last name...");
                            con.LastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter new address...");
                            con.Address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter new city...");
                            con.City = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter new state...");
                            con.State = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter new zip...");
                            con.Zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("Enter new phone number...");
                            con.Phno = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter new email...");
                            con.Email = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }

                    Console.WriteLine($"{con.FirstName}\n{con.LastName}\n{con.Address}\n{con.City}\n{con.State}\n{con.Zip}\n{con.Phno}\n{con.Email}");
                }
            }

            if (con == null)
            {
                Console.WriteLine("Contact details not found. Unable to update.");
            }
            Console.WriteLine("record updated successfully...");
        }

    }
}
