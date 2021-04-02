using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class people
    {
        public static void Print(people person)
        {
            Console.WriteLine($"Имя: {person.FirstName} {person.LastName} {person.FatherName}\nВозраст: {person.Age}");
        }

        private int age;
        private string firstName;
        private string lastName;

        private protected static Guid id = Guid.NewGuid();

        public string FatherName
        {
            get;
            set;
        }

        public string FirstName
        {
            get
            {

                return firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    firstName = "unknown";
                }
                else
                {
                    firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {

                return lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    lastName = "unknown";
                }
                else
                {
                    lastName = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value < 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }

            }
        }

        public people()
        {

            Age = 18;
            FirstName = "";
            FatherName ="";
            LastName = "";
        }
        
    }
}
