using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddContact
    {
        public void Add()
        {
            Console.WriteLine("**********  Contact detail....  ***********");
            Console.WriteLine("Enter first name...");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name...");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter address...");
            string address = Console.ReadLine();

            Console.WriteLine("Enter city...");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state...");
            string state = Console.ReadLine();

            Console.WriteLine("Enter zip...");
            int zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter phone number...");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter email...");
            string email = Console.ReadLine();
            Program.Main(new string[] { });
            Console.WriteLine("record added successfully...");
            Console.ReadLine();

        }
    }

}
