using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace R2M
{

    /// <summary>
    /// Represents a private or business customer in the AwesomeSystem
    /// </summary>
    public class Customer : iParty, IComparable<Customer>
    {
        public Customer()
        {
            //Do cool stuff here. Or maybe a factory pattern?
        }
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Grants sort ability of the Name property
        /// </summary>
        /// <param name="other">Another customer</param>
        /// <returns>-1, 0, 1 depending on </returns>
        public int CompareTo(Customer other)
        {
            // Null safe
            return string.Compare(Name, other.Name);
        }


        /// <summary>
        /// Name of customer
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Database ID of customer (ROW)
        /// </summary>
        public Guid InternalID { get; private set; }

        /// <summary>
        /// Human friendly customer ID
        /// </summary>
        public string CustomerID { get; private set; }

        /// <summary>
        /// Email adress to customer. Mandatory
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// [True] if the customer havev accepted to receive newsletters via email. Otherwise [FALSE]
        /// </summary>
        public bool WantToReceiveNewsletter { get; set; }
        
        /// <summary>
        /// All the availible adresses to the customer
        /// </summary>
        public IEnumerable<AdressInfo> Adress { get; private set; }

        /// <summary>
        /// Phone number to Customer
        /// </summary>
        public IEnumerable<PhoneNumber> Phonenumber { get; private set; }

    }

    public interface iParty
    {
        string Name {get;set;}
        Guid InternalID { get; }
        string Email { get; set; }

        IEnumerable<AdressInfo> Adress { get; }
    }

    /// <summary>
    /// Adress to Private/business/other entity
    /// </summary>
    public class AdressInfo
    {
        public string Name { get; set; }
        public bool Primary { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        /// <summary>
        /// Please specify of which type the adress is
        /// </summary>
        public ContactType Type { get; set; }
    }

    public class PhoneNumber
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string Ext { get; set; }
        public ContactType Type { get; set; }
    }

    public enum ContactType :int
    {
        Other,
        Private,
        Business,
        Billing,
        Shipment
    }
}