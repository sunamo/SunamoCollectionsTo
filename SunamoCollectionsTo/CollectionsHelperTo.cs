namespace SunamoCollectionsTo;

/// <summary>
/// Provides helper methods for converting and creating collections.
/// </summary>
public class CollectionsHelperTo
{
    /// <summary>
    /// Converts an array of elements to a List.
    /// </summary>
    /// <typeparam name="T">The type of elements in the array.</typeparam>
    /// <param name="array">The array of elements to convert.</param>
    /// <returns>A List containing all elements from the array.</returns>
    public static List<T> ToList<T>(params T[] array)
    {
        return [.. array];
    }

    /// <summary>
    /// Returns the provided elements as an array (identity function for arrays).
    /// </summary>
    /// <typeparam name="T">The type of elements in the array.</typeparam>
    /// <param name="array">The array of elements.</param>
    /// <returns>The same array that was passed in.</returns>
    public static T[] ToArray<T>(params T[] array)
    {
        return array;
    }

    /// <summary>
    /// Converts an array of objects to a List of strings by calling ToString on each element.
    /// </summary>
    /// <param name="array">The array of objects to convert.</param>
    /// <returns>A List of strings representing each object.</returns>
    public static List<string?> ToListString(params object[] array)
    {
        return array.ToList().ConvertAll(element => element.ToString());
    }
}