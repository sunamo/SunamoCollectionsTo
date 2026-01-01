namespace SunamoCollectionsTo;

/// <summary>
/// Provides helper methods for converting and creating collections
/// </summary>
public class CollectionsHelperTo
{
    /// <summary>
    /// Converts an array of items to a List
    /// </summary>
    /// <typeparam name="T">The type of elements in the array</typeparam>
    /// <param name="items">The array of items to convert</param>
    /// <returns>A List containing all items from the array</returns>
    public static List<T> ToList<T>(params T[] items)
    {
        return [.. items];
    }

    /// <summary>
    /// Returns the provided items as an array (identity function for arrays)
    /// </summary>
    /// <typeparam name="T">The type of elements in the array</typeparam>
    /// <param name="items">The array of items</param>
    /// <returns>The same array that was passed in</returns>
    public static T[] ToArray<T>(params T[] items)
    {
        return items;
    }

    /// <summary>
    /// Converts an array of objects to a List of strings by calling ToString on each element
    /// </summary>
    /// <param name="items">The array of objects to convert</param>
    /// <returns>A List of strings representing each object</returns>
    public static List<string?> ToListString(params object[] items)
    {
        return items.ToList().ConvertAll(item => item.ToString());
    }
}