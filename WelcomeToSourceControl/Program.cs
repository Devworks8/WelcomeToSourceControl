// Name: Christian Lachapelle
//  Student #: A00230066
//
//  Title: WelcomeToSourceControl
//  Version: 1.0.0
//
//  Description: My "first" source controlled app
//
//
// Program.cs
//
//  Author:
//       Christian Lachapelle <lachapellec@gmail.com>
//
//  Copyright (c) 2021 
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;

namespace WelcomeToSourceControl
{
    public class Person
    {
        private string _FName;
        public string FName
        {
            get => _FName;
            set => _FName = value.Length == 0 ? _FName = "Unknown" : _FName = value;
        }

        private string _LName;
        public string LName
        {
            get => _LName;
            set => _LName = value.Length == 0 ? _LName = "Unknown" : _LName = value;
        }

        private DateTime _DOB;
        public string DOB
        {
            get => Convert.ToString(_DOB);
            set
            {
                if (DateTime.TryParse(Convert.ToString(value), out _DOB));
                else _DOB = Convert.ToDateTime("01-01-1901"); // Set the date to 01-01-1901. I wouldn't do it this way usually.
            }
        }

        public Person()
        {

        }

        public Person(string fname, string lname, string dob)
        {
            FName = fname;
            LName = lname;
            DOB = dob;
        }

        public static string GetInput(string msg)
        {
            Console.Write($"{msg}");
            return Console.ReadLine();
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            // Create and prompt the user for input on seperate lines
            Person person = new Person();

            person.FName = Person.GetInput("Enter First Name: ");
            person.LName = Person.GetInput("Enter Last Name: ");
            person.DOB = Person.GetInput("Enter DOB: ");

            Console.WriteLine($"{person.FName}, {person.LName}, {person.DOB}\n");

            // Create and prompt the user on the same line.
            Person person2 = new Person(Person.GetInput("Enter First Name: "), Person.GetInput("Enter Last Name: "), Person.GetInput("Enter DOB: "));

            Console.WriteLine($"{person2.FName}, {person2.LName}, {person2.DOB}\n");

            Console.ReadKey(true);
        }
    }
}
