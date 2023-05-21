using KpopZtation_GroupB.Model;
using KpopZtation_GroupB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Handler
{
    public class CustomerHandler
    {
        public static void CreateCustomer(String name, String email, String gender, String address, String password, String role)
        {
            CustomerRepository.CreateCustomer(name, email, gender, address, password, role);
        }

        public static Customer Login(String email, String password)
        {
            return CustomerRepository.Login(email, password);
        }

        public static bool UpdateCustomer(int id, String name, String email, String gender, String address, String password)
        {
            return CustomerRepository.UpdateCustomer(id, name, email, gender, address, password);
        }
    }
}