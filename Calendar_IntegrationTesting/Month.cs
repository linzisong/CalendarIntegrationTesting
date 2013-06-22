using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calendar_IntegrationTesting
{
    class Month
    {
        private int month;
        private Year year;
        private int[] sizeIndex = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public Month(int month, Year year)
        {
            if (month >= 1 && month <= 12)
            {
                setMonth(month, year);
                //闰年            
                if (year.isLeap())
                    sizeIndex[1] = 29;
            }
            else
            {
                String message = "Month Exception : Month =" + month;
                throw new CalendarException(message);
            }
        }

        public void setMonth(int month, Year year)
        {
            this.month = month;
            this.year = year;
        }
        public int getMonth()
        {
            return this.month;
        }
        public int getMonthSize()
        {
            
            return this.sizeIndex[month - 1];
        }
        public bool increment()
        {
            month ++;
            if (month > 12)
                return false;
            else
                return true;
        }
    }
}
