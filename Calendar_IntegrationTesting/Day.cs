using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calendar_IntegrationTesting
{
    class Day
    {
        private int day;
        private Month month;
        public Day(int day, Month month)
        {
            if (day > 0 && day <= month.getMonthSize())
                setDay(day, month);
            else
            {
                String message = "Day Exception : Day =" + day;
                throw new CalendarException(message);
            }
        }
        public void setDay(int day, Month month)
        {
            this.day = day;
            this.month = month;
        }
        public int getDay()
        {
            return this.day;
        }
        public bool increment()
        {
            day ++;
            if (day <= month.getMonthSize())
                return true;
            else
                return false;
        }
    }
}
