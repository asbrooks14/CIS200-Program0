// Student ID: 5129153 
// Program # 0
// Due Date: 9/9/2021
// Course Section: 50
// This program lists letter/package delivery information along with mailing costs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program0
{
    class Program
    {
        static void Main()
        {
            // Test data

            // constructed 4 address objects
            Address address01 = new Address("John Smith", "4000 Mountain Way", "Apt. 2", "Chicago", "IL", 80000);
            Address address02 = new Address("Becky Green", "2000 Ocean Drive", "Louisville", "KY", 40000);
            Address address03 = new Address("Amber Johnson", "6000 Tree Road", "Los Angeles", "CA", 20000);
            Address address04 = new Address("Catherine Green", "8000 Sand Street", "New York", "NY", 60000);

            // constructed 3 letter objects using 4 address objects
            Letter letter01 = new Letter(address01, address02, 1M);
            Letter letter02 = new Letter(address03, address04, 20M);
            Letter letter03 = new Letter(address01, address04, 5M);

            // add letter objects to list of parcel objects
            List<Parcel> letters = new List<Parcel> { letter01, letter02, letter03 };
        
            // foreach loop to print all letters to console
            foreach (Parcel parcel in letters)
            {
                Console.WriteLine(parcel);
            }

                ReadLine(); // to prevent program close
        }

    }

}
