using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Student:people
    {
        private string speciality;

        public string Speciality
        {
            get
            {
                return speciality;
            }
        }
        public Student(string speciality)
        {
            this.speciality = speciality;
        }

        public void info(Student person)
        {
            Student.Print(person);
            Console.WriteLine($"ID:{Student.id} Специальность: {speciality}");

        }

       
    }
}
