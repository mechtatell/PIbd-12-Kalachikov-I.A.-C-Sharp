using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory
{
    class GarageNotFoundException : Exception
    {
        public GarageNotFoundException(int index) : base("Не найден грузовик по месту " + index)
        { }
    }
}
