using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void FillHuman(people person)
        {
            Console.WriteLine("Введите имя, фамилию,отчество,возраст");
            person.FirstName = Console.ReadLine();
            person.LastName = Console.ReadLine();
            person.FatherName = Console.ReadLine();
            bool check;
            do
            {
                string Ages = Console.ReadLine();
                int age;
                check = true;
                if (int.TryParse(Ages, out age))
                {
                    person.Age = age;
                }
                else
                {
                    Console.WriteLine("Введите значение");
                    check = false;
                }
            }
            while (!check);
        }
        static void Main(string[] args)
        {
            bool firstBool=true;
            int counter = 0;
            do
            {
                Collection array = new Collection();
                bool check;
                Console.WriteLine("Введите специальность на которую желаете попасть");
                string speciality;
                do
                {
                    check = false;
                    speciality = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(speciality))
                    {
                        Console.WriteLine("Обязательно надо ввести специальность");
                        check = true;
                    }
                }
                while (check);               
                Student student = new Student(speciality);
                FillHuman(student);
                array.Add(student);
                Console.WriteLine($"Номер в списке {counter}");
                Console.WriteLine("Введите 1 для записи нового человека, 2 для выхода,3 для просмотра студента из списка");
                string switcher = Console.ReadLine();               
                switch (switcher)
                {
                    case "1":; break;
                    case "2": firstBool = false; break;
                    case "3":
                        Console.WriteLine("Введите Фамилию(LastName) для поиска");
                        string input = Console.ReadLine();
                        Student found = array[input];
                        found.info(found);break;                  
                    default: Console.WriteLine("введите правильное значение"); break;
                }
            }
            while (firstBool);
        }
    }
}
