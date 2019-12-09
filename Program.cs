using Ardalis.GuardClauses;
using System;

namespace Guard_Clause
{
    public class Foo
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Custom Guard Clauses
            string value = Console.ReadLine();
            CustomGuard.Throw.IfNull(value, value);

            var foo = new Foo();
            Guard.Against.Null(foo, foo.Name);
            Guard.Against.NullOrEmpty(foo.Name, foo.Name);
            //Guard.Against.OutOfRange();
            //Guard.Against.NullOrWhiteSpace()
            //Guard.Against.Default
            Console.ReadLine();
        }
        
    }

    public static class CustomGuard
    {
        public class Throw
        {
            public static void IfNull(object argument, string argumentName)
            {
                if(argument == null)
                    throw new ArgumentNullException(argumentName);   
            }
        }

    }
}
