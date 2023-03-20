using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Factory
{
    public class CustomerFactory
    {
        public static Customer CreateCustomer(String name, String email, String password, String gender, String address, String role)
        {
            Customer c = new Customer();
            c.CustomerName = name;
            c.CustomerEmail = email;
            c.CustomerPassword = password;
            c.CustomerGender = gender;
            c.CustomerAddress = address;
            c.CustomerRole = role;
            return c;
        }
    }
}