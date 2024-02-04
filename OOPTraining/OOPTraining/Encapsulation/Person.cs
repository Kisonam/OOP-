using System;
namespace OOPTraining.Encapsulation
{
    public class Person
    {
        // Приватні поля (дані), які будуть інкапсульовані
        private string? name;
        private int age;

        // Властивість для доступу до поля name ззовні класу
        public string Name
        {
            get { return name; }
            set
            {
                // Можна встановити додаткові логіки перевірки перед присвоєнням значення
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Ім'я не може бути порожнім.");
                }
            }
        }

        // Властивість для доступу до поля age ззовні класу
        public int Age
        {
            get { return age; }
            set
            {
                // Можна встановити додаткові логіки перевірки перед присвоєнням значення
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Вік не може бути від'ємним.");
                }
            }
        }

        // Конструктор класу
        public Person(string name, int age)
        {
            // Використання властивостей для інкапсуляції доступу до полів
            Name = name;
            Age = age;
        }

        // Метод, який виводить інформацію про особу
        public void DisplayInfo()
        {
            Console.WriteLine($"Ім'я: {Name}, Вік: {Age}");
        }
    }

}

