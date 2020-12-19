using System;

namespace Laboratory
{
    class GarageAlreadyHaveException : Exception
    {
        public GarageAlreadyHaveException() : base("В гараже уже есть такая машина")
        { }
    }
}
