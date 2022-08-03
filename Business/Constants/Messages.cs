using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product is added!";
        public static string ProductNameInvalid = "Product's name is invalid";
        public static string MaintenanceTime = "Maintenance Time!";
        public static string ProductsListed = "Products are listed!";
        public static string ProductCountOfCategoryError = "Category limit is exceded";
        public static string ProductNameAlreadyExist = "Product name is already exists";
        public static string CategoryLimitExceded = "Category limit is exceded";
        public static string AuthorizationDenied = "You don't have authorization!";

        public static string UserAlreadyExists = "User already exists!";
        public static string AccessTokenCreated = "Access token has created";
        public static string SuccessfulLogin = "Login succeded";
        public static string PasswordError = "Password Error!";
        public static string UserNotFound = "User couldn't be found!";
        public static string UserRegistered = "User has been registered successfully";
    }
}
