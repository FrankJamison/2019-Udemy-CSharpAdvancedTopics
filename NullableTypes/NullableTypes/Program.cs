
using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime? is equivalent to Nullable<DateTime>
            DateTime? date = null;
            
            // Nullable Members
            Console.WriteLine("GetValueOrDefault: " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);
            // Console.WriteLine("Value: " + date.Value);       // Throws exception if null

            Console.WriteLine("");

            // Must use GetValueOrDefault to assign nullable DateTime to DateTime
            DateTime? date2 = new DateTime(2014,1,1);
            DateTime date3 = date2.GetValueOrDefault();
            Console.WriteLine(date3);
            
            Console.WriteLine("");

            // Null Coalescing Operator
            // if date is not null use date else set date to today
            DateTime date4 = date ?? DateTime.Today;
            Console.WriteLine(date4);

            Console.WriteLine("");

            // Null coalescing operator identical to tertiary operator
            DateTime date5 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;
            Console.WriteLine(date5);
        }
    }
}
