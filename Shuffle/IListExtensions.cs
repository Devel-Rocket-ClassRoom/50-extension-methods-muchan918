using System;
using System.Collections.Generic;

public static class IListExtensions
{
    private static Random rand = new Random();

    public static IList<T> Shuffle<T>(this IList<T> list)
    {
        if (list == null) 
            throw new ArgumentNullException(nameof(list));

        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = rand.Next(i + 1);
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
        return list;
    }
}