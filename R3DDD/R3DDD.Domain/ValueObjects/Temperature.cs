using System;
using System.Collections.Generic;
using System.Text;

namespace R3DDD.Domain.ValueObjects
{
    public class Temperature
    {
        
        public Temperature(float value)
        {
            Value = value;
        }

        public float Value { get;}
        
    }
}
