using System;

namespace PracticeIterators;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Завдання 1: Алфавіт ===");

        Alphabet alphabet = new Alphabet();
        foreach (char letter in alphabet)
        {
            Console.Write($"{letter} ");
        }
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("=== Завдання 2: Будинок і Квартира ===");

        Apartment apt1 = new Apartment(101);
        apt1.AddResident("Олександр Іваненко");
        apt1.AddResident("Марія Іваненко");

        Apartment apt2 = new Apartment(102);
        apt2.AddResident("Дмитро Петренко");

        House house = new House("вул. Дерибасівська, 10");
        house.AddApartment(apt1);
        house.AddApartment(apt2);

        Console.WriteLine($"Будинок: {house.Address}");
        foreach (Apartment apartment in house)
        {
            Console.WriteLine(apartment);
            foreach (string resident in apartment)
            {
                Console.WriteLine($"  - {resident}");
            }
        }

        Console.WriteLine();
        Console.WriteLine("=== Завдання 3: Гараж і Автомобіль ===");

        Garage garage = new Garage("Центральний гараж");
        garage.AddCar(new Car("Toyota", "Camry", 2022));
        garage.AddCar(new Car("BMW", "X5", 2021));
        garage.AddCar(new Car("Audi", "A4", 2020));

        Console.WriteLine($"Гараж: {garage.Name}");
        foreach (Car car in garage)
        {
            Console.WriteLine(car);
        }
    }
}