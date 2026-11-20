namespace SunamoCollectionsTo;

/// <summary>
/// Represents the collections helper to type.
/// </summary>
public class CollectionsHelperTo
{
    /// <summary>
    /// To list t.
    /// </summary>
    /// <typeparam name="T">The type T.</typeparam>
    /// <param name="array">The array.</param>
    /// <returns>The to list t result.</returns>
    public static List<T> ToList<T>(params T[] array)
    {
        return [.. array];
    }

    /// <summary>
    /// To array t.
    /// </summary>
    /// <typeparam name="T">The type T.</typeparam>
    /// <param name="array">The array.</param>
    /// <returns>The to array t result.</returns>
    public static T[] ToArray<T>(params T[] array)
    {
        return array;
    }

    /// <summary>
    /// To list string.
    /// </summary>
    /// <param name="array">The array.</param>
    /// <returns>The to list string result.</returns>
    public static List<string?> ToListString(params object[] array)
    {
        return array.ToList().ConvertAll(element => element.ToString());
    }
}