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
    public class Letter : Parcel
    {
        // backing fields for letter properties

        decimal fixedCost; // fixed cost or fee

        // letter constructor
        // precondition: origin & destination address objects
        // poscondition: specifies origin & destination address, and fixed cost
        public Letter(Address OriginAddress, Address DestinationAddress, decimal FixedCost) : base(OriginAddress, DestinationAddress)
        {
            fixedCost = 2.75M;
            FixedCost = fixedCost;

        }

        // letter properties start

        // property to set fixed cost
        protected decimal FixedCost
        {
            // precondition: none
            // postcondition: fixed cost string is returned
            get
            {
                return fixedCost;
            }

            // precondition: fixed cost is not empty
            // postcondition: fixed cost string is set
            set
            {
                if (value >= 0)
                {
                    fixedCost = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value,
                        $"{nameof(FixedCost)} must be greater than or equal to $0.00");
                }
            }
        }

        // override calcCost method
        // precondition: none
        // poscondition: returns fixed cost specified in constructor
        public override decimal CalcCost()
        {
            return FixedCost;
        }

        // ToString() method
        // precondition: parcel & address ToString methods return all formatted values
        // poscondition: returns formatted string (includes all values plus fixed cost)
        public override string ToString() =>
            $"{base.ToString()}Cost: {CalcCost():C2} \n";
    }
}
