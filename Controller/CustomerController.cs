using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Controller
{
    public class CustomerController
    {
    
        public static String doLogin(String username, String password)
        {
            String response = "";
            // validasi email dan password lalu return error msg
            return response;
        }

        public static String validateCustomer(String name, String email, String gender, String address, String password)
        {
            String response = "";
            // validasi name, email, gender, address, password lalu return error msg
            return response;
        }
        public static String doRegister(String name, String email, String gender, String address, String password)
        {
            String response = "";
            // panggil validateCustomer
            // insert data
            return response;
        }

        public static String doUpdateProfile(String name, String email, String gender, String address, String password)
        {
            String response = "";
            // panggil validateCustomer
            // update data
            return response;
        }
    }
}