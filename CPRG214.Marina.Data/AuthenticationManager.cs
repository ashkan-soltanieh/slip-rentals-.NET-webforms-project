using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG214.Marina.Data
{
    public class AuthenticationManager
    {
        public static CustomerDTO Authenticate(string firstName, string lastName, string city, string phone)
        {
            MarinaEntities db = new MarinaEntities();
            var authentication = Find(firstName, lastName);

            //if not authenticated create one retrun object. Add to memory
            if (authentication == null)
            {
                Customer customer = new Customer
                {
                    FirstName = firstName,
                    LastName = lastName,
                    City = city,
                    Phone = phone
                };
                db.Customers.Add(customer);
                db.SaveChanges();

                //return the new created object
                CustomerDTO dto = new CustomerDTO
                {
                    ID = customer.ID,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName
                };

                return dto;
            }
            //if authenticated return object
            else
            {
                CustomerDTO dto = new CustomerDTO
                {
                    ID = authentication.ID,
                    FirstName = authentication.FirstName,
                    LastName = authentication.LastName
                };
                return dto;
            }
        }
        private static Customer Find(string firstName, string lastName)
        {
            MarinaEntities db = new MarinaEntities(); // this is context object
            var authentication = db.Customers.
                SingleOrDefault(auth =>
                                auth.FirstName == firstName &&
                                auth.LastName == lastName);
            return authentication;
        }
    }
}
