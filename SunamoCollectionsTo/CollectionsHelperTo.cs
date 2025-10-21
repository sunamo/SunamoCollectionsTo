// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
﻿namespace SunamoCollectionsTo;

public class CollectionsHelperTo
{
    public static List<T> ToList<T>(params T[] t)
    {
        return [.. t];
    }

    public static T[] ToArray<T>(params T[] t)
    {
        return t;
    }

    public static List<string?> ToListString(params object[] t)
    {
        return t.ToList().ConvertAll(d => d.ToString());
    }
}