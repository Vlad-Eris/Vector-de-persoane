using System;

namespace Vector_de_persoane.git
{
    public class Person
    {
        internal string FirstName = "";
        internal string LastName = "";
        internal int YearOfBirth = 0;
        internal int Age = 0;

        public Person(int birthYear)
        {
            Age = DateTime.Now.Year - birthYear;
        }

    }

}