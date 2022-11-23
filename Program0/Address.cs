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

namespace Program0
{
    public class Address
    {
        // backing fields for Address properties

        private string name;  // name for address
        private string address1; // address line 1, street
        private string address2; // address line 2, street or apt #
        private string city; // city for address
        private string state; // state (two letters, ex.) "KY") for address
        private int zip;  // zip code

        // address constructor 1
        // precondition: none
        // poscondition: initializes name, address line 1 & 2, city, state and zip
        public Address(string name, string address1, string address2, string city, string state, int zip)
        {
            Name = name;
            Address1 = address1;
            Address2 = address2;
            City = city;
            State = state;
            Zip = zip;

        }

        // constructor 2 (overloaded)
        // precondition: none
        // postcondition: initializes name, address (only 1 line), city, state and zip
        public Address(string name, string address1, string city, string state, int zip)
        {
            Name = name;
            Address1 = address1;
            City = city;
            State = state;
            Zip = zip;
        }


        // Address properties start

        // property to set name
        protected string Name
        {
            // precondition: none
            // postcondition: name string is returned
            get
            {
                return name;
            }

            // precondition: name is not blank
            // postcondition: name string is set
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value,
                        $"{nameof(Name)} must not be blank");
                }
            }
        }

        // property to set address 1
        protected string Address1
        {
            // precondition: none
            // postcondition: address string is returned
            get
            {
                return address1;
            }

            // precondition: address is not blank
            // postcondition: address string is set
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    address1 = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value,
                        $"{nameof(Address1)} must not be blank");
                }
            }
        }

        // property to set address 2
        protected string Address2
        {
            // precondition: none
            // postcondition: address string is returned
            get
            {
                return address2;
            }

            // precondition: address is not blank
            // postcondition: address string is set
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    address2 = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value,
                        $"{nameof(Address2)} must not be blank");
                }
            }
        }

        // property to set city
        protected string City
        {
            // precondition: none
            // postcondition: city string is returned
            get
            {
                return city;
            }

            // precondition: city is not blank
            // postcondition: city string is set
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    city = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value,
                        $"{nameof(City)} must not be blank");
                }
            }
        }

        // property to set state
        protected string State
        {
            // precondition: none
            // postcondition: state string is returned
            get
            {
                return state;
            }

            // precondition: state is not blank
            // postcondition: state string is set
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    state = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value,
                        $"{nameof(State)} must not be blank");
                }
            }
        }

        // property to set zip code
        protected int Zip
        {
            // precondition: none
            // postcondition: zipcode int is returned
            get
            {
                return zip;
            }

            // precondition: zipcode is between 00000 and 99999
            // postcondition: zip code has been set
            set
            {
                if (value >= 00000 && value <= 99999)
                {
                    zip = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value,
                        $"{nameof(Zip)} must be between 00000 and 99999");
                }
            }
        }

        // ToString() method
        // precondition: address properties set
        // poscondition: outputs formatted string (3-4 lines w/ name,
        // address line1&2, city state zip on bottom line. if there is
        // no address line 2, skip)
         public override string ToString()
        {
            if (Address2 is null)
            {
                return
            $"\n{Name}\n" +
            $"{Address1}\n" +
            $"{City}, {State} {Zip:D5}";
            }

            else
                return
            $"\n{Name}\n" +
            $"{Address1}\n" +
            $"{Address2}\n" +
            $"{City}, {State} {Zip:D5}";
        }
    }
}
