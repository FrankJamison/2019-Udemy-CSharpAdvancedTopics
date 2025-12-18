using System;

namespace Generics
{
    public class GenericList<T>
    {
        // Add item of specified type to list
        public void Add(T value)
        {
            // Method not implemented
        }

        // Get index of item of specified type in list
        public T this[int index]
        {
            // Method not implemented
            get { throw new NotImplementedException(); }
        }
    }
}