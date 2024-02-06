namespace AddressBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;




    internal class Program
    {
       public static List<Contact> contacts = new List<Contact>();
        private static IEnumerable<object> allActive;
        private object firstName;
        private object Lastname;
        private object lastName;

        public object Firstname { get; private set; }

        public static void Main(string[] args)
        {
            AddContact ac = new AddContact();
            DeleteContact dc = new DeleteContact();
            UpdateContact uc = new UpdateContact();
            ShowContact sc = new ShowContact();


            Program ob = new Program();
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

            Contact contact = new Contact

            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                City = city,
                State = state,
                Zip = zip,
                Phno = phoneNumber,
                Email = email
            };
            contacts.Add(contact);


            Console.WriteLine("******** contact detali ********");
            Console.WriteLine("1.Add Contact \n" +
                "2.Update \n" +
                "3.Delete\n" +
                "4.Show");
            Console.WriteLine("enter option");
            int option = Convert.ToInt32(Console.ReadLine());
            //  Program ob = new Program();
            switch (option)
            {
                case 1:
                    ac.Add();

                    break;

                case 2:
                    uc.Update();
                   
                    break;

                case 3:
                    dc.Delete();
                    Console.WriteLine("record deleted successfully...");
                    break;
                case 4:
                    sc.Show();
                    Console.WriteLine("show contact record");
                    break;


            }




        }
        /*  public void Add()
          {
              Main(new string[] { });

          }*/






    }





}