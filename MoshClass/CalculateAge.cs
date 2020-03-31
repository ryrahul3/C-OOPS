using System;

namespace MoshClass
{
    public class CalculateAge
    {
        public DateTime BirthDate { get; private set; }
        public CalculateAge(DateTime birthdate)
        {
            BirthDate = birthdate;
        }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}
