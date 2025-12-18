using System;

namespace Generics
{
    // CONSTRAINTS
    // where T : IComparable        T is a type that can be compared
    // where T : Product            T is a Class or any of its sub-classes
    // where T : struct             T is a Value Type
    // where T : class              T is a class (reference type)
    // where T : new()              T has a default constructor
    public class Utilities<T> where T : IComparable, new()
    {
        // Return Max Value Method
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            // Instantiate T with default constructor using new() constraint in class
            var obj = new T();
        }

        // Max Value Generic Method using IComparable constraint
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}