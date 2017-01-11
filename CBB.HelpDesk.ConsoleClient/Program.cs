﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBB.HelpDesk.Models;

namespace CBB.HelpDesk.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterTest();

            IsHolidayTest();

            EqualsTest();

            AnonymousTest();

            AddTicketTest();

            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();

        }

        private static void PrinterTest()
        {
            var printer = new Printer();

            printer.Print<int>(10);

            printer.Print<DateTime>(DateTime.Now);

            printer.Print<string>("Hello World");

        }

        private static void IsHolidayTest()
        {
            var isHoliday = DateTimeHelper.IsHoliday(DateTime.Now);

            isHoliday = DateTime.Now.IsHoliday();

            var result = DateTime.Now.AddWorkingDays(4);

        }

        public static void Test(ref int x)
        {
            x = x + 1;
        }

        public static void Test(User user)
        {
            user.FirstName = "Bartek";
        }

        private static void EqualsTest()
        {

            int x = 10;

            Console.WriteLine(x);

            Test(ref x);


            Console.WriteLine(x);

            var user = new User
            {
                FirstName = "Marcin",
                LastName = "Sulecki"
            };

            // var copyUser = user;
            User copyUser = (User) user.Clone();

            if (copyUser == user)
            {

            }

            

            Test(copyUser);

            var user2 = user;

           

        }

        private static void AnonymousTest()
        {

            // Klasa anonimowa
            var userinfo = new 
            {
                FirstName = "Marcin",
                LastName = "Sulecki",
                Age = 18,
                Weight = 65.5,
            };


        }

        private static void AddTicketTest()
        {
            var user = new User("Marcin", "Sulecki")
            {
                UserId = 2,
            };

            var category = new Category
            {
                CategoryId = 1,
                Name = "IT",
                IsActive = true
            };

            var issue = new Ticket
            {
                TicketId = 1,
                CreateDate = DateTime.Now,
                CreateUser = user,
                Priority = Priority.Normal,
                Category = category
            };


            Console.WriteLine(user);
        }
    }
}
