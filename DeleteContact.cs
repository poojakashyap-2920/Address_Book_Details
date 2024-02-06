using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class DeleteContact
    {
        public void Delete()
        {

            Console.WriteLine("Enter first name...");
            string fn = Console.ReadLine();

            Console.WriteLine("Enter last name...");
            string ln = Console.ReadLine();


            Contact contactToDelete = Program.contacts.FirstOrDefault(c => c.FirstName.Equals(fn) && c.LastName.Equals(ln));

            if (contactToDelete != null)
            {
                Program.contacts.Remove(contactToDelete);
                Console.WriteLine("Contact deleted successfully!");
            }
            else
            {
                Console.WriteLine("Contact not found");
            }
            Console.WriteLine("contact deleted succesfully..");
        }
    }
}
