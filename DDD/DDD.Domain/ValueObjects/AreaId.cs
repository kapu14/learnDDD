using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.ValueObjects
{
    public sealed class AreaId :ValueObject<AreaId>
    {
        public AreaId(int value)
        {
            Value = value;
        }

        public int Value { get; }

        protected override bool EqualCore(AreaId other)
        {
            return Value == other.Value;
        }
        public string DisplayValue
        {
            get
            {
                return Value.ToString().PadLeft(4, '0');
            }
        }
    }
}
