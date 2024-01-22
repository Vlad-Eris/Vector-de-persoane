using System;

namespace Vector_de_persoane.git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de persoane: ");
            int numarPersoane = Convert.ToInt32(Console.ReadLine());

            Person[] vectorPersoane = new Person[numarPersoane];

            Person persoana1 = new Person();
            persoana1.FirstName = "Somogy";
            persoana1.LastName = "Brian";
            persoana1.YearOfBirth = 2005;
            persoana1.Age = 2024 - 2005;

        }
    }
}

