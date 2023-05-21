using KpopZtation_GroupB.Handler;
using KpopZtation_GroupB.Model;
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
            return response;
        }
        public static void doRegister(String name, String email, String gender, String address, String password)
        {
            CustomerHandler.CreateCustomer(name, email, gender, address, password, "C");
        }

        public static String doUpdateProfile(String name, String email, String gender, String address, String password)
        {
            String response = "";
            // panggil validateRegisterCustomer
            // update data
            return response;
        }
    }
}