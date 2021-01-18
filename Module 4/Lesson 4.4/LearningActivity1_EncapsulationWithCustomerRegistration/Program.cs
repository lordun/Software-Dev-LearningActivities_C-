using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity1_EncapsulationWithCustomerRegistration
{
    public class Customer
    {
        private string[] _name;
        private string _phone;

        public string Name
        {
            get
            {
                return _name[0][0] + ". " + _name[_name.Length - 1];
            }
            set
            {
                _name = value.Split(' ');
                do
                {
                    if (_name.Length == 1 || _name.Length > 3)
                    {
                        Console.WriteLine("Please enter your name in the correct format.");
                        _name = Console.ReadLine().Split();
                    }
                } while (_name.Length == 1 || _name.Length > 3);
            }
        }
        public string Phone
        {
            get
            {
                return _phone.Substring(0,3)+"-"+ _phone.Substring(3, 3) + "-" + _phone.Substring(6, 4);
            }
            set
            {
                _phone = value;
                do
                {
                    if (_phone.Length!= 10)
                    {
                        Console.WriteLine("Please enter your phone number in a 10 digit format.");
                        _phone = Console.ReadLine();
                    }
                } while (_phone.Length != 10);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer();

            Console.WriteLine("Please enter your full name:");
            obj.Name = Console.ReadLine();

            Console.WriteLine("Please enter your phone number without spaces or dashes:");
            obj.Phone = Console.ReadLine();

            Console.WriteLine("Welcome " + obj.Name + ", your contact number is: " + obj.Phone + ".");
            Console.Read();
        }
    }
}

