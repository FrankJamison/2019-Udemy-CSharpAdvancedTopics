// Example of generics with struct constraint

using System.Reflection.Emit;

namespace Generics
{
    // Give value types the ability to be nullable
    public class Nullable<T> where T : struct
    {
        private readonly object _value;

        //Constructor without value
        public Nullable()
        {
        }

        // Constructor with value
        public Nullable(T value)
        {
            _value = value;
        }

        // Determine if object has a value
        public bool HasValue
        {
            get { return _value != null; }
        }

        // Return the given value or the default value if null
        public T GetValueOrDefault()
        {
            // If the object has a value, return the value
            if (HasValue)
                return (T)_value;

            // If the object has no value, return the default value for the object type
            return default(T);
        }
    }
}