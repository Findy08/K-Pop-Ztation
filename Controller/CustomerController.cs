using KpopZtation_GroupB.Handler;
using KpopZtation_GroupB.Model;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Controller
{
    public class CustomerController
    {
    
        public static String validateLoginCustomer(String email, String password)
        {

            String response = "";
            if(string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password)) 
            {
                response = "Email and password must be filled";
            }
            else
            {
                Customer cust = doLogin(email, password);
                if (cust == null)
                {
                    response = "Email or password does not exist";
                }
                
            }
            return response;
        }

        public static Customer doLogin(String email, String password)
        {
            return CustomerHandler.Login(email, password);
        }

        public static String validateRegisterCustomer(String name, String email, String gender, String address, String password)
        {
            String response = "";
            // validasi name, email, gender, address, password lalu return error msg
            if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(gender))
            {
                response = "All field must be filled";
            }
            else if(name.Length < 5 || name.Length > 50)
            {
                response = "Name length must be between 5 and 50 characters";
            }
            else if(CustomerHandler.CheckEmailUnique(email) == false)
            {
                response = "Email must be unique, this email is already registered";
            }
            else if(!address.EndsWith("Street"))
            {
                response = "Address must ends with Street";
            }
            else if(Regex.IsMatch(password, "^[a-zA-Z0-9]*$") == false)
            {
                response = "Password must be alphanumeric";
            }
            else
            {
                doRegister(name, email, gender, address, password);
            }

            return response;
        }
        public static void doRegister(String name, String email, String gender, String address, String password)
        {
            CustomerHandler.CreateCustomer(name, email, gender, address, password, "C");
        }

        public static String doUpdateProfile(int id, String name, String email, String gender, String address, String password)
        {
            String response = "";
            // validasi name, email, gender, address, password lalu return error msg
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(gender))
            {
                response = "All field must be filled";
            }
            else if (name.Length < 5 || name.Length > 50)
            {
                response = "Name length must be between 5 and 50 characters";
            }
            else if (CustomerHandler.CheckEmailUnique(email) == false)
            {
                response = "Email must be unique, this email is already registered";
            }
            else if (!address.EndsWith("Street"))
            {
                response = "Address must ends with Street";
            }
            else if (Regex.IsMatch(password, "^[a-zA-Z0-9]*$") == false)
            {
                response = "Password must be alphanumeric";
            }
            else
            {
                Customer cust = CustomerHandler.GetCustomerById(id);
                CustomerHandler.UpdateCustomer(cust.CustomerID, name, email, gender, address, password);
            }

            return response;

        }

        public static Customer GetCustomerById(int id)
        {
            return CustomerHandler.GetCustomerById(id);
        }
    }
}