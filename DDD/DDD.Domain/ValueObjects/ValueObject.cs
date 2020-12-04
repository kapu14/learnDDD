using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.ValueObjects
{
    public abstract class ValueObject<T> where T : ValueObject<T>
    {
        public override bool Equals(object obj)
        {
            var vo = obj as T;
            if (vo == null)
            {
                return false;
            }
            return EqualCore(vo);

        }

        public static bool operator ==(ValueObject<T> v0, ValueObject<T> v1)
        {
            return Equals(v0, v1);
        }

        public static bool operator !=(ValueObject<T> v0, ValueObject<T> v1)
        {
            return !Equals(v0, v1);
        }

        protected abstract bool EqualCore(T other);

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
