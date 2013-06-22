using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calendar_IntegrationTesting
{
    class Date
    {
        private Day day;
        private Month month;
        private Year year;
        public Date(Year year, Month month, Day day)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public Date(int year, int month, int day)
        {
            Year y = new Year(year);
            Month m = new Month(month, y);
            Day d = new Day(day, m);
            this.day = d;
            this.month = m;
            this.year = y;
        }

        public void increment()
        {
            if (!day.increment())
            {
                if (!month.increment())
                {
                    year.increment();
                    month.setMonth(1, year);
                }
                day.setDay(1, month);
            }
        }
        public void printDate()
        {
            Console.WriteLine("Date: " + this.year + "-" + this.month + "-" + this.day);
        }
    }
}
