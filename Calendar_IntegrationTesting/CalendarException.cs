using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calendar_IntegrationTesting
{
    class CalendarException : ApplicationException
    {
        public CalendarException(string message, Exception inner)
            : base(message, inner)
        {
            ;
        }
        public CalendarException(string message)
            : base(message)
        {
            ;
        }
    }  

}
