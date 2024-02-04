using OOPTraining.Encapsulation;

internal class Program
{
    private static void Main(string[] args)
    {
        // Створення об'єкта класу Person
        Person person = new Person("Іван", 25);

        // Звертання до властивостей для отримання та встановлення значень
        person.Name = "Sofia";
        person.Age = 30;

        // Виклик методу для виведення інформації
        person.DisplayInfo();

        Console.ReadKey();
    }
}