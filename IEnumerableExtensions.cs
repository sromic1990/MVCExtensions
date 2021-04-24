using System;
using System.Collections.Generic;

namespace MVCExtensionsLibrary
{
    public static class IEnumerableExtensions
    {
        public static void _Each<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach(T item in enumerable)
            {
                action(item);
            }
        }

        public static void _Each<T>( this IEnumerable<T> enumerable, Action<T, int> action)
        {
            int i = 0;
            foreach (T item in enumerable)
            {
                action(item, i++);
            }
        }
    }
}