using System;
using System.Collections.Generic;

public static class EnumerableExtensions
{
    public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> source, int size)
    {
        if (size < 1)
        {
            throw new ArgumentException("청크 크기는 1 이상이어야 합니다.");
        }

        List<T> buffer = new List<T>(size);

        foreach (var item in source)
        {
            buffer.Add(item);

            if (buffer.Count == size)
            {
                yield return buffer;
                buffer = new List<T>(size);
            }
        }

        if (buffer.Count > 0)
        {
            yield return buffer;
        }
    }
}