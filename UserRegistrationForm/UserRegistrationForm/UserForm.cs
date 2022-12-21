﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationForm
{
    public class UserForm
    {
        public static void userForm()
        {
            string first = @"^[A-Z]{1}[a-z A-Z]{2,10}";

            Console.Write("Enter first name : ");
            string fName = Console.ReadLine();
            Console.Write("Enter last name : ");
            string lName = Console.ReadLine();

            Regex name = new Regex(first);
            bool frst = name.IsMatch(fName);
            bool lst = name.IsMatch(lName);


            if (frst)
            {
                Console.WriteLine($" Valide First Name {fName}");
            }
            else
            {
                Console.WriteLine("Invalide first name");
            }
            if (lst)
            {
                Console.WriteLine($" Valide Last Name {lName}");
            }
            else
            {
                Console.WriteLine("Invalide last name");
            }
        }

        public static void userEmail()
        {
            string emailPattern = @"^[a][b][c]+([.][a-z A-Z 0-9]+)*@[bl]+.[co]{2,10}([.][a-z A-Z]{1,5})?$";
            Console.Write("Enter your email address : ");
            string email = Console.ReadLine();
            Regex emailValidate = new Regex(emailPattern);
            bool emailResult = emailValidate.IsMatch(email);

            if (emailResult)
            {
                Console.WriteLine($" Valide email  {email}");
            }
            else
            {
                Console.WriteLine("Invalide email address.");
            }
        }

        public static void userMobile()
        {
            Console.WriteLine("Enter mobole number : ");
            long userNumber = Convert.ToInt64(Console.ReadLine());

            Regex mob = new Regex(@"[6-9][0-9]{9}");
            bool mobileNum = mob.IsMatch(userNumber.ToString());
            if (mobileNum)
            {
                Console.WriteLine("Valide Mobile number : " + userNumber);
            }
            else
            {
                Console.WriteLine("Invalide Mobile number : " + userNumber);

            }
        }

        public static void userPassword()
        {
            Console.WriteLine("Enter Password  : ");
            string password = Console.ReadLine();

            Regex userPassword = new Regex(@"^[a-z A-Z]{8}");

            bool userPasswordResult = userPassword.IsMatch(password);
            if (userPasswordResult)
            {
                Console.WriteLine($"Valid Password : {password}");
            }
            else
            {
                Console.WriteLine($"Invalide Password : {password}");
            }
        }
        public static void upperCasePassword()
        {
            Console.WriteLine("Enter Password Atleast one character should uppercase : ");
            string password = Console.ReadLine();

            Regex upperCase = new Regex(@"(?=.*[A-Za-z])[a-zA-Z]{8,35}");
            bool oneCharUpper = upperCase.IsMatch(password);
            if (oneCharUpper)
            {
                Console.WriteLine($"Valid uppercase Password : {password}");
            }
            else
            {
                Console.WriteLine($"Invalid uppercase Password : {password}");
            }
        }
        public static void atleast1numPassword()
        {
            Console.WriteLine("Enter Password Atleast 1 uppercase character  and 1 number  : ");
            string password = Console.ReadLine();

            Regex upperCase = new Regex(@"""(?=.*[A-Z])(?=.*\d)[a-zA-Z0-9]{8,30}");
            bool oneCharUpper = upperCase.IsMatch(password);
            if (oneCharUpper)
            {
                Console.WriteLine($"Valid 1 char uppercase & 1 number Password : {password}");
            }
            else
            {
                Console.WriteLine($"Invalid 1 char uppercase & 1 number Password : {password}");
            }
        }
    }
}