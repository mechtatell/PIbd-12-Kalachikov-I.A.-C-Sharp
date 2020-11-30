using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory
{
    class GarageOverflowException : Exception
    {
        public GarageOverflowException() : base("В гараже нет свободных мест")
        { }
    }
}
