namespace SunamoCollectionsTo;

public class CollectionsHelperTo
{
    public static List<T> ToList<T>(params T[] array)
    {
        return [.. array];
    }

    public static T[] ToArray<T>(params T[] array)
    {
        return array;
    }

    public static List<string?> ToListString(params object[] array)
    {
        return array.ToList().ConvertAll(element => element.ToString());
    }
}