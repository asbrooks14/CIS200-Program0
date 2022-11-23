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
    public abstract class Parcel
    {
        // backing fields for Address object properties

        public Address originAddress; // address object - origin address
        public Address destinationAddress; // address object - destination address

        // parcel constructor
        // precondition: none
        // poscondition: specifies origin & destination address as Address objects
        public Parcel(Address originAddress, Address destinationAddress)
        {
            OriginAddress = originAddress;
            DestinationAddress = destinationAddress;
        }

        // Parcel properties start

        // property to set origin address
        protected Address OriginAddress
        {
            // precondition: none
            // postcondition: origin address string is returned
            get
            {
                return originAddress;
            }

            // precondition: origin address is not empty
            // postcondition: origin address string is set
            set
            {
                if (OriginAddress == null)
                {
                    originAddress = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value,
                        $"{nameof(OriginAddress)} must not be empty");
               }
            }
        }

        // property to set destination address
        protected Address DestinationAddress
        {
            // precondition: none
            // postcondition: destination address string is returned
            get
            {
                return destinationAddress;
            }

            // precondition:destination address is not empty
            // postcondition: destination address string is set
            set
            {
                if (DestinationAddress == null)
                {
                    destinationAddress = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value,
                        $"{nameof(DestinationAddress)} must not be empty");
                }
            }
        }


        // CalcCost abstract method
        // precondition: no parameters
        // poscondition: returns given cost of parcel as a decimal
        public abstract decimal CalcCost();


        // ToString() method
        // precondition: origin & destination address set
        // poscondition: outputs formatted string (costs/fees
        // in currency format)
        public override string ToString() =>

            $"Origin Address: {OriginAddress}\n" +
            $"\nDestination Address: {DestinationAddress}\n";

    }
}
