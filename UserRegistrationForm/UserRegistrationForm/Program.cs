﻿namespace UserRegistrationForm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============= WELCOME TO USER REGISTRTION FORM ===================");

            UserForm.userForm();
            UserForm.userEmail();
            UserForm.userMobile();
            UserForm.userPassword();
            UserForm.upperCasePassword();
            UserForm.atleast1numPassword();
            UserForm.atleast1SpecialSymbol();
        }
    }
}