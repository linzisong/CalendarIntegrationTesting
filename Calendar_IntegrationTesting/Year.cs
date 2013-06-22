using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calendar_IntegrationTesting
{
    class Year
    {
        private int year;
        private int minY;
        private int maxY;

        public Year(int year)
        {
            if(year >= minY && year <= maxY)
                setYear(year);
            else
            {
                String message = "Year Exception : Year =" + year;
                throw new CalendarException(message);
            }
        }
        public int getYear()
        {
            return this.year;
        }
        public void setYear(int year)
        {
            this.year = year;
        }
        public bool isLeap()
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                return true;
            else
                return false;
        }
        public void increment()
        {
            year ++;
        }
    }
}
