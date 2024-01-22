using System;

namespace Vector_de_persoane.git
{
    public class Person
    {
        public string FirstName = "";
        public string LastName = "";
        public int YearOfBirth = 0;
        public int Age => DateTime.Now.Year - YearOfBirth;

    }
}