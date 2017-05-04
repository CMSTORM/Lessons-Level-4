using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Company
    {
        static void Main(string[] args)
        {

            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            string CompanyName = Console.ReadLine();
            string adress = Console.ReadLine();
            string webSite = Console.ReadLine();
            int phone = int.Parse(Console.ReadLine());
            Console.WriteLine("The company is \"{0}\" with manager - {1} {2}.The phone is {3:0000000000} , the adress is {4} and the website is \"{5} \" ",
                CompanyName, managerFirstName, managerLastName, phone,adress,webSite);
        }
    }
}
