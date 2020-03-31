using System;

namespace MoshClass
{
    public class Person
    {
        public string Name;
        private DateTime _birthdate;
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        public DateTime GetBirtdate()
        {
            return _birthdate;
        }
        public int Age
        {
            get
            {
                var timespan = DateTime.Today - _birthdate;
                var years = timespan.Days / 365;

                return years;
            }
        }
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0},I am {1}", to, Name);
        }
        public static Person Parse(string str)
        {
            var person = new Person
            {
                Name = str
            };

            return person;
        }
    }
}
