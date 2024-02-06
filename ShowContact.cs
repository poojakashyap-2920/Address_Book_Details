using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class ShowContact
    {
        public void Show()
        {
            foreach (Contact contact in Program.contacts)
            {
                Console.WriteLine($"FirstName : {contact.FirstName}\nLastName : {contact.LastName}\nAddress : {contact.Address}\nCity : {contact.City}\n State : {contact.State}\n Zip : {contact.Zip}\n Phno : {contact.Phno}\n Email : {contact.Email}");
            }
        }
    }
}
