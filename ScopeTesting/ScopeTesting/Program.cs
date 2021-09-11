using System;

namespace ScopeTesting
{
    class Program
    {
       interface IComparable<T>
        {
            int CompareTo(T other);
        }

        static T Max<T> (T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        static void Main(string[] args)
        {
            var pig = new Pig();
            pig.animalSound();
        }
    }
}
