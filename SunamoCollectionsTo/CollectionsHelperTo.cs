namespace SunamoCollectionsTo;

public class CollectionsHelperTo
{
    public static List<T> ToList<T>(params T[] items)
    {
        return [.. items];
    }

    public static T[] ToArray<T>(params T[] items)
    {
        return items;
    }

    public static List<string?> ToListString(params object[] items)
    {
        return items.ToList().ConvertAll(item => item.ToString());
    }
}