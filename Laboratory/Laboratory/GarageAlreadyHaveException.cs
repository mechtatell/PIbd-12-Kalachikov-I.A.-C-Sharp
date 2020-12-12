using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory
{
    class GarageAlreadyHaveException : Exception
    {
        public GarageAlreadyHaveException() : base("В гараже уже есть такая машина")
        { }
    }
}
