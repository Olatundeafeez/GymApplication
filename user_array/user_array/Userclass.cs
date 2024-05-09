using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_array
{
    public class Userclass
    {
        //fields
        string name;
        string email;
        string password;
        string phone_number;
        string address;
        string gender;

        //properties
        public string Name { get; set; }  
        public string Email { get; set; }
        public string Password { get; set; }    
        public string PhoneNumber { get; set; } 
        public string Address { get; set; } 
        public string Gender { get; set; }

        //constructor
        public Userclass(string name, string email, string password, string phone_number, string address, string gender)
        {
            name = Name;
            email = Email;
            password = Password;
            phone

        }
        //method

        public static void Mymethod()
        {
            Console.WriteLine("enter your name /n your name should not be less than 4 ");
            string name = Console.ReadLine();

            Console.WriteLine("enter your email ");
            string email = Console.ReadLine();

            Console.writeline("enter your password /n password must not be less than 8 letters ");
            string password = console.readline();

            console.writeline("enter your phone number ");
            string phone_number = console.readline();

            console.writeline("enter your address ");
            string address = console.readline();

            console.writeline("enter your gender ");
            string gender = console.readline();
        }
 }
     }
